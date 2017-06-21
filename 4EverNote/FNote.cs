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
        private Note newNote;
        private string _serizlized;
        private string guid;

        public JNote Info;

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

        public string Guid
        {
            get
            {
                return guid;
            }

            set
            {
                guid = value;
            }
        }

        public FNote()
        {
            _isValid = true;
            newNote = new Note();
            Info = new JNote();
        }

        public FNote(string serialized, string GUID)
        {
            _isValid = true;
            newNote = new Note();
            Info = new JNote();
            guid = GUID;
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
            newNote.Title = Info.Title;
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
                guid = ESession.NoteStore.CreateNote(newNote).Guid;
                return guid;
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
                    guid = GUID;
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
            if (noteContent.StartsWith("4evernote-5836"))
                goto skip;
            noteContent = Regex.Match(noteContent, @"(?<=<en-note>)(.*)(?=</en-note>)").ToString();
            if (!noteContent.StartsWith("4evernote-5836"))
            {
                IsValid = false;
                return;
            }
            skip:
            _serizlized = noteContent;
            noteContent = noteContent.Substring(14);
            try
            {
                Info = JsonConvert.DeserializeObject<JNote>(noteContent);
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
                ESession.NoteStore.DeleteNote(guid);
            });
        }
    }
}
