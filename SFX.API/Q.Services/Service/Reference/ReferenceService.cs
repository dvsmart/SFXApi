using System.Collections.Generic;
using System.Threading.Tasks;
 
using SFX.Core.Domain.Common;
using SFX.Services.Interfaces.Reference;

namespace SFX.Services.Service.Reference
{
    public class ReferenceService : IReferenceService
    {
        private readonly IGenericRepository<RecurrenceType> _referenceRepository;

        public ReferenceService(IGenericRepository<RecurrenceType> referenceRepository)
        {
            _referenceRepository = referenceRepository;
        }
        public async Task<IEnumerable<RecurrenceType>> GetFrequencies()
        {
            return await _referenceRepository.GetAllAsync();
        }
    }
}
