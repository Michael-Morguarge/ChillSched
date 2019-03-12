using System.Collections.Generic;
using TimeAndSched.Backend.Model;

namespace TimeAndSched.Backend.Implementation
{
    public interface IBookmarkRepository
    {
        void AddBookmark(Bookmark time);
        IEnumerable<Bookmark> GetSavedTimes();
        string GetBookmark(string title, string id);
        void SaveBookmarks();
    }
}
