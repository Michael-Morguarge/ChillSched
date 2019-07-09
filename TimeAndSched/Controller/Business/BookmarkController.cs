using Backend.Implementations;
using Backend.Model;
using Shared.Model;
using Shared.Utility;
using System.Linq;

namespace FrontEnd.Controller
{
    public class BookmarkController
    {
        private EventRepository _bmRepo;

        public BookmarkController()
        {
            _bmRepo = new EventRepository();
        }

        public SavedEvent Bookmark(string id)
        {
            return _bmRepo.GetEvent(id);
        }

        public Events GetBookmarks(Date selectedDate)
        {

        }

        public void Add(EventDetail bookmark)
        {
            var activationDate = bookmark.ActivationDate;
            var activationTime = bookmark.ActivationTime;
            var deactivationDate = bookmark.DeactivationDate;
            var deactivationTime = bookmark.ActivationTime;

            _bmRepo.AddTime(new SavedEvent {
                Title = bookmark.Title,
                Comment = bookmark.Comment,
                ActivationDate = activationDate,
                ActivationTime = activationTime,
                DeactivationDate = deactivationDate,
                DeactivationTime = deactivationTime,
                DateCreated = TimeAndDateUtility.GetCurrentDate(),
                TimeCreated = TimeAndDateUtility.GetCurrentTime()
            });
        }
    }
}
