using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SFX.Services.Interfaces.CustomEntity;

namespace SFX.Web.Controllers.CustomObject
{
    [Route("api/[controller]")]
    [ApiController]
    public class NewTemplateFormRecordController : ControllerBase
    {
        private readonly ITemplateService _customEntityService;

        public NewTemplateFormRecordController(ITemplateService customEntityService)
        {
            _customEntityService = customEntityService;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetTemplateDefinition(int id)
        {
            var response = await _customEntityService.GetTemplateByIdAsync(id);
            return Ok(response);
        }
    }
}