using System.Collections.Generic;
using System.Threading.Tasks;
using SFX.Domain.CustomEntity;

namespace SFX.Services.Interfaces.CustomEntity
{
    public interface IFormControlTypeService
    {
        Task<ICollection<CustomFieldType>> GetCustomFieldTypes();
    }
}
