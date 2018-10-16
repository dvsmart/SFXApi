using System.Collections.Generic;

namespace SFX.Domain.Task
{
    public class TaskPriority : BaseEntity
    {
        public string Name { get; set; }

        public virtual List<Task> Tasks { get; set; }
    }
}