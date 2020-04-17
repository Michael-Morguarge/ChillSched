using Backend.DataAccess;
using Backend.Database.Access;
using Backend.Model;
using System.Collections.Generic;
using System.IO;
using BackEnd.Inferfaces;

namespace Backend.Implementations
{
    public class EventRepository : IEventRepository
    {
        private Events _events;
        private readonly AccessDatabase _dataAccess;

        public EventRepository()
        {
            _events = new Events();
            var dbInitialize = new DataLayer();
            dbInitialize.SetDb();

            _dataAccess = dbInitialize.Database;

            // Tables needed from database (Find a way to use model objects to format data)
            // Get rid of Bookmarks
            // Might remove Event Detail Repo
        }

        public void AddEvent(SavedEvent bookmark)
        {
            _events.AddTime(bookmark);
        }

        public SavedEvent GetEvent(string id)
        {
            SavedEvent theEvent = null;
            //var events = _dataAccess.GetDataFromTable("Some query");

            foreach (var aEvent in _events.Times)
            {
                if (aEvent.Id == id)
                    theEvent = aEvent;
            }

            return theEvent;
        }

        public IEnumerable<SavedEvent> GetSavedTimes()
        {
            return _events.Times.AsReadOnly();
        }

        public void SaveBookmarks()
        {
            foreach (var bookmark in _events.Times)
            {
                File.WriteAllText(string.Format(@".\Resources\Bookmarks\{0}_{1}.eventsaved", bookmark.Title, bookmark.Id), "");
            }
        }
    }
}
