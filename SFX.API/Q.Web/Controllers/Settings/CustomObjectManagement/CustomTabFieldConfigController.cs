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


        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var tabFields = await _customEntityManagementService.GetCustomTabFields(id);
            return Ok(tabFields);
        }


        [HttpPost]
        public async Task<IActionResult> Post([FromBody] CreateFieldRequest createCustomTabFieldRequest)
        {
            var response = await _customEntityManagementService.AddCustomTemplateTabFields(createCustomTabFieldRequest);
            return Ok(response);
        }
    }
}
