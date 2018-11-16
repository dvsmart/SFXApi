using System.Collections.Generic;
using System.Threading.Tasks;

namespace SFX.Core.Interfaces.ServicesTask
{
    public interface ITaskService
    {
        Task<IEnumerable<Core.Domain.Task.Task>> GetTasks();

        System.Threading.Tasks.Task AddTask(Core.Domain.Task.Task task);

        System.Threading.Tasks.Task DeleteTask(int id);

        System.Threading.Tasks.Task UpdateTask(int id,Core.Domain.Task.Task task);

        Task<Core.Domain.Task.Task> GetTaskById(int id);

        Task<IEnumerable<Core.Domain.Task.Task>> GetTasksByStatus(string status);

    }
}
