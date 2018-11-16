using System;
using System.Linq;
using System.Threading.Tasks;
 
using SFX.Core.Domain.Response;
using SFX.Core.Interfaces;
using SFX.Core.Interfaces.Repositories;
using SFX.Core.Interfaces.ServicesUser;
using SFX.Services.Interfaces.User;

namespace SFX.Services.User
{
    public class UserService : IUserService
    {
        private readonly IGenericRepository<Core.Domain.User.User> _userRepository;
        private readonly IGenericRepository<Core.Domain.User.UserRole> _userRoleRepository;

        public UserService(IGenericRepository<Core.Domain.User.User> userRepository ,IGenericRepository<Core.Domain.User.UserRole> userRoleRepository)
        {
            _userRepository = userRepository;
            _userRoleRepository = userRoleRepository;
        }

        public async void Add(Core.Domain.User.User user)
        {
            await _userRepository.AddAsync(user);
        }


        public async Task<PagedResult<Core.Domain.User.User>> GetAll(IGridRequest request)
        {
            return await _userRepository.GetPagedList(request.Page.Value, request.PageSize.Value);
        }

        public async Task<SaveResponseDto> Update(Core.Domain.User.User entity,string password = null)
        {
            var user = await _userRepository.FindAsync(x => x.Id == entity.Id);

            if (user == null)
                throw new Exception("User not found");

            if (entity.UserName != user.UserName)
            {
                // username has changed so check if the new username is already taken
                if (await _userRepository.FindByAsync(x => x.UserName == entity.UserName) != null)
                    throw new Exception("Username " + entity.UserName + " is already taken");
            }

            // update user properties
            user.UserProfile.FirstName = entity.UserProfile.FirstName;
            user.UserProfile.LastName = entity.UserProfile.LastName;
            user.UserName = entity.UserName;
            user.EmailAddress = entity.EmailAddress;

            // update password if it was entered
            if (!string.IsNullOrWhiteSpace(password))
            {
                CreatePasswordHash(password, out var passwordHash, out var passwordSalt);

                user.PasswordHash = passwordHash;
                user.PasswordSalt = passwordSalt;
            }

            var response = await _userRepository.UpdateAsync(user,user.Id);
            return new SaveResponseDto
            {
                SavedEntityId = user.Id,
                SaveSuccessful = response != null
            };
        }

        public Core.Domain.User.User Authenticate(string username, string password)
        {
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
                return null;

            var user = _userRepository.FindBy(x => x.UserName == username || x.EmailAddress == username).FirstOrDefault();

            // check if username exists
            if (user == null)
                return null;

            // check if password is correct
            if (!VerifyPasswordHash(password, user.PasswordHash, user.PasswordSalt))
                return null;

            // authentication successful
            return user;
        }

        public async Task<Core.Domain.User.User> CreateAsync(Core.Domain.User.User user, string password)
        {
            // validation
            if (string.IsNullOrWhiteSpace(password))
                throw new Exception("Password is required");

            var userAlreadyExists = await _userRepository.FindAsync(x => x.UserName == user.UserName || x.EmailAddress == user.EmailAddress);


            if (await _userRepository.FindAsync(x => x.UserName == user.UserName || x.EmailAddress == user.EmailAddress) != null)
            {
                throw new Exception("Username \"" + user.UserName + "\" is already taken");
            }

            CreatePasswordHash(password, out var passwordHash, out var passwordSalt);

            user.PasswordHash = passwordHash;
            user.PasswordSalt = passwordSalt;
            await _userRepository.AddAsync(user);

            return user;
        }

        public Core.Domain.User.User CheckIfUserExists(int userId)
        {
            return _userRepository.FindBy(x => x.Id == userId).FirstOrDefault();
        }

        private static void CreatePasswordHash(string password, out byte[] passwordHash, out byte[] passwordSalt)
        {
            if (password == null) throw new ArgumentNullException(nameof(password));
            if (string.IsNullOrWhiteSpace(password)) throw new ArgumentException("Value cannot be empty or whitespace only string.", nameof(password));

            using (var hmac = new System.Security.Cryptography.HMACSHA512())
            {
                passwordSalt = hmac.Key;
                passwordHash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));
            }
        }

        private static bool VerifyPasswordHash(string password, byte[] storedHash, byte[] storedSalt)
        {
            if (password == null) throw new ArgumentNullException(nameof(password));
            if (string.IsNullOrWhiteSpace(password)) throw new ArgumentException("Value cannot be empty or whitespace only string.", nameof(password));
            if (storedHash.Length != 64) throw new ArgumentException("Invalid length of password hash (64 bytes expected).",
                $"passwordHash");
            if (storedSalt.Length != 128) throw new ArgumentException("Invalid length of password salt (128 bytes expected).",
                $"passwordHash");

            using (var hmac = new System.Security.Cryptography.HMACSHA512(storedSalt))
            {
                var computedHash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));
                for (int i = 0; i < computedHash.Length; i++)
                {
                    if (computedHash[i] != storedHash[i]) return false;
                }
            }

            return true;
        }



       
    }
}
