using System;
using System.Windows.Forms;
using Evernote.EDAM.NoteStore;
using Evernote.EDAM.Type;
using System.Collections.Generic;
using System.Linq;
using System.Media;

namespace _4EverNote
{
    public partial class Form1 : Form
    {
        private Dictionary<int, string> id_guid;
        private SortedDictionary<DateTime, string> date_guid;
        private ICollection<DateTime> keys;

        public Form1()
        {
            InitializeComponent();
            id_guid =  new Dictionary<int, string>();
            date_guid = new SortedDictionary<DateTime, string>();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            try
            {
                // logging in
                LoginInfo.Login();
            } catch (NullReferenceException)
            {
                // that happens if the login window is closed before auth
                Application.Exit();
            }
            RefreshGrid();
        }

        /// <summary>
        /// Refreshes the table
        /// </summary>
        private void RefreshGrid()
        {
            // clear all the tables and rows
            dataGrid.Rows.Clear();
            id_guid.Clear();
            date_guid.Clear();
            int i = 0;
            int j = 0;
            bool invalid = false;
            // download all the notes from user's account, form them into list
            var a = new NoteFilter();
            a.NotebookGuid = LoginInfo.EverNotebook.Guid;
            NoteList nlist = LoginInfo.NoteStore.FindNotes(a, 0, 1000);
            List<Note> _nlist = nlist.Notes;
            if (_nlist.Count == dataGrid.Rows.Count - 1)
                return;
            // let the magic happen
            foreach (var note in _nlist)
            {
                // parse each note into MyNote
                MyNote parsednote;
                parsednote = MyNote.ParseNote(LoginInfo.NoteStore.GetNote(note.Guid, true, false, false, false), note.Title);
                if (parsednote == null)
                    continue;
                // add a new row
                if (_nlist.Count > dataGrid.Rows.Count)
                    dataGrid.Rows.Add();
                // place some data into the table
                dataGrid.Rows[i].Cells[0].Value = i;
                id_guid.Add(i, note.Guid);
                while (invalid == false)
                {
                    try
                    {
                        if (DateTime.Compare(DateTime.Now, parsednote.Info.ReminderTime) < 0)
                        {
                            date_guid.Add(parsednote.Info.ReminderTime.AddSeconds(j), note.Guid);
                        }
                        invalid = true;
                    }
                    catch (ArgumentException)
                    {
                        j++;
                    }
                }
                dataGrid.Rows[i].Cells[1].Value = parsednote.Name;
                if (parsednote.Info.EventTime != null)
                {
                    if (parsednote.Info.EventTime == DateTime.MinValue.AddYears(1755))
                        dataGrid.Rows[i].Cells[2].Value = "none";
                    else
                        dataGrid.Rows[i].Cells[2].Value = parsednote.Info.EventTime;
                }
                if (parsednote.Info.Content != null)
                {
                    if (parsednote.Info.Content.Length < 15)
                        dataGrid.Rows[i].Cells[3].Value = parsednote.Info.Content;
                    else
                        dataGrid.Rows[i].Cells[3].Value = parsednote.Info.Content.Remove(0, 14) + "...";
                }
                    
                i++;
                invalid = false;
            }
            // "sorting" notes using reminder's time
            keys = date_guid.Keys;            
        }

        private void exit_Click(object sender, EventArgs e)
        {
            // logging out
            LoginInfo.Logout();
            Application.Exit();
        }


        private void addNote_Click(object sender, EventArgs e)
        {
            var a = new MyNote(titlebox.Text, contentbox.Text);
            // address
            if (isAddress.Checked == true)
                a.Info.Address = addressbox.Text;
            else
                a.Info.Address = null;
            // reminder text
            if (isReminder.Checked == true)
                a.Info.Reminder = reminderbox.Text;
            else
                a.Info.Reminder = null;
            a.Info.Created = DateTime.Now;
            // event time
            if (isEventTime.Checked == true)
                a.Info.EventTime = eventTime.Value;
            else
                a.Info.EventTime = DateTime.MinValue.AddYears(1755);
            // reminder time
            if (isReminderTime.Checked == true)
                a.Info.ReminderTime = reminderTime.Value;
            else
                a.Info.ReminderTime = DateTime.MinValue.AddYears(1755);
            // creating a note and refreshing the grid
            a.CreateNote();
            RefreshGrid();
        }

        
        private void refresh_Click(object sender, EventArgs e)
        {
            RefreshGrid();
        }

        private void dataGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var thisRow = dataGrid.CurrentRow;
            string guid = id_guid[Int32.Parse(thisRow.Cells[0].Value.ToString())];
            var window = new TheNote(MyNote.ParseNote(LoginInfo.NoteStore.GetNote(guid, true, false, false, false)), guid);
            window.Show();
        }

        private void delete_Click(object sender, EventArgs e)
        {
            var thisRow = dataGrid.CurrentRow;
            string guid = id_guid[Int32.Parse(thisRow.Cells[0].Value.ToString())];
            LoginInfo.NoteStore.DeleteNote(guid);
        }

        private void isAddress_CheckedChanged(object sender, EventArgs e)
        {
            addressbox.ReadOnly = true;
        }

        private void isReminder_CheckedChanged(object sender, EventArgs e)
        {
            reminderbox.ReadOnly = true;
        }

        private void isEventTime_CheckedChanged(object sender, EventArgs e)
        {
            eventTime.Enabled = false;
        }

        private void isReminderTime_CheckedChanged(object sender, EventArgs e)
        {
            reminderTime.Enabled = false;
        }

        // timer for reminders
        private void timer1_Tick(object sender, EventArgs e)
        {
            
            // if (keys.First() < DateTime.Now.AddMinutes(1) && keys.First() > DateTime.Now)
            // if the time is right - show the event info
            if (DateTime.Compare(keys.First(), DateTime.Now.AddMinutes(1)) <= 0 && DateTime.Compare(keys.First(), DateTime.Now) >= 0)
            {
                string guid = date_guid[keys.First()];
                date_guid.Remove(keys.First());
                var window = new TheNote(MyNote.ParseNote(LoginInfo.NoteStore.GetNote(guid, true, false, false, false)), guid);
                SystemSounds.Beep.Play(); // dat sound
                window.TopMost = true;
                window.Show();
            }
        }
    }
}
