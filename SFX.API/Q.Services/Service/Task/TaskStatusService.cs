using System.Collections.Generic;
using System.Threading.Tasks;
using SFX.Domain;
using SFX.Services.Interfaces.Task;

namespace SFX.Services.Service.Task
{
    public class TaskStatusService : ITaskStatusService
    {
        private readonly IGenericRepository<Domain.Task.TaskStatus> _taskStatusRepository;

        public TaskStatusService(IGenericRepository<Domain.Task.TaskStatus> taskStatusRepository)
        {
            _taskStatusRepository = taskStatusRepository;
        }

        public async Task<IEnumerable<Domain.Task.TaskStatus>> List()
        {
            return await _taskStatusRepository.GetAllAsync();
        }
    }
}
