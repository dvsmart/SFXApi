using System.Collections.Generic;
using System.Threading.Tasks;
using SFX.Core.Domain.Common;

namespace SFX.Core.Interfaces.ServicesReference
{
    public interface IReferenceService
    {
        Task<IEnumerable<RecurrenceType>> GetFrequencies();
    }
}
