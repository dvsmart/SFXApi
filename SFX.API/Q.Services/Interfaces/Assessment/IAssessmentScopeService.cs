using SFX.Core.Domain.Assessment;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SFX.Services.Interfaces.Assessment
{
    public interface IAssessmentScopeService
    {
        Task<IEnumerable<AssessmentScope>> GetAssessmentScopes();

    }
}
