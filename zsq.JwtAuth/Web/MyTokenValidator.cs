using System.Security.Claims;
using Microsoft.IdentityModel.Tokens;
using Microsoft.AspNetCore.Authentication.JwtBearer;

namespace zsq.JwtAuth
{
    public class MyTokenValidator : ISecurityTokenValidator
    {
        //这里可以对token做一些验证，比如string.isNullOrEmpty
        public bool CanValidateToken => true;

        public int MaximumTokenSizeInBytes { get; set; }

        public bool CanReadToken(string securityToken)
        {
            return true;
        }

        public ClaimsPrincipal ValidateToken(string securityToken, TokenValidationParameters validationParameters, out SecurityToken validatedToken)
        {
            validatedToken = null;
            var identity = new ClaimsIdentity(JwtBearerDefaults.AuthenticationScheme);

            if (securityToken == "123456")
            {
                identity.AddClaim(new Claim("name", "sanchez"));
                identity.AddClaim(new Claim(ClaimsIdentity.DefaultRoleClaimType, "admin"));
            }
            var principal = new ClaimsPrincipal(identity);

            return principal;
        }
    }
}