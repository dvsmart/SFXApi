using System.Collections.Generic;
using System.Threading.Tasks;
using SFX.Core.Domain.Task;

namespace SFX.Core.Interfaces.ServicesTask
{
    public interface ITaskPriorityService
    {
        Task<IEnumerable<TaskPriority>> List();
    }
}