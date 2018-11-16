using Microsoft.IdentityModel.Tokens;
using SFX.Core.Interfaces.ServicesAuthentication;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace SFX.Services.Authentication
{
    public class JwtTokenHelper : IJwtTokenHelper
    {
        private readonly IAuthenticationService _authenticationService;
        public JwtTokenHelper(IAuthenticationService authenticationService)
        {
            _authenticationService = authenticationService;
        }
        public string EncodeJwt(string issuer, string expires, Dictionary<string, object> data, Claim[] claims)
        {
            var jwtSecurityTokenHandler = new JwtSecurityTokenHandler();
            RsaSecurityKey privateKey = _authenticationService.GetRsaPrivateKey();

            var header = new JwtHeader(new SigningCredentials(privateKey, SecurityAlgorithms.RsaSha256));

            var payload = new JwtPayload(claims)
            {
                { "nbf", GetUnixTime(DateTime.UtcNow).ToString()},
                { "exp",expires},
                { "iss",issuer}
            };

            var jwt = new JwtSecurityToken(header, payload);
            return jwtSecurityTokenHandler.WriteToken(jwt);
        }

        private static long GetUnixTime(DateTime value)
        {
            TimeSpan span = (value - new DateTime(1970, 1, 1, 0, 0, 0, 0));
            return (long)span.TotalSeconds;
        }
    }
}
