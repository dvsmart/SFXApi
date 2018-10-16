using System.Threading.Tasks;
using SFX.Domain;
using SFX.Domain.Response;

namespace SFX.Services.Interfaces.User
{
    public interface IUserService
    {
        void Add(Domain.User.User user);

        Domain.User.User Authenticate(string username, string password);

        Task<PagedResult<Domain.User.User>> GetAll(IGridRequest request);

        Task<SaveResponseDto> Update(Domain.User.User entity, string password = null);


        Domain.User.User CheckIfUserExists(int userId);

        Task<Domain.User.User> CreateAsync(Domain.User.User user, string password);
    }
}
