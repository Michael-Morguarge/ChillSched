using Backend.BusinessLogic.Model;
using System.Collections.Generic;
using System.IO;

namespace Backend.BusinessLogic.Repository
{
    public class BookmarkRepository
    {
        private Bookmarks _times;

        public BookmarkRepository()
        {
            _times = new Bookmarks();
        }

        public void AddBookmark(Bookmark time)
        {
            _times.AddTime(time);
        }

        public Bookmark GetBookmark(string id)
        {
            foreach (var time in _times.Times)
            {
                if (time.Id == id)
                    return time;
            }

            return null;
        }

        public IReadOnlyCollection<Bookmark> GetSavedTimes()
        {
            return _times.Times.AsReadOnly();
        }

        public void SaveBookmarks()
        {
            foreach (var bookmark in _times.Times)
            {
                File.WriteAllText(string.Format(@".\Resources\Bookmarks\{0}_{1}.eventsaved", bookmark.Title, bookmark.Id), "");
            }
        }
    }
}
