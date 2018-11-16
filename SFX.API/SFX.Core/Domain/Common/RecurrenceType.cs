using SFX.Core.Interfaces;
using System.Collections.Generic;

namespace SFX.Core.Domain.Common
{
    public class RecurrenceType : BaseEntity
    {
        public string Name { get; set; }
        public short RecurrenceNumber { get; set; }
        public string DatePart { get; set; }

        public bool IsActive { get; set; }

        public virtual ICollection<Assessment.Assessment> Assessments { get; set; }

        public virtual ICollection<Task.Task> Tasks { get; set; }

        public virtual ICollection<Event.Event> Events { get; set; }
    }
}
