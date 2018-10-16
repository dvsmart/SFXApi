using System.Collections.Generic;
using System.Threading.Tasks;
using SFX.Services.Interfaces.Generic;

namespace SFX.Services.Interfaces.Task
{
    public interface ITaskService : IGenericService<Domain.Task.Task>
    {
        Task<IEnumerable<Domain.Task.Task>> GetTasks();

        System.Threading.Tasks.Task AddTask(Domain.Task.Task task);

        System.Threading.Tasks.Task DeleteTask(int id);

        System.Threading.Tasks.Task UpdateTask(int id,Domain.Task.Task task);

        Task<Domain.Task.Task> GetTaskById(int id);

        Task<IEnumerable<Domain.Task.Task>> GetTasksByStatus(string status);

    }
}
