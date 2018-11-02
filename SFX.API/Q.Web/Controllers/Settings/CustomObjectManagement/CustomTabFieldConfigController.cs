using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SFX.Dtos.CustomEntity;
using SFX.Services.Interfaces.Settings.CustomEntityManagement;

namespace SFX.Web.Controllers.Settings.CustomObjectManagement
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomTabFieldConfigController : ControllerBase
    {
        private readonly ICustomEntityManagementService _customEntityManagementService;

        public CustomTabFieldConfigController(ICustomEntityManagementService customEntityManagementService)
        {
            _customEntityManagementService = customEntityManagementService;
        }

        [HttpGet("{tabId}")]
        public async Task<IActionResult> Get(int tabId)
        {
            var fieldDetail = await _customEntityManagementService.GetCustomTabFields(tabId);
            return Ok(fieldDetail);
        }

        [Route("[action]/{id}")]
        [HttpGet]
        public async Task<IActionResult> GetFieldById(int id)
        {
            var fieldDetail = await _customEntityManagementService.GetCustomFieldDetail(id);
            return Ok(fieldDetail);
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] CreateFieldRequest createCustomTabFieldRequest)
        {
            var response = await _customEntityManagementService.AddCustomTemplateTabFields(createCustomTabFieldRequest);
            return Ok(response);
        }
    }
}
