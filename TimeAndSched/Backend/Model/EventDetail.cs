using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeAndSched.Backend.Model
{
    public class EventDetail
    {
        public EventDetail(string title, string comment, string ad, string at, string dd, string dt)
        {
            Title = title;
            Comment = comment;
            ActivationDate = ad;
            ActivationTime = at;
            DeactivationDate = dd;
            DeactivationTime = dt;
            DateCreated = DateTime.Today.ToString();
        }

        public EventDetail()
        {
            // Empty Constructor
        }

        public string Title { get; private set; }
        public string Comment { get; private set; }
        public string ActivationDate { get; private set; }
        public string ActivationTime { get; private set; }
        public string DeactivationDate { get; private set; }
        public string DeactivationTime { get; private set; }
        public string DateCreated { get; private set; }
    }
}
