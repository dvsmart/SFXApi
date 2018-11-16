using System.Collections.Generic;
using System.Threading.Tasks;
using SFX.Services.Interfaces.Generic;

namespace SFX.Services.Interfaces.Task
{
    public interface ITaskService : IGenericService<Core.Domain.Task.Task>
    {
        Task<IEnumerable<Core.Domain.Task.Task>> GetTasks();

        System.Threading.Tasks.Task AddTask(Core.Domain.Task.Task task);

        System.Threading.Tasks.Task DeleteTask(int id);

        System.Threading.Tasks.Task UpdateTask(int id,Core.Domain.Task.Task task);

        Task<Core.Domain.Task.Task> GetTaskById(int id);

        Task<IEnumerable<Core.Domain.Task.Task>> GetTasksByStatus(string status);

    }
}
