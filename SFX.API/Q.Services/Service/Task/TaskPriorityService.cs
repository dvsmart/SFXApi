using System.Collections.Generic;
using System.Threading.Tasks;
 
using SFX.Services.Interfaces.Task;

namespace SFX.Services.Service.Task
{
    public class TaskPriorityService : ITaskPriorityService
    {
        private readonly IGenericRepository<Core.Domain.Task.TaskPriority> _taskPriorityRepository;

        public TaskPriorityService(IGenericRepository<Core.Domain.Task.TaskPriority> taskPriorityRepository)
        {
            _taskPriorityRepository = taskPriorityRepository;
        }

        public async Task<IEnumerable<Core.Domain.Task.TaskPriority>> List()
        {
            return await _taskPriorityRepository.GetAllAsync();
        }
    }
}
