using System.Collections.Generic;
using System.Threading.Tasks;
using SFX.Domain.Task;

namespace SFX.Services.Interfaces.Task
{
    public interface ITaskPriorityService
    {
        Task<IEnumerable<TaskPriority>> List();
    }
}