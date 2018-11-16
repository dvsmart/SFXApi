using System;
using System.Collections.Generic;
using SFX.Core.Domain.Common;

namespace SFX.Core.Domain.Task
{
    public class Task : BaseEntity
    {
        public string DataId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime DueDate { get; set; }

        public int TaskStatusId { get; set; }

        public int TaskPriorityId { get; set; }

        public int RecurrenceTypeId { get; set; }

        public int? CompletedBy { get; set; }

        public virtual TaskStatus TaskStatus { get; set; }

        public virtual TaskPriority TaskPriority { get; set; }

        public virtual ICollection<TaskComment> TaskComments { get; set; }

        public virtual RecurrenceType RecurrenceType { get; set; }

    }
}
