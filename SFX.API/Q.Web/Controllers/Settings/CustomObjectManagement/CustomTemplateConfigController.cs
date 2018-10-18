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

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var templatelist = await _customEntityManagementService.GetCustomTemplates();
            return Ok(templatelist);
        }

        //[HttpGet("{groupId}")]
        //public async Task<IActionResult> Get(int groupId)
        //{
        //    var tabs = await _customEntityManagementService.GetCustomTemplates(groupId);
        //    return Ok(tabs);
        //}

        [HttpGet("{id}")]
        public async Task<IActionResult> GetTemplateDetail(int id)
        {
            var tabs = await _customEntityManagementService.GetTemplateDetail(id);
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
