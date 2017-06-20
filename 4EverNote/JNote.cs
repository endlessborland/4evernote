using System;

namespace _4EverNote
{
    /// <summary>
    /// This class is used for JSON serialization/deserialization
    /// </summary>
    class JNote
    {
        public bool IsReminderSet { get; set; } // Is the reminder set
        public string GUID { get; set; } // Note GUID
        public string Title { get; set; } // Note name
        public string Content { get; set; } // Note content
        public DateTime Created { get; set; } // Note creation time
        public DateTime EventTime { get; set; } // Event start time
        public DateTime ReminderTime { get; set; } // Reminder time
        public string Address { get; set; } // Note address
        public string Reminder { get; set; } // Event reminder text
    }
}
