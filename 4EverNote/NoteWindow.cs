using System;
using System.Windows.Forms;

namespace _4EverNote
{
    public partial class NoteWindow : Form
    {
        FNote _note;
        DataBase _localDB;

        public NoteWindow()
        {
            InitializeComponent();
        }

        public NoteWindow(FNote note, ref DataBase localDB)
        {
            InitializeComponent();
            _note = note;
            _localDB = localDB;
            TopMost = true;
        }

        private void NoteWindow_Load(object sender, EventArgs e)
        {
            titleBox.Text = _note.Info.Title;
            contentBox.Text = _note.Info.Content;
            reminderBox.Text = _note.Info.Reminder;
            addressBox.Text = _note.Info.Address;
            if (!_note.Info.IsEventSet)
            {
                eventSet.Checked = false;
                eventTime.Hide();
            }
            else
                eventTime.Value = DateTime.Parse(_note.Info.EventTime);
            if (!_note.Info.IsReminderSet)
            {
                reminderSet.Checked = false;
                reminderTime.Hide();
            }
            else
                reminderTime.Value = DateTime.Parse(_note.Info.ReminderTime);
            createdTime.Value = DateTime.Parse(_note.Info.Created);
        }

        private async void saveButton_Click(object sender, EventArgs e)
        {
            if (titleBox.Text == "")
            {
                MessageBox.Show("Title cannot be empty");
                return;
            }
            _note.Info.Title = titleBox.Text;
            _note.Info.Address = addressBox.Text;
            _note.Info.Content = contentBox.Text;
            _note.Info.Reminder = reminderBox.Text;
            if (eventSet.Checked)
                _note.Info.EventTime = eventTime.Value.ToString();
            else
            {
                _note.Info.EventTime = null;
                _note.Info.IsEventSet = false;
            }
            if (reminderSet.Checked)
                _note.Info.ReminderTime = reminderTime.Value.ToString();
            else
            {
                _note.Info.ReminderTime = null;
                _note.Info.IsReminderSet = false;
            }
            _note.Info.Created = DateTime.Now.ToString();
            _note.Info.IsEventSet = eventSet.Checked;
            _note.Info.IsReminderSet = reminderSet.Checked;
            await _note.UpdateNoteAsync();
            _localDB.WriteNote(_note);
            Close();
        }

        private void eventSet_CheckedChanged(object sender, EventArgs e)
        {
            eventTime.Show();
            if (eventTime.Enabled)
                eventTime.Enabled = false;
            else
                eventTime.Enabled = true;
        }

        private void reminderSet_CheckedChanged(object sender, EventArgs e)
        {
            reminderTime.Show();
            if (reminderTime.Enabled)
                reminderTime.Enabled = false;
            else
                reminderTime.Enabled = true;
        }
    }
}
