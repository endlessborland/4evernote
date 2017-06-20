using Evernote.EDAM.NoteStore;
using System;
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

        private void GetNoteCount()
        {
            var noteFilter = new NoteFilter();
            noteFilter.NotebookGuid = ESession.NoteBook.Guid;
            var noteCollection = ESession.NoteStore.FindNotesCount(noteFilter, false);
            noteCount = noteCollection.NotebookCounts[ESession.NoteBook.Guid];
        }
        
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
                    note.Info.GUID = everNoteList.Notes[0].Guid;
                    localDB.WriteNote(note);
                    note = null;
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
    }
}
