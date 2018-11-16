using System.Collections.Generic;
using System.Threading.Tasks;

namespace SFX.Core.Interfaces.ServicesTask
{
    public interface ITaskStatusService
    {
        Task<IEnumerable<Core.Domain.Task.TaskStatus>> List();
    }
}
