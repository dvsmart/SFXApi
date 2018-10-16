using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SFX.Dtos.CustomEntity;
using SFX.Services.Interfaces.Settings.CustomEntityManagement;

namespace SFX.Web.Controllers.Settings.CustomObjectManagement
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomTemplateConfigController : ControllerBase
    {
        private readonly ICustomEntityManagementService _customEntityManagementService;

        public CustomTemplateConfigController(ICustomEntityManagementService customEntityManagementService)
        {
            _customEntityManagementService = customEntityManagementService;
        }

        [HttpGet("{groupId}")]
        public async Task<IActionResult> Get(int groupId)
        {
            var tabs = await _customEntityManagementService.GetCustomTemplates(groupId);
            return Ok(tabs);
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] CreateCustomTemplateRequest createCustomTemplateRequest)
        {
            var response = await _customEntityManagementService.AddCustomTemplate(createCustomTemplateRequest);
            return Ok(response);
        }

    }
}
