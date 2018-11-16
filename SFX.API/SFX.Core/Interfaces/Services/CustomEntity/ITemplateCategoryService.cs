using System.Collections.Generic;
using SFX.Core.Domain.CustomEntity;
using SFX.Core.Domain.Response;

namespace SFX.Core.Interfaces.ServicesCustomEntity
{
    public interface ITemplateCategoryService
    {
        System.Threading.Tasks.Task<IEnumerable<CustomEntityGroup>> GetGroups();

        System.Threading.Tasks.Task<SaveResponseDto> AddGroup(CustomEntityGroup customEntityGroup);

        System.Threading.Tasks.Task<SaveResponseDto> UpdateGroup(CustomEntityGroup customEntityGroup);

        System.Threading.Tasks.Task<SaveResponseDto> DeleteGroup(int id);

        System.Threading.Tasks.Task<CustomEntityGroup> GetGroupById(int id);
    }
}
