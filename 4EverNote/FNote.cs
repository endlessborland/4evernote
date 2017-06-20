using Evernote.EDAM.Type;
using EvernoteSDK.Advanced;
using Newtonsoft.Json;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _4EverNote
{
    class FNote
    {
        private bool _isValid;
        private string _name;
        private Note newNote;
        private string _serizlized;

        public JNote Info;

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

        public bool IsValid
        {
            get
            {
                return _isValid;
            }

            set
            {
                _isValid = value;
            }
        }

        public string Serizlized
        {
            get
            {
                return _serizlized;
            }

            set
            {
                _serizlized = value;
            }
        }

        public FNote()
        {
            _isValid = true;
            newNote = new Note();
            Info = new JNote();
        }

        public FNote(string serialized)
        {
            _isValid = true;
            newNote = new Note();
            Info = new JNote();
            ParseToFNote(serialized);
        }

        /// <summary>
        /// Makes a string of JSON
        /// </summary>
        private void NoteToJSON()
        {
            _serizlized = "4evernote-5836" + JsonConvert.SerializeObject(Info);
            var writer = new ENMLWriter();
            writer.WriteStartDocument();
            writer.WriteString(_serizlized);
            writer.WriteEndDocument();
            newNote.Content = writer.Contents.ToString();
            newNote.NotebookGuid = ESession.NoteBook.Guid;
            newNote.Title = _name;
        }

        /// <summary>
        /// Uploads the note
        /// </summary>
        /// <returns>GUID of the uploaded note</returns>
        public async Task<string> UploadNoteAsync()
        {
            return await Task.Run(() =>
            {
                NoteToJSON();
                return ESession.NoteStore.CreateNote(newNote).Guid;
            });
        }

        /// <summary>
        /// Downloads the note
        /// </summary>
        /// <param name="GUID">Note GUID</param>
        public async Task DownloadNoteAsync(string GUID)
        {
            await Task.Run(() =>
            {
                try
                {
                    newNote = ESession.NoteStore.GetNote(GUID, true, false, false, false);
                    ParseToFNote(newNote.Content);
                }
                catch
                {
                    MessageBox.Show("Error downloading");
                }
            });
        }

        /// <summary>
        /// Parses the Note Content into FNote
        /// </summary>
        /// <param name="note">Content</param>
        private void ParseToFNote(string noteContent)
        {
            noteContent = Regex.Match(noteContent, @"(?<=<en-note>)(.*)(?=</en-note>)").ToString();
            if (!noteContent.StartsWith("4evernote-5836"))
            {
                IsValid = false;
            }
            _serizlized = noteContent;
            noteContent = noteContent.Substring(14);
            try
            {
                Info = JsonConvert.DeserializeObject<JNote>(noteContent);
                Name = Info.Title;
            }
            catch
            {
                IsValid = false;
            }
            
        }

        /// <summary>
        /// Deletes the note from cloud evernote DB and from the local DB
        /// </summary>
        /// <param name="ID">Local ID</param>
        public async Task DeleteNoteAsync()
        {
            await Task.Run(() =>
            {
                ESession.NoteStore.DeleteNote(Info.GUID);
            });
        }
    }
}
