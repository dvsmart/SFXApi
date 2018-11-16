using SFX.Core.Interfaces;
using System.Collections.Generic;

namespace SFX.Core.Domain.Task
{
    public class TaskPriority : BaseEntity
    {
        public string Name { get; set; }

        public virtual List<Task> Tasks { get; set; }
    }
}