using System;
using SFX.Domain.Common;

namespace SFX.Domain.Event
{
    public class Event : BaseEntity
    {
        public string Title { get; set; }

        public string Description { get; set; }

        public string Location { get; set; }

        public DateTime? StartDate { get; set; }

        public DateTime? DueDate { get; set; }

        public int? RecurrenceTypeId { get; set; }

        public bool AllDayEvent { get; set; }

        public bool IsCompleted { get; set; }

        public virtual RecurrenceType RecurrenceType { get; set; }
    }
}
