using System.Collections.Generic;
using System.Threading.Tasks;
 
using SFX.Services.Interfaces.Task;

namespace SFX.Services.Service.Task
{
    public class TaskStatusService : ITaskStatusService
    {
        private readonly IGenericRepository<Core.Domain.Task.TaskStatus> _taskStatusRepository;

        public TaskStatusService(IGenericRepository<Core.Domain.Task.TaskStatus> taskStatusRepository)
        {
            _taskStatusRepository = taskStatusRepository;
        }

        public async Task<IEnumerable<Core.Domain.Task.TaskStatus>> List()
        {
            return await _taskStatusRepository.GetAllAsync();
        }
    }
}
