using System.Collections.Generic;
using System.Threading.Tasks;
using SFX.Domain.Common;

namespace SFX.Services.Interfaces.Reference
{
    public interface IReferenceService
    {
        Task<IEnumerable<RecurrenceType>> GetFrequencies();
    }
}
