using System.Collections.Generic;
using System.Threading.Tasks;
using SFX.Core.Domain.CustomEntity;

namespace SFX.Core.Interfaces.ServicesCustomEntity
{
    public interface IFormControlTypeService
    {
        Task<ICollection<CustomFieldType>> GetCustomFieldTypes();
    }
}
