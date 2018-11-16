using System.Collections.Generic;
using System.Threading.Tasks;

namespace SFX.Services.Interfaces.Task
{
    public interface ITaskStatusService
    {
        Task<IEnumerable<Core.Domain.Task.TaskStatus>> List();
    }
}
