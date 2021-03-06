﻿using System.Collections.Generic;

namespace SFX.Domain.Task
{
    public class TaskStatus : BaseEntity
    {
        public string Name { get; set; }
       
        public bool? IsActive { get; set; }

        public virtual List<Task> Tasks { get; set; }
    }
}
