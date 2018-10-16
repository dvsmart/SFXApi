using System.Collections.Generic;
using System.Threading.Tasks;
using SFX.Domain.Assessment;

namespace SFX.Services.Interfaces.Assessment
{
    public interface IAssessmentStatusService
    {
        Task<IEnumerable<AssessmentStatus>> GetAssessmentStatuses();

    }
}
