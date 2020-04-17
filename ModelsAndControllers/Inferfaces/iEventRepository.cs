using Backend.Model;
using System.Collections.Generic;

namespace BackEnd.Inferfaces
{
    public interface IEventRepository
    {
        void AddEvent(SavedEvent anEvent);

        SavedEvent GetEvent(string id);

        IEnumerable<SavedEvent> GetSavedTimes();

        void SaveBookmarks();
    }
}
