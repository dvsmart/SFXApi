using System;
using SFX.Web.Models.Base;

namespace SFX.Web.Models.Task
{
    public class TaskListModel: BaseModel
    {
        public string Name { get; set; }
        public string Description { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime DueDate { get; set; }

        public string Status { get; set; }

        public string Priority { get; set; }
    }
}
