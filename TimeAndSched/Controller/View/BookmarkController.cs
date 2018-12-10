using System.Linq;
using TimeAndSched.Backend.Globals;
using TimeAndSched.Backend.Model;

namespace TimeAndSched.Controller.View
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
            var activationDate = new Date(bookmark.ActivationDate);
            var activationTime = new Time(bookmark.ActivationTime);
            var deactivationDate = new Date(bookmark.DeactivationDate);
            var deactivationTime = new Time(bookmark.ActivationTime);
            _bmRepo.AddTime(new Bookmark {
                Title = bookmark.Title,
                Comment = bookmark.Comment,
                ActivationDate = activationDate,
                ActivationTime = activationTime,
                DeactivationDate = deactivationDate,
                DeactivationTime = deactivationTime,
                DateCreated = TimeGlobals.GetCurrDate,
                TimeCreated = TimeGlobals.GetCurrTime
            });
        }
    }
}
