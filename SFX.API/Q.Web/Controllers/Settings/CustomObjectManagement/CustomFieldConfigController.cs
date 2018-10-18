using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SFX.Dtos.CustomEntity;
using SFX.Services.Interfaces.Settings.CustomEntityManagement;

namespace SFX.Web.Controllers.Settings.CustomObjectManagement
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomFieldConfigController : ControllerBase
    {
        private readonly ICustomEntityManagementService _customEntityManagementService;

        public CustomFieldConfigController(ICustomEntityManagementService customEntityManagementService)
        {
            _customEntityManagementService = customEntityManagementService;
        }

        [HttpGet("{tabId}")]
        public async Task<IActionResult> Get(int tabId)
        {
            var tabFields = await _customEntityManagementService.GetCustomTabFields(tabId);
            return Ok(tabFields);
        }


        [HttpPost]
        public async Task<IActionResult> Post([FromBody] CreateCustomTabFieldRequest createCustomTabFieldRequest)
        {
            var response = await _customEntityManagementService.AddCustomTemplateTabFields(createCustomTabFieldRequest);
            return Ok(response);
        }
    }
}
