using System.Collections.Generic;
using System.Threading.Tasks;
using SFX.Domain;
using SFX.Domain.Assessment;
using SFX.Services.Interfaces.Assessment;

namespace SFX.Services.Service.Assessment
{
    public class AssessmentTypeService : IAssessmentTypeService
    {
        private readonly IGenericRepository<AssessmentType> _assessmentTypeRepository;

        public AssessmentTypeService(IGenericRepository<AssessmentType> assessmentTypeRepository)
        {
            _assessmentTypeRepository = assessmentTypeRepository;
        }
        public async Task<IEnumerable<AssessmentType>> GetAssessmentTypes()
        {
            return await _assessmentTypeRepository.GetAllAsync();
        }
    }
}
