using Backend.BusinessLogic.Model;
using Backend.OutputLogic.Utility;
using System.Linq;

namespace TimeAndSched.View.Controller
{
    public class BookmarkController
    {
        private Bookmarks _bmRepo;

        public BookmarkController()
        {
            _bmRepo = new Bookmarks();
        }

        public Bookmark Bookmark(string id)
        {
            return _bmRepo.Times.Single(bm => bm.Id == id);
        }

        public void Add(EventDetail bookmark)
        {
            var activationDate = bookmark.ActivationDate;
            var activationTime = bookmark.ActivationTime;
            var deactivationDate = bookmark.DeactivationDate;
            var deactivationTime = bookmark.ActivationTime;

            _bmRepo.AddTime(new Bookmark {
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
