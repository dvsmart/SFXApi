using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using SFX.Infrastructure.Mappings;
using SFX.Services.Interfaces.Authentication;
using SFX.Services.Interfaces.User;
using SFX.Web.Helpers;
using SFX.Web.Models.Request;
using SFX.Web.Models.User;

namespace SFX.Web.Controllers.User
{
    [Produces("application/json")]
    [Route("api/User")]
    public class UserController : Controller
    {
        private readonly IUserService _userService;
        private readonly IOutputConverter _outputConverter;
        private readonly AppSettings _appSettings;
        private readonly IJwtTokenHelper _jwtTokenHelper;

        public UserController(IUserService userService, IJwtTokenHelper jwtTokenHelper, IOutputConverter outputConverter, IOptions<AppSettings> appSettings)
        {
            _userService = userService;
            _outputConverter = outputConverter;
            _appSettings = appSettings.Value;
            _jwtTokenHelper = jwtTokenHelper;
        }

        // GET: api/User
        [HttpGet]
        public async Task<IActionResult> Get([FromHeader]GridRequest request)
        {
            var data = await _userService.GetAll(request);
            if (data == null) return new BadRequestResult();
            var users = data.Results != null ? _outputConverter.Map<List<UserListModel>>(data.Results) : null;
            var result = users.GetPagedResult(data.PageSize, data.CurrentPage, data.RowCount);
            return Ok(result);
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var data = _userService.CheckIfUserExists(id);
            if (data == null) return new BadRequestResult();
            var userModel = new UserListModel
            {
                DisplayName = data.UserProfile.DisplayName,
                FirstName = data.UserProfile.FirstName,
                LastName = data.UserProfile.LastName,
                EmailAddress = data.EmailAddress,
                RoleName = data.UserRole.RoleName,
                UserName = data.UserName,
                Address = data.UserProfile.Address,
                City = data.UserProfile.City
            };
            return Ok(userModel);
        }

        // POST: api/User
        [HttpPost]
        public void Post([FromBody]CreateNewUserRequest newUserRequest)
        {
            if (newUserRequest == null) return;
            var up = new Core.Domain.User.UserProfile
            {
                FirstName = newUserRequest.FirstName,
                LastName = newUserRequest.LastName,
                Address = newUserRequest.Address,
                DateOfBirth = DateTime.Now,
            };
            var user = new Core.Domain.User.User
            {
                EmailAddress = newUserRequest.EmailAddress,
                UserRoleId = newUserRequest.RoleId,
                UserProfile = up
            };
            _userService.Add(user);
        }

        [AllowAnonymous]
        [HttpPost("authenticate")]
        public IActionResult Authenticate([FromBody]LoginModel userDto)
        {
            var user = _userService.Authenticate(userDto.Username, userDto.Password);

            if (user == null)
                return BadRequest(new { message = "Username or password is incorrect" });

            var claims = new[]
                {
                    new Claim(ClaimTypes.Name, user.Id.ToString())
                };
            var expires = DateTime.Now.Add(new TimeSpan(00, 30, 0)).ToString();
            var tokenString = _jwtTokenHelper.EncodeJwt("test.dvsmarttech.co.uk", expires, null, claims);

            return Ok(new
            {
                user.Id,
                Username = user.UserName,
                Token = tokenString,
                Expires = expires
            });
        }

        [AllowAnonymous]
        [HttpPost("register")]
        public async Task<IActionResult> Register([FromBody]RegisterModel userDto)
        {
            // map dto to entity
            var user = new Core.Domain.User.User
            {
                UserName = userDto.Username,
                EmailAddress = userDto.Email,
                UserProfile = new Core.Domain.User.UserProfile
                {
                    FirstName = userDto.FirstName,
                    LastName = userDto.LastName,
                    Address = $"94, Bideford Road, Ruislip",
                    City = "London",
                },
                UserRoleId = 1
            };

            try
            {
                var userInfo = await _userService.CreateAsync(user, userDto.Password);
                return new OkObjectResult(userInfo);
            }
            catch (Exception ex)
            {
                return BadRequest(new { message = ex.Message });
            }
        }
    }
}
