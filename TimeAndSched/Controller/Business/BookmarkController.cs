using Backend.Implementations;
using Backend.Model;
using Shared.Model;
using Shared.Utility;
using System.Linq;

namespace FrontEnd.Controller
{
    public class EventController
    {
        private EventRepository _eventRepo;

        public EventController()
        {
            _eventRepo = new EventRepository();
        }

        public SavedEvent Get(string id)
        {
            return _eventRepo.GetEvent(id);
        }

        public Events GetAll(Date selectedDate)
        {
            return null;
        }

        public void Add(SavedEvent bookmark)
        {
            bookmark.DateCreated = TimeAndDateUtility.GetCurrentDate();
            bookmark.TimeCreated = TimeAndDateUtility.GetCurrentTime();

            _eventRepo.AddEvent(bookmark);
        }

        public void Update(string id)
        {

        }

        public void Delete(string id)
        {

        }
    }
}
