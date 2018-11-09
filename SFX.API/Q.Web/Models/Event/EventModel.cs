using System;
using SFX.Web.Models.Base;

namespace SFX.Web.Models.Event
{
    public class EventModel : BaseModel
    {
        public string Title { get; set; }

        public string Description { get; set; }

        public string Location { get; set; }

        public DateTime? Start { get; set; }

        public DateTime? End { get; set; }

        public int? RecurrenceTypeId { get; set; }

        public bool AllDayEvent { get; set; }

        public bool IsCompleted { get; set; }

        public string RecurrenceType { get; set; }
    }
}
