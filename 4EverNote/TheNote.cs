using System;
using System.Windows.Forms;

namespace _4EverNote
{
    public partial class TheNote : Form
    {
        private MyNote _note;
        private string _guid;

        public TheNote(MyNote note, string guid)
        {
            InitializeComponent();
            _note = note;
            _guid = guid;
        }

        private void TheNote_Load(object sender, EventArgs e)
        {
            title.Text = _note.Name;
            content.Text = _note.Info.Content;
            creation.Value = _note.Info.Created;
            eventTime.Value = _note.Info.EventTime;
            reminder.Value = _note.Info.ReminderTime;
            reminderText.Text = _note.Info.Reminder;
            address.Text = _note.Info.Address;
            if (eventTime.Value == DateTime.MinValue.AddYears(1755)) // if the date is not set - let's set it to a minimum possible date! (almost)
                eventTime.Visible = false;
            if (reminder.Value == DateTime.MinValue.AddYears(1755))
                reminder.Visible = false;
        }
    }
}
