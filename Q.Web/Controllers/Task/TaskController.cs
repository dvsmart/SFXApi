using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SFX.Infrastructure.Mappings;
using SFX.Services.Interfaces.Task;
using SFX.Web.Filters;
using SFX.Web.Helpers;
using SFX.Web.Models.Task;

namespace SFX.Web.Controllers.Task
{

    [Authorize]
    [Produces("application/json")]
    [Route("api/Task")]
    [ValidateModel]
    public class TaskController : Controller
    {
        private readonly ITaskService _taskService;
        private readonly IOutputConverter _outputConverter;

        public TaskController(ITaskService taskService, IOutputConverter outputConverter)
        {
            _taskService = taskService;
            _outputConverter = outputConverter;
        }

        // GET: api/Task
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var tasks = await _taskService.GetTasks();
            return new OkObjectResult(_outputConverter.Map<List<TaskListModel>>(tasks));
        }

        [HttpGet]
        [Route("TaskForGrid")]
        public async Task<IActionResult> GetTasks(int page, int pageSize)
        {
            var data = await _taskService.GetAll(page, pageSize);
            if (data != null)
            {
                var tasks = data.Results != null ? _outputConverter.Map<List<TaskListModel>>(data.Results) : null;
                var result = tasks.GetPagedResult(data.PageSize, data.CurrentPage, data.RowCount);
                return new OkObjectResult(result);
            }
            return new BadRequestResult();
        }

        [HttpGet]
        [Route("TasksByStatus")]
        public IActionResult GetByFilter(string statusFilter)
        {
            var tasks = _taskService.GetTasksByStatus(statusFilter);
            return new OkObjectResult(_outputConverter.Map<List<TaskListModel>>(tasks));
        }

        // GET: api/Task/5
        [HttpGet("{id}", Name = "GetTask")]
        public async Task<IActionResult> Get(int id)
        {
            var task = await _taskService.GetTaskById(id);
            return new OkObjectResult(_outputConverter.Map<TaskListModel>(task));
        }

        // POST: api/Task
        [HttpPost]
        public async Task<IActionResult> Post([FromBody]TaskModel taskModel)
        {
            taskModel.CreatedBy = 1;
            var task = _outputConverter.Map<Domain.Task.Task>(taskModel);
            await _taskService.AddTask(task);
            return Ok();
        }

        // PUT: api/Task/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, [FromBody]TaskModel taskModel)
        {
            var task = _outputConverter.Map<Domain.Task.Task>(taskModel);
            await _taskService.UpdateTask(id, task);
            return Ok();
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _taskService.DeleteTask(id);
            return Ok();
        }
    }
}
