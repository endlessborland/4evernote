using Evernote.EDAM.NoteStore;
using System;
using System.ComponentModel;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _4EverNote
{
    public partial class MainWindow : Form
    {
        private DataBase localDB;
        private int noteCount;

        public MainWindow()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Counts the number of notes in the 4evernote notebook
        /// </summary>
        private void GetNoteCount()
        {
            var noteFilter = new NoteFilter();
            noteFilter.NotebookGuid = ESession.NoteBook.Guid;
            var noteCollection = ESession.NoteStore.FindNotesCount(noteFilter, false);
            if (noteCollection.NotebookCounts == null)
            {
                noteCount = 0;
                return;
            }
            if (noteCollection.NotebookCounts.ContainsKey(ESession.NoteBook.Guid))
                noteCount = noteCollection.NotebookCounts[ESession.NoteBook.Guid];
            else
                noteCount = 0;
        }
        
        /// <summary>
        /// Downloads all the files from cloud service to local DB
        /// </summary>
        private async Task RefreshLocalDataBaseAsync()
        {
            await Task.Run(async () =>
            {
                localDB = new DataBase();
                GetNoteCount();
                var noteFilter = new NoteFilter();
                noteFilter.NotebookGuid = ESession.NoteBook.Guid;
                NoteList everNoteList;
                for (var i = 0; i < noteCount; i++)
                {
                    everNoteList = ESession.NoteStore.FindNotes(noteFilter, i, 1);
                    var note = new FNote();
                    await note.DownloadNoteAsync(everNoteList.Notes[0].Guid);
                    note.Guid = everNoteList.Notes[0].Guid;
                    localDB.WriteNote(note);
                }
            });
        }

        private async void MainWindow_Load(object sender, EventArgs e)
        {
            // logging in
            try
            {
                ESession.Login();
            }
            catch (NullReferenceException)
            {
                // that happens if the login window is closed before auth
                Application.Exit();
            }
            await RefreshLocalDataBaseAsync();
        }


        /// <summary>
        /// Adds a note to server and to the local DB
        /// </summary>
        private async void addButton_Click(object sender, EventArgs e)
        {
            var note = new FNote();
            note.Info.Title = titleBox.Text;
            note.Info.Address = addressBox.Text;
            note.Info.Content = contentBox.Text;
            note.Info.Reminder = reminderBox.Text;
            note.Info.EventTime = eventTime.Value.ToString();
            note.Info.ReminderTime = eventTime.Value.ToString();
            note.Info.IsEventSet = true;
            note.Info.IsReminderSet = true;
            note.Info.Created = DateTime.Now.ToString();
            await note.UploadNoteAsync();
            localDB.WriteNote(note);
        }
    }
}
