using System.Collections.Generic;
using System.Threading.Tasks;
using SFX.Core.Domain.Assessment;

namespace SFX.Services.Interfaces.Assessment
{
    public interface IAssessmentTypeService
    {
        Task<IEnumerable<AssessmentType>> GetAssessmentTypes();

    }
}
