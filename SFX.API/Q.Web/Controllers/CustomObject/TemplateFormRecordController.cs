using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SFX.Services.Interfaces.CustomEntity;
using SFX.Web.Helpers;
using SFX.Web.Models.CustomEntity;

namespace SFX.Web.Controllers.CustomObject
{
    //[Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class TemplateFormRecordController : ControllerBase
    {
        private readonly ITemplateFormRecordService _customEntityInstanceService;

        public TemplateFormRecordController(ITemplateFormRecordService customEntityInstanceService)
        {
            _customEntityInstanceService = customEntityInstanceService;
        }

        //GET: api/CustomEntityInstance
        [HttpGet]
        public async Task<IActionResult> GetList(int templateId, int page, int? pageSize)
        {
            var data = await _customEntityInstanceService.GetAll(templateId, page, pageSize);
            if (data != null)
            {
                var cevRecords = data.Results != null ? Mappings.Mapper.MapToCustomEntityValueGridModel(data.Results) : null;
                var result = cevRecords.GetPagedResult(data.PageSize, data.CurrentPage,data.RowCount);
                return new OkObjectResult(result);
            }

            return NoContent();
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Edit(int id)
        {
            var response = await _customEntityInstanceService.GetById(id);
            return Ok(response);
        }

        // POST: api/CustomEntityInstance
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] CustomEntityInstanceModel customEntityInstanceModel)
        {
            var customInstanceDto = new Core.Domain.CustomEntity.CustomEntityInstance
            {
                Id = customEntityInstanceModel.Id,
                CustomEntityId = customEntityInstanceModel.CustomEntityId,
                AddedDate = DateTime.Now,
                AddedBy = 1,
                Status = 1,
                DueDate = DateTime.Now.AddDays(2),
                IsDeleted = false,
                IsArchived = false
            };
            var response = await _customEntityInstanceService.Add(customInstanceDto);
            return Ok(response);
        }
     

        [HttpDelete]
        public async Task<IActionResult> Delete(int id)
        {
            return Ok(await _customEntityInstanceService.Delete(id));
        }
    }
}
