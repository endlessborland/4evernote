using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _4EverNote
{
    public class DataBase
    {
        private string _path;
        

        /// <summary>
        /// Initializes a local DB
        /// </summary>
        public DataBase()
        {
            var path = new DirectoryInfo((Environment.GetEnvironmentVariable("TEMP") + "\\endlessborland-5836"));
            CheckDirectory(path);
            _path = Environment.GetEnvironmentVariable("TEMP") + "\\endlessborland-5836";
        }

        /// <summary>
        /// Creates LocalDataBase (just a folder) somewhere at %temp%
        /// </summary>
        private void CheckDirectory(DirectoryInfo path)
        {
            if (!path.Exists)
                path.Create();
        }

        /// <summary>
        /// Reads the specific Note
        /// </summary>
        /// <param name="GUID">Note GUID</param>
        /// <returns></returns>
        public FNote ReadNote(string GUID)
        {
            string serialized;
            string path = _path + "\\" + GUID;
            using (var reader = new StreamReader(path))
            {
                serialized = reader.ReadToEnd();
            }
            return new FNote(serialized, GUID);
        }    

        /// <summary>
        /// Writes the note in the DB directory
        /// It will have the name of the Note's GUID
        /// </summary>
        /// <param name="note">Note</param>
        public void WriteNote(FNote note)
        {
            
            string path = _path + "\\" + note.Guid;
            using (StreamWriter writer = File.CreateText(path))
            {
                writer.WriteLine(note.Serizlized);
            }
        }

        /// <summary>
        /// Deletes Note from the local DB
        /// </summary>
        /// <param name="GUID">Note GUID</param>
        public void DeleteNote(string GUID)
        {
            File.Delete(_path + "\\" + GUID);
        }

        static int CompareByDateString(KeyValuePair<string, string> a, KeyValuePair<string, string> b)
        {
            return a.Value.CompareTo(b.Value);
        }

        /// <summary>
        /// Returns a sorted datetime list of note IDs
        /// </summary>
        /// <returns>SortedDictionary</returns>
        public async Task<List<KeyValuePair<string, string>>> GetReminderTimeInfoAsync()
        {
           return await Task.Run(() =>
            {
                FNote note;
                bool reminderExists = false;
                var GuidTimeTable = new List<KeyValuePair<string, string>>();
                string[] files = Directory.GetFiles(_path);
                foreach (var file in files)
                {
                    note = ReadNote(Path.GetFileName(file));
                    if (note.Info.IsReminderSet)
                    {
                        reminderExists = true;
                        if (string.Compare(note.Info.ReminderTime, DateTime.Now.ToString()) > 0)
                            GuidTimeTable.Add(new KeyValuePair<string, string>(note.Guid, note.Info.ReminderTime));
                    }
                }
                if (!reminderExists) return null;
                GuidTimeTable.Sort(CompareByDateString);
                return GuidTimeTable;
            });
        } 
    }
}
