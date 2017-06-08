using Evernote.EDAM.Type;
using EvernoteSDK.Advanced;

namespace _4EverNote
{
    static class LoginInfo
    {
        static private Notebook _noteBook;
        static private ENNoteStoreClient _noteStore;
        static private ENSessionAdvanced _session;

        static public Notebook EverNotebook
        {
            get { return _noteBook; }
        }

        static public ENNoteStoreClient NoteStore
        {
            get { return _noteStore; }
        }

        static public ENSessionAdvanced Session
        {
            get { return _session; }
        }

        static public void Login()
        {
            var notebookExists = false;
            // log in to Evernote cloud service
            ENSessionAdvanced.SetSharedSessionConsumerKey("endlessborland-5836", "e83cae88abd45ca7", "sandbox.evernote.com");
            if (ENSessionAdvanced.SharedSession.IsAuthenticated == false)
            {
                ENSessionAdvanced.SharedSession.AuthenticateToEvernote();
            }
            _session = ENSessionAdvanced.SharedSession;
            // creating a NoteStore for advanced functionality
            _noteStore = ENSessionAdvanced.SharedSession.PrimaryNoteStore;
            var NotebookList = _noteStore.ListNotebooks();
            foreach (var a in NotebookList)
            {
                if (a.Name == "4EverNote")
                {
                    notebookExists = true;
                    _noteBook = a;
                }
            }
            if (notebookExists == false)
            {
                var notebook = new Notebook();
                notebook.Name = "4EverNote";
                _noteBook = _noteStore.CreateNotebook(notebook);
            }
            NotebookList.Clear();
            NotebookList = null;
        }

        static public void Logout()
        {
            ENSessionAdvanced.SharedSession.Preferences.RemoveAllObjects();
        }
    }
}

