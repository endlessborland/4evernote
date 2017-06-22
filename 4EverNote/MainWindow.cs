using Evernote.EDAM.NoteStore;
using System;
using System.Collections.Generic;
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
        private Dictionary<int, string> id_guid;

        public MainWindow()
        {
            InitializeComponent();
            id_guid = new Dictionary<int, string>();
        }

        /// <summary>
        /// Refreshes the table from the localDB
        /// </summary>
        private void RefreshGrid()
        {
            dataGrid.Rows.Clear();
            id_guid.Clear();
            var i = 0;
            GetNoteCount();
            dataGrid.Rows.Add(noteCount - 1);
            foreach (var file in Directory.GetFiles(Environment.GetEnvironmentVariable("TEMP") + "\\endlessborland-5836"))
            {
                if (file == null) return;
                var guid = Path.GetFileName(file);
                var note = localDB.ReadNote(guid);
                dataGrid.Rows[i].Cells[0].Value = i;
                dataGrid.Rows[i].Cells[1].Value = note.Info.Title;
                dataGrid.Rows[i].Cells[3].Value = note.Info.Content;
                dataGrid.Rows[i].Cells[2].Value = note.Info.EventTime;
                id_guid.Add(i, note.Guid);
                i++;
            }
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
            RefreshGrid();
        }


        /// <summary>
        /// Adds a note to server and to the local DB
        /// </summary>
        private async void addButton_Click(object sender, EventArgs e)
        {
            if (titleBox.Text == "")
            {
                MessageBox.Show("Title cannot be empty");
                return;
            }
            var note = new FNote();
            note.Info.Title = titleBox.Text;
            note.Info.Address = addressBox.Text;
            note.Info.Content = contentBox.Text;
            note.Info.Reminder = reminderBox.Text;
            if (eventSet.Checked)
                note.Info.EventTime = eventTime.Value.ToString();
            else
            {
                note.Info.EventTime = null;
                note.Info.IsEventSet = false;
            }
            if (reminderSet.Checked)
                note.Info.ReminderTime = eventTime.Value.ToString();
            else
            {
                note.Info.ReminderTime = null;
                note.Info.IsReminderSet = false;
            }
            note.Info.Created = DateTime.Now.ToString();
            note.Info.IsEventSet = eventSet.Checked;
            note.Info.IsReminderSet = reminderSet.Checked;
            await note.UploadNoteAsync();
            localDB.WriteNote(note);
            RefreshGrid();
        }

        private void eventSet_CheckedChanged(object sender, EventArgs e)
        {
            if (eventTime.Enabled)
                eventTime.Enabled = false;
            else
                eventTime.Enabled = true;
        }

        private void reminderSet_CheckedChanged(object sender, EventArgs e)
        {
            if (reminderTime.Enabled)
                reminderTime.Enabled = false;
            else
                reminderTime.Enabled = true;
        }

        private void exit_Click(object sender, EventArgs e)
        {
            ESession.Logout();
        }

        private async void deleteButton_Click(object sender, EventArgs e)
        {
            var thisRow = dataGrid.CurrentRow;
            var guid = id_guid[int.Parse(thisRow.Cells[0].Value.ToString())];
            var note = localDB.ReadNote(guid);
            localDB.DeleteNote(note.Guid);
            await note.DeleteNoteAsync();
            RefreshGrid();
        }

        private void dataGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var thisRow = dataGrid.CurrentRow;
            var guid = id_guid[int.Parse(thisRow.Cells[0].Value.ToString())];
            var note = localDB.ReadNote(guid);
            var window = new NoteWindow(note, ref localDB);
            window.Show();
            RefreshGrid();
        }
    }
}
