using SFX.Core.Domain.Assessment;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SFX.Core.Interfaces.Services.Assessment
{
    public interface IAssessmentScopeService
    {
        Task<IEnumerable<AssessmentScope>> GetAssessmentScopes();

    }
}
