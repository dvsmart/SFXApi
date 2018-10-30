using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SFX.Services.Interfaces.CustomEntity;
using SFX.Web.Models.CustomEntity;

namespace SFX.Web.Controllers.Settings.CustomObjectManagement
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomFieldTypeConfigController : ControllerBase
    {
        private readonly IFormControlTypeService _formControlTypeService;

        public CustomFieldTypeConfigController(IFormControlTypeService formControlTypeService)
        {
            _formControlTypeService = formControlTypeService;
        }

        // GET: api/FormControlsType
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var fieldTypes =  await _formControlTypeService.GetCustomFieldTypes();
            var fieldTypeList = new List<CustomFieldTypeModel>();
            var response = fieldTypes?.Select(x => new CustomFieldTypeModel
            {
                Id = x.Id,
                Caption = x.Caption
            }).ToList();

            return Ok(response);
        }
       
    }
}
