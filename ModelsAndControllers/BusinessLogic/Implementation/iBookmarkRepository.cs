using System.Collections.Generic;
using Backend.BusinessLogic.Model;

namespace Backend.BusinessLogic.Implementation
{
    public interface iBookmarkRepository
    {
        void AddBookmark(Bookmark time);
        IReadOnlyCollection<Bookmark> GetSavedTimes();
        string GetBookmark(string id);
        void SaveBookmarks();
    }
}
