using Evernote.EDAM.Type;
using EvernoteSDK.Advanced;
using System.Windows.Forms;

namespace _4EverNote
{
    static class ESession
    {

        #region private EDAM and Evernote SDK vars

        static private Notebook _noteBook;
        static private ENNoteStoreClient _noteStore;
        static private ENSessionAdvanced _session;

        #endregion

        #region public properties

        /// <summary>
        /// the 4EverNote Notebook
        /// </summary>
        public static Notebook NoteBook
        {
            get
            {
                return _noteBook;
            }
        }

        /// <summary>
        /// NoteStore
        /// </summary>
        public static ENNoteStoreClient NoteStore
        {
            get
            {
                return _noteStore;
            }
        }

        /// <summary>
        /// Session
        /// </summary>
        public static ENSessionAdvanced Session
        {
            get
            {
                return _session;
            }
        }

        #endregion

        static public void Login()
        {
            var notebookExists = false;
            // log in to Evernote cloud service
            ENSessionAdvanced.SetSharedSessionConsumerKey("endlessborland-5836", "e83cae88abd45ca7", "sandbox.evernote.com");
            if (ENSessionAdvanced.SharedSession.IsAuthenticated == false)
            {
                ENSessionAdvanced.SharedSession.AuthenticateToEvernote();
            }
            // if the login failed
            if (ENSessionAdvanced.SharedSession.IsAuthenticated == false)
            {
                MessageBox.Show("The authentication failed");
                Application.Exit();
            }
            // setting session
            _session = ENSessionAdvanced.SharedSession;
            // creating a NoteStore for advanced functionality
            _noteStore = ENSessionAdvanced.SharedSession.PrimaryNoteStore;
            var NotebookList = _noteStore.ListNotebooks();
            foreach (var a in NotebookList)
            {
                // searching for existing Notebook
                if (a.Name == "4EverNote")
                {
                    notebookExists = true;
                    _noteBook = a;
                }
            }
            // creating a Notebook, if it doesn't exist
            if (notebookExists == false)
            {
                var notebook = new Notebook();
                notebook.Name = "4EverNote";
                _noteBook = _noteStore.CreateNotebook(notebook);
            }
            // cleaning up the mess we made
            NotebookList.Clear();
            NotebookList = null;
        }

        static public void Logout()
        {
            ENSessionAdvanced.SharedSession.Preferences.RemoveAllObjects();
        }
    }
}
