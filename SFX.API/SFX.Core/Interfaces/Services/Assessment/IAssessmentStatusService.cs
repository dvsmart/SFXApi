using System.Collections.Generic;
using System.Threading.Tasks;
using SFX.Core.Domain.Assessment;

namespace SFX.Core.Interfaces.ServicesAssessment
{
    public interface IAssessmentStatusService
    {
        Task<IEnumerable<AssessmentStatus>> GetAssessmentStatuses();

    }
}
