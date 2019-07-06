using Shared.Model;

namespace Backend.Model
{
    public class EventDetail
    {
        public string Id { get; set; }
        public string Title { get; set; }
        public string Comment { get; set; }
        public Date ActivationDate { get; set; }
        public Time ActivationTime { get; set; }
        public Date DeactivationDate { get; set; }
        public Time DeactivationTime { get; set; }
        public Date DateCreated { get; set; }
    }
}
