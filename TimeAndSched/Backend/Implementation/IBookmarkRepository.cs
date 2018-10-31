using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TimeAndSched.Backend.Model;

namespace TimeAndSched.Backend.Implementation
{
    public interface IBookmarkRepository
    {
        void AddBookmark(Bookmark time);
        IReadOnlyCollection<Bookmark> GetSavedTimes();
        string GetBookmark(string title, string id);
        void SaveBookmarks();
    }
}
