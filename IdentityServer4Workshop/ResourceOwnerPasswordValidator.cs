using IdentityServer4.Validation;
using System.Threading.Tasks;
using static IdentityModel.OidcConstants;

namespace IdentityServer4Workshop
{
    /// <summary>
    /// Custom Identity Server password validator
    /// </summary>
    public class ResourceOwnerPasswordValidator : IResourceOwnerPasswordValidator
    {
        /// <summary>
        /// Authenticate the user
        /// </summary>
        /// <param name="context">Describes the user details</param>
        public async Task ValidateAsync(ResourceOwnerPasswordValidationContext context)
        {
            context.Result = new GrantValidationResult(context.UserName, AuthenticationMethods.Password);
        }
    }
}
