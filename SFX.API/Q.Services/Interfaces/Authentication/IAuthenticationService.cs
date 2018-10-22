using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Text;

namespace SFX.Services.Interfaces.Authentication
{

    public interface IAuthenticationService
    {
        RsaSecurityKey GetRsaPrivateKey();

        RsaSecurityKey GetRsaPublicKey();
    }
}
