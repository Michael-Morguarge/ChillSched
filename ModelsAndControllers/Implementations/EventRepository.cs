using Backend.Model;
using System.Collections.Generic;
using System.IO;

namespace Backend.Implementations
{
    public class EventRepository
    {
        private Bookmarks _bookmarks;

        public EventRepository()
        {
            _bookmarks = new Bookmarks();
            // Tables needed from database
            // Get rid of Bookmarks
            // Might remove Event Detail Repo
        }

        public void AddEvent(SavedEvent bookmark)
        {
            _bookmarks.AddTime(bookmark);
        }

        public SavedEvent GetEvent(string id)
        {
            SavedEvent theEvent = null;
            foreach (var aEvent in _bookmarks.Times)
            {
                if (aEvent.Id == id)
                    theEvent = aEvent;
            }

            return theEvent;
        }

        public IEnumerable<SavedEvent> GetSavedTimes()
        {
            return _bookmarks.Times.AsReadOnly();
        }

        public void SaveBookmarks()
        {
            foreach (var bookmark in _bookmarks.Times)
            {
                File.WriteAllText(string.Format(@".\Resources\Bookmarks\{0}_{1}.eventsaved", bookmark.Title, bookmark.Id), "");
            }
        }
    }
}
