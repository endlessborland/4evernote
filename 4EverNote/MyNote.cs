using Evernote.EDAM.Type;
using EvernoteSDK.Advanced;
using Newtonsoft.Json;
using System.Text.RegularExpressions;

namespace _4EverNote
{
    public class MyNote
    {
        private string _name;
        private Note newNote;

        /// <summary>
        /// All the info inside the ENNote.Content
        /// </summary>
        public JSONNote Info;

        public string Name
        {
            get
            {
                return _name;
            }

            set
            {
                _name = value;
            }
        }

        public MyNote()
        {
            newNote = new Note();
            Info = new JSONNote();
        }

        public MyNote(string name)
        {
            newNote = new Note();
            Info = new JSONNote();
            Name = name;
        }

        public MyNote(string name, string content)
        {
            newNote = new Note();
            Info = new JSONNote();
            Name = name;
            Info.Content = content;
        }

        /// <summary>
        /// Makes a string of JSON
        /// </summary>
        private void FormatNote()
        {
            string serizlized = JsonConvert.SerializeObject(Info);
            newNote.Title = Name.ToString();
            var writer = new ENMLWriter();
            writer.WriteStartDocument();
            writer.WriteString("4evernote-5836");
            writer.WriteString(serizlized);
            writer.WriteEndDocument();
            newNote.Content = writer.Contents.ToString();
            newNote.NotebookGuid = LoginInfo.EverNotebook.Guid;
        }

        /// <summary>
        /// Uploading the note on the server
        /// </summary>
        /// <returns>Note title</returns>
        public string CreateNote()
        {
            FormatNote();
            var result = LoginInfo.NoteStore.CreateNote(newNote);
            return result.Title;
        }

        /// <summary>
        /// Parses the JSON into MyNote
        /// </summary>
        /// <param name="one">Downloaded Evernote.EDAM.Type.Note</param>
        /// <param name="name">Note name</param>
        /// <returns></returns>
        public static MyNote ParseNote(Note one, string name)
        {
            MyNote n = new MyNote();
            string con = Regex.Match(one.Content, @"(?<=<en-note>)(.*)(?=</en-note>)").ToString();
            if (con.StartsWith("4evernote-5836") == false)
                return null;
            con = con.Substring(14);
            n.Info = JsonConvert.DeserializeObject<JSONNote>(con);
            n.Name = name;
            return n;
        }

        /// <summary>
        /// Parses the JSON into MyNote
        /// </summary>
        /// <param name="one">Downloaded Evernote.EDAM.Type.Note</param>
        /// <returns></returns>
        public static MyNote ParseNote(Note one)
        {
            MyNote n = new MyNote();
            string con = Regex.Match(one.Content, @"(?<=<en-note>)(.*)(?=</en-note>)").ToString();
            if (con.StartsWith("4evernote-5836") == false)
                return null;
            con = con.Substring(14);
            n.Info = JsonConvert.DeserializeObject<JSONNote>(con);
            n.Name = one.Title;
            return n;
        }
    }
}
