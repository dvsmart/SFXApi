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

        private readonly ICustomTemplateService _customTemplateService;

        public CustomTemplateConfigController(ICustomEntityManagementService customEntityManagementService,ICustomTemplateService customTemplateService)
        {
            _customEntityManagementService = customEntityManagementService;
            _customTemplateService = customTemplateService;
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
        public async Task<IActionResult> Get(int id)
        {
            var templateModel = await _customTemplateService.GetTemplateDetail(id);
            return new OkObjectResult(templateModel);
        }


        [HttpPost]
        public async Task<IActionResult> Post([FromBody] CreateCustomTemplateRequest createCustomTemplateRequest)
        {
            var response = await _customTemplateService.CreateTemplate(createCustomTemplateRequest);
            return Ok(response);
        }

        [HttpPut]
        public async Task<IActionResult> Put([FromBody] CreateCustomTemplateRequest createCustomTemplateRequest)
        {
            var response = await _customTemplateService.UpdateTemplate(createCustomTemplateRequest);
            return Ok(response);
        }

    }
}
