using Shared.Model;
using System;
using System.Collections.Generic;

namespace Backend.Model
{
    public class SavedEvent
    {
        public SavedEvent()
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
        public List<SavedEvent> Times { get; private set; }

        public Bookmarks()
        {
            Times = new List<SavedEvent>();
        }

        public void AddTime(SavedEvent time)
        {
            Times.Add(time);
        }
    }
}
