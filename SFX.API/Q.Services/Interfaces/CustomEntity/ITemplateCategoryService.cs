using System.Collections.Generic;
using SFX.Domain.CustomEntity;
using SFX.Domain.Response;

namespace SFX.Services.Interfaces.CustomEntity
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
