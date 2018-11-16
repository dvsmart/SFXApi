using System.Collections.Generic;
using System.Threading.Tasks;
using SFX.Core.Domain.Assessment;

namespace SFX.Services.Interfaces.Assessment
{
    public interface IAssessmentStatusService
    {
        Task<IEnumerable<AssessmentStatus>> GetAssessmentStatuses();

    }
}
