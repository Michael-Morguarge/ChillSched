using System.Collections.Generic;
using System.IO;
using TimeAndSched.Backend.Implementation;
using TimeAndSched.Backend.Model;

namespace TimeAndSched.Backend.Repository
{
    public class BookmarkRepository : IBookmarkRepository
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

        public string GetBookmark(string title, string id)
        {
            return "";
        }

        public IEnumerable<Bookmark> GetSavedTimes()
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
