using System.Collections.Generic;
using System.Threading.Tasks;
using SFX.Core.Domain.Assessment;

namespace SFX.Core.Interfaces.ServicesAssessment
{
    public interface IAssessmentTypeService
    {
        Task<IEnumerable<AssessmentType>> GetAssessmentTypes();

    }
}
