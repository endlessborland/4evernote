using System;

namespace _4EverNote
{
    /// <summary>
    /// This class is used for JSON serialization/deserialization
    /// </summary>
    class JNote
    {
        public bool IsReminderSet { get; set; } // Is the reminder set
        public bool IsEventSet { get; set; } // Is the event time set
        public string Title { get; set; } // Note name
        public string Content { get; set; } // Note content
        public string Created { get; set; } // Note creation time
        public string EventTime { get; set; } // Event start time
        public string ReminderTime { get; set; } // Reminder time
        public string Address { get; set; } // Note address
        public string Reminder { get; set; } // Event reminder text
    }
}
