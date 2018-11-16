using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Tokens;
using SFX.Core.Interfaces.ServicesAuthentication;
using SFX.Services.Interfaces.Authentication;
using SFX.Services.Interfaces.User;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Threading.Tasks;

namespace SFX.Web.Helpers
{
    public static class AuthenticationServiceCollectionExtensions
    {
        public static IServiceCollection AddJwtAuthentication(this IServiceCollection serviceCollection, IConfiguration configuration)
        {
            IAuthenticationService authenticationService = serviceCollection.BuildServiceProvider().GetService<IAuthenticationService>();
            RsaSecurityKey key = authenticationService.GetRsaPublicKey();

            var authenticationAudience = Environment.GetEnvironmentVariable("AuthenticationAudience");
            if (configuration.GetSection("Authentication").Exists() && configuration.GetSection("Authentication").GetSection("AuthenticationAudience").Exists())
            {
                authenticationAudience = configuration.GetSection("Authentication").GetSection("AuthenticationAudience").Value;
            }

            serviceCollection.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
                .AddJwtBearer(options =>
                {
                    options.Events = new JwtBearerEvents
                    {
                        OnTokenValidated = context =>
                        {
                            var userService = context.HttpContext.RequestServices.GetRequiredService<IUserService>();
                            var userId = int.Parse(context.Principal.Identity.Name);
                            var user = userService.CheckIfUserExists(userId);
                            if (user == null)
                            {
                                // return unauthorized if user no longer exists
                                context.Fail("Unauthorized");
                            }
                            return Task.CompletedTask;
                        }
                    };
                    options.RequireHttpsMetadata = false;
                    options.SaveToken = true;
                    options.TokenValidationParameters =
                        new TokenValidationParameters
                        {
                            ValidateIssuer = true,
                            ValidateAudience = false,
                            ValidateLifetime = false,
                            ValidateIssuerSigningKey = true,
                            ValidIssuer = "test.dvsmarttech.co.uk",
                            IssuerSigningKey = key
                        };
                });

            return serviceCollection;
        }
    }
}
