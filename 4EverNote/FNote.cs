using Evernote.EDAM.Type;
using EvernoteSDK.Advanced;
using Newtonsoft.Json;
using System;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _4EverNote
{
    public class FNote
    {
        private Note newNote;
        private string _serizlized;
        private string guid;

        public JNote Info;

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

        public bool IsValid { get; private set; } = true;

        public FNote()
        {
            newNote = new Note();
            Info = new JNote();
        }

        public FNote(string serialized, string GUID)
        {
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
        /// Updates the note
        /// </summary>
        public async Task UpdateNoteAsync()
        {
            await Task.Run(() =>
            {
                NoteToJSON();
                newNote.Guid = guid;
                ESession.NoteStore.UpdateNote(newNote);
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
                    IsValid = false;
                }
            });
        }

        /// <summary>
        /// Parses the Note Content into FNote
        /// </summary>
        /// <param name="note">Content</param>
        private void ParseToFNote(string noteContent)
        {
            if (!noteContent.StartsWith("4evernote-5836"))
            {
                noteContent = Regex.Match(noteContent, @"(?<=<en-note>)(.*)(?=</en-note>)").ToString();
                if (!noteContent.StartsWith("4evernote-5836"))
                {
                    throw new Exception();
                }
            }
            _serizlized = noteContent;
            noteContent = noteContent.Substring(14);
            try
            {
                Info = JsonConvert.DeserializeObject<JNote>(noteContent);
            }
            catch
            {
                throw new Exception();
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
