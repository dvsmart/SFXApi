using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SFX.Infrastructure.Mappings;
using SFX.Services.Interfaces.Assessment;
using SFX.Services.Interfaces.Reference;
using SFX.Web.Models.Assessment;

namespace SFX.Web.Controllers.Assessment
{

    [Authorize]
    [Produces("application/json")]
    [Route("api/Assessment")]
    public class AssessmentReferenceDataController : Controller
    {
        private readonly IAssessmentScopeService _scopeService;
        private readonly IAssessmentStatusService _statusService;
        private readonly IAssessmentTypeService _typeService;
        private readonly IReferenceService _referenceService;

        public AssessmentReferenceDataController(IOutputConverter outputConverter, IAssessmentScopeService scopeService, IAssessmentStatusService statusService, IAssessmentTypeService typeService, IReferenceService referenceService)
        {
            _scopeService = scopeService;
            _statusService = statusService;
            _typeService = typeService;
            _referenceService = referenceService;
        }

        [HttpGet("Scopes")]
        public async Task<IActionResult> GetScopes()
        {
            var res = await _scopeService.GetAssessmentScopes();
            var scopes = res.Select(x => new ScopeModel
            {
                Id = x.Id,
                Name = x.Name
            }).ToList();
            return Ok(scopes);
        }


        [HttpGet("Statuses")]
        public async Task<IActionResult> GetStatuses()
        {
            var res = await _statusService.GetAssessmentStatuses();
            var statuses = res.Select(x => new StatusModel
            {
                Id = x.Id,
                Name = x.Name
            }).ToList();
            return Ok(statuses);
        }

        [HttpGet("Types")]
        public async Task<IActionResult> GetTypes()
        {
            var res = await _typeService.GetAssessmentTypes();
            var types = res.Select(x => new TypeModel
            {
                Id = x.Id,
                Name = x.Name
            }).ToList();
            return Ok(types);
        }

        [HttpGet("Frequencies")]
        public async Task<IActionResult> GetFrequencies()
        {
            var res = await _referenceService.GetFrequencies();
            var types = res.Select(x => new TypeModel
            {
                Id = x.Id,
                Name = x.Name
            }).ToList();
            return Ok(types);
        }


    }
}
