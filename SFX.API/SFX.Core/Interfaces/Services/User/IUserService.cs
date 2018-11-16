using System.Threading.Tasks;
 
using SFX.Core.Domain.Response;
using SFX.Core.Interfaces;

namespace SFX.Core.Interfaces.ServicesUser
{
    public interface IUserService
    {
        void Add(Core.Domain.User.User user);

        Core.Domain.User.User Authenticate(string username, string password);

        Task<PagedResult<Core.Domain.User.User>> GetAll(IGridRequest request);

        Task<SaveResponseDto> Update(Core.Domain.User.User entity, string password = null);


        Core.Domain.User.User CheckIfUserExists(int userId);

        Task<Core.Domain.User.User> CreateAsync(Core.Domain.User.User user, string password);
    }
}
