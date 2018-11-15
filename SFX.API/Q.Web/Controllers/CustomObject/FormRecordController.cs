using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SFX.Services.Interfaces.CustomEntity;
using SFX.Web.Models.CustomEntity;

namespace SFX.Web.Controllers.CustomObject
{
    [Route("api/[controller]")]
    [ApiController]
    public class FormRecordController : ControllerBase
    {
        private readonly IFormRecordService _formRecordService;
        public FormRecordController(IFormRecordService formRecordService)
        {
            _formRecordService = formRecordService;
        }
        // GET: api/FormRecord
        [HttpGet]
        public IEnumerable<IActionResult> Get()
        {
            return null;
        }

        [Route("[action]/{templateId}")]
        [HttpGet]
        public async Task<IActionResult> Get(int templateId)
        {
            var record = await _formRecordService.GetByTemplateId(templateId);
            return new OkObjectResult(record);
        }

        // GET: api/FormRecord/5
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var record =  await _formRecordService.Get(id);
            return new OkObjectResult(record);
        }

        // POST: api/FormRecord
        [HttpPost]
        public async Task<IActionResult> Post([FromBody]  CustomEntityInstanceModel customEntityInstanceModel)
        {
            var customInstanceDto = new Domain.CustomEntity.CustomEntityInstance
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
            var response = await _formRecordService.Add(customInstanceDto);
            return Ok(response);
        }

        // PUT: api/FormRecord/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
