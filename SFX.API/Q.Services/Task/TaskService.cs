using System;
using System.Collections.Generic;
using System.Threading.Tasks;

using SFX.Core.Domain.Response;
using SFX.Core.Interfaces;
using SFX.Core.Interfaces.Repositories;
using SFX.Core.Interfaces.ServicesGeneric;
using SFX.Core.Interfaces.ServicesTask;
using SFX.Services.Interfaces.Generic;
using SFX.Services.Interfaces.Task;
using SFX.Services.Service.DataIdGenerator;

namespace SFX.Services.Task
{
    public class TaskService : ITaskService
    {
        private readonly IGenericRepository<Core.Domain.Task.Task> _taskRepository;

        public TaskService(IGenericRepository<Core.Domain.Task.Task> taskRepository)
        {
            _taskRepository = taskRepository;
        }

        public async System.Threading.Tasks.Task AddTask(Core.Domain.Task.Task task)
        {
            task.DataId = DataIdGenerationService.GenerateDataId(_taskRepository.GetLast().Id, "TA");
            await _taskRepository.AddAsync(task);
        }

        public async System.Threading.Tasks.Task DeleteTask(int id)
        {
            await _taskRepository.DeleteAsync(await _taskRepository.FindAsync(x => x.Id == id));
        }

        public async Task<Core.Domain.Task.Task> GetTaskById(int id)
        {
            return await _taskRepository.FindAsync(x => x.Id == id);
        }

        public async Task<IEnumerable<Core.Domain.Task.Task>> GetTasks()
        {
            var tasks = await _taskRepository.GetAllAsync();
            return tasks;
        }

        public async Task<IEnumerable<Core.Domain.Task.Task>> GetTasksByStatus(string status)
        {
            return await _taskRepository.FindAllAsync(x => x.TaskStatus.Name.Equals(status));
        }

        public async System.Threading.Tasks.Task UpdateTask(int id, Core.Domain.Task.Task task)
        {
            var taskDto = await _taskRepository.FindAsync(x => x.Id == id);
            if (taskDto != null)
            {
                taskDto.Description = task.Description;
                taskDto.TaskStatusId = task.TaskStatusId;
                taskDto.TaskPriorityId = task.TaskPriorityId;
                taskDto.Name = task.Name;
                taskDto.ModifiedDate = DateTime.Now;
                taskDto.StartDate = task.StartDate;
                taskDto.DueDate = task.DueDate;
            }
            await _taskRepository.UpdateAsync(taskDto, task.Id);
        }

        public async Task<PagedResult<Core.Domain.Task.Task>> GetAll(int page, int? pageSize)
        {
            return await _taskRepository.GetPagedList(page, pageSize);
        }

        public System.Threading.Tasks.Task DeleteAll(List<int> ids)
        {
            throw new NotImplementedException();
        }

        public System.Threading.Tasks.Task Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Task<SaveResponseDto> Insert(Core.Domain.Task.Task entity)
        {
            throw new NotImplementedException();
        }

        public async Task<SaveResponseDto> Update(Core.Domain.Task.Task entity)
        {
            var response = await _taskRepository.UpdateAsync(entity, entity.Id);
            return new SaveResponseDto
            {
                SaveSuccessful = response != null,
                SavedEntityId = entity.Id
            };
        }

        public async Task<Core.Domain.Task.Task> GetById(int id)
        {
            return await _taskRepository.FindAsync(x => x.Id == id);
        }

        Task<PagedResult<Core.Domain.Task.Task>> IGenericService<Core.Domain.Task.Task>.GetAll(int page, int? pageSize)
        {
            throw new NotImplementedException();
        }
    }
}
