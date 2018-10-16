using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SFX.Infrastructure.Mappings;
using SFX.Services.Interfaces.Event;
using SFX.Web.Filters;
using SFX.Web.Helpers;
using SFX.Web.Models.Event;

namespace SFX.Web.Controllers.Event
{
    [Authorize]
    [Produces("application/json")]
    [Route("api/Event")]
    [ValidateModel]
    public class EventController : Controller
    {
        private readonly IEventService _eventService;
        private readonly IOutputConverter _outputConverter;

        public EventController(IEventService eventService, IOutputConverter outputConverter)
        {
            _eventService = eventService;
            _outputConverter = outputConverter;
        }


        [HttpGet]
        public async Task<IActionResult> Get(int page,int pageSize)
        {
            var data = await _eventService.GetAll(page,pageSize);
            if (data != null)
            {
                var tasks = data.Results != null ? _outputConverter.Map<List<EventModel>>(data.Results) : null;
                var result = tasks.GetPagedResult(data.PageSize, data.CurrentPage, data.RowCount);
                return new OkObjectResult(result);
            }
            return new BadRequestResult();
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody]EventModel eventModel)
        {
            var eventDto = Mappings.Mapper.MapToEventDto(eventModel);
            var result = await _eventService.Insert(eventDto);
            return new OkObjectResult(result);
        }

        [HttpPut]
        public async Task<IActionResult> Put(int id, [FromBody]EventModel eventModel)
        {
            var eventDto = Mappings.Mapper.MapToEventDto(eventModel);
            var result = await _eventService.Update(eventDto);
            return new OkObjectResult(result);
        }

        [HttpDelete]
        public async Task<IActionResult> Delete(int id)
        {
            await _eventService.Delete(id);
            return Ok();
        }

    }
}
