using System.Collections.Generic;
using Backend.Model;

namespace Backend.Interface
{
    public interface IBookmarkRepository
    {
        void AddBookmark(Bookmark time);
        List<Bookmark> GetSavedTimes();
        string GetBookmark(string id);
        void SaveBookmarks();
    }
}
