using System;
using System.Collections.Generic;
using System.Security.Claims;
using System.Text;

namespace SFX.Services.Interfaces.Authentication
{
    public interface IJwtTokenHelper
    {
        string EncodeJwt(string issuer, string expires, Dictionary<string, object> data, Claim[] claims);
    }
}
