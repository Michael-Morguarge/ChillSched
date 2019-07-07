using System.Collections.Generic;
using Backend.Model;

namespace Backend.Interface
{
    public interface IBookmarkRepository
    {
        void AddBookmark(SavedEvent time);
        List<SavedEvent> GetSavedTimes();
        string GetBookmark(string id);
        void SaveBookmarks();
    }
}
