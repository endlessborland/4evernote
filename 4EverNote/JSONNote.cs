using System;

namespace _4EverNote
{
    public class JSONNote
    {
        public string Content { get; set; }
        public DateTime Created { get; set; }
        public DateTime EventTime { get; set; }
        public DateTime ReminderTime { get; set; }
        public string Address { get; set; }
        public string Reminder { get; set; }
    }
}
