using System;
using System.Security.Cryptography;
using System.Text;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
namespace SFX.Services.Authentication
{
    public sealed class AuthenticationService
    {
        private readonly IConfiguration _configuration;
        private static SecretManagerRsaSecret _secretManagerRsaSecret;

        public AuthenticationService(IConfiguration configuration)
        {
            _configuration = configuration;
            _secretManagerRsaSecret = new SecretManagerRsaSecret();
            LoadSecretsFromAppSettings();
        }

        public RsaSecurityKey GetRsaPublicKey()
        {

            var publicAndPrivate = new RSACryptoServiceProvider();
            publicAndPrivate.ImportParameters(GetRsaParameters());
            RsaSecurityKey key = new RsaSecurityKey(publicAndPrivate.ExportParameters(false));

            return key;
        }


        public RsaSecurityKey GetRsaPrivateKey()
        {

            var publicAndPrivate = new RSACryptoServiceProvider();
            publicAndPrivate.ImportParameters(GetRsaParameters());
            RsaSecurityKey key = new RsaSecurityKey(publicAndPrivate.ExportParameters(true));

            return key;
        }

        private RSAParameters GetRsaParameters()
        {

            return new RSAParameters
            {
                Modulus = _secretManagerRsaSecret.Modulus != null ? Convert.FromBase64String(_secretManagerRsaSecret.Modulus) : null,
                Exponent = _secretManagerRsaSecret.Exponent != null ? Convert.FromBase64String(_secretManagerRsaSecret.Exponent) : null,
                P = _secretManagerRsaSecret.P != null ? Convert.FromBase64String(_secretManagerRsaSecret.P) : null,
                Q = _secretManagerRsaSecret.Q != null ? Convert.FromBase64String(_secretManagerRsaSecret.Q) : null,
                DP = _secretManagerRsaSecret.DP != null ? Convert.FromBase64String(_secretManagerRsaSecret.DP) : null,
                DQ = _secretManagerRsaSecret.DQ != null ? Convert.FromBase64String(_secretManagerRsaSecret.DQ) : null,
                InverseQ = _secretManagerRsaSecret.InverseQ != null ? Convert.FromBase64String(_secretManagerRsaSecret.InverseQ) : null,
                D = _secretManagerRsaSecret.D != null ? Convert.FromBase64String(_secretManagerRsaSecret.D) : null
            };
        }
        private class SecretManagerRsaSecret
        {
            public string Modulus { get; set; }
            public string Exponent { get; set; }
            public string P { get; set; }
            public string Q { get; set; }
            public string DP { get; set; }
            public string DQ { get; set; }
            public string InverseQ { get; set; }
            public string D { get; set; }
        }
        private void LoadSecretsFromAppSettings()
        {
            if (_configuration == null)
                throw new ApplicationException("configuratio must be supplied");

            if (!_configuration.GetSection("secrets").Exists())
                return;

            var secretSection = _configuration.GetSection("secrets");
            if (secretSection == null)
                return;

            if (secretSection.GetSection("rsa").Exists())
            {
                _secretManagerRsaSecret = new SecretManagerRsaSecret()
                {
                    D = secretSection.GetSection("rsa")["D"],
                    DP = secretSection.GetSection("rsa")["DP"],
                    DQ = secretSection.GetSection("rsa")["DQ"],
                    Exponent = secretSection.GetSection("rsa")["Exponent"],
                    InverseQ = secretSection.GetSection("rsa")["InverseQ"],
                    Modulus = secretSection.GetSection("rsa")["Modulus"],
                    P = secretSection.GetSection("rsa")["P"],
                    Q = secretSection.GetSection("rsa")["Q"]
                };
            }
        }
    }
}
