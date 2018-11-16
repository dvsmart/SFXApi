using System.Collections.Generic;
using System.Threading.Tasks;
 
using SFX.Core.Domain.Assessment;
using SFX.Services.Interfaces.Assessment;

namespace SFX.Services.Service.Assessment
{
    public class AssessmentScopeService : IAssessmentScopeService
    {
        private readonly IGenericRepository<AssessmentScope> _assessmentScopeRepository;

        public AssessmentScopeService(IGenericRepository<AssessmentScope> assessmentScopeRepository)
        {
            _assessmentScopeRepository = assessmentScopeRepository;
        }

        public async Task<IEnumerable<AssessmentScope>> GetAssessmentScopes()
        {
            return await _assessmentScopeRepository.GetAllAsync();
        }
    }
}
