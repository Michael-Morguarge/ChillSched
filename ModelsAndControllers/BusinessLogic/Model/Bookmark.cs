using System;
using System.Collections.Generic;

namespace Backend.BusinessLogic.Model
{
    public class Bookmark
    {
        public Bookmark()
        {
            Id = Guid.NewGuid().ToString();
        }

        public string Id { get; private set; }
        public string Title { get; set; }
        public string Comment { get; set; }
        public bool Completed { get; set; }
        public Time TimeCreated { get; set; }
        public Date DateCreated { get; set; }
        public Time ActivationTime { get; set; }
        public Time DeactivationTime { get; set; }
        public Date ActivationDate { get; set; }
        public Date DeactivationDate { get; set; }
    }

    public class Bookmarks
    {
        public List<Bookmark> Times { get; private set; }

        public Bookmarks()
        {
            Times = new List<Bookmark>();
        }

        public void AddTime(Bookmark time)
        {
            Times.Add(time);
        }
    }
}
