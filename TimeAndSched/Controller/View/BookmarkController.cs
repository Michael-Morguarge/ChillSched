using System;
using System.Collections.Generic;
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
            var activation = DateTime.Parse(bookmark.ActivationDate);
            var activationDate = new Date(activation.Month, activation.Day, activation.Year, activation.DayOfWeek.ToString());
            var deactivation = DateTime.Parse(bookmark.DeactivationDate);
            var deactivationDate = new Date(deactivation.Month, deactivation.Day, deactivation.Year, deactivation.DayOfWeek.ToString());
            var deactivationTime = new Time(bookmark.ActivationTime);
            _bmRepo.AddTime(new Bookmark {
                Title = bookmark.Title,
                Comment = bookmark.Comment,
                ActivationDate = activationDate,
                ActivationTime = deactivationDate,
                DeactivationDate = deactivationDate,
                DeactivationTime = (Time)bookmark[5],
                DateCreated = TimeGlobals.GetCurrDate,
                TimeCreated = TimeGlobals.GetCurrTime
            });
        }
    }
}
