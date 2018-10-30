using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SFX.Dtos.CustomEntity;
using SFX.Services.Interfaces.Settings.CustomEntityManagement;

namespace SFX.Web.Controllers.Settings.CustomObjectManagement
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomTemplateFieldConfigController : ControllerBase
    {
        private readonly ICustomEntityManagementService _customEntityManagementService;

        public CustomTemplateFieldConfigController(ICustomEntityManagementService customEntityManagementService)
        {
            _customEntityManagementService = customEntityManagementService;
        }

        // GET: api/CustomTemplateFieldConfig/5
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var fields = await _customEntityManagementService.GetCustomFields(id);
            return new OkObjectResult(fields);
        }

        // POST: api/CustomTemplateFieldConfig
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] CreateFieldRequest createFieldRequest)
        {
            var response = await _customEntityManagementService.AddCustomTemplateTabFields(createFieldRequest);
            return Ok(response);
        }
      
    }
}
