

namespace AppHospital.Account
{/*
    public class CustomSignInMananger<TUser> : SignInManager<TUser> where TUser : class
    {
        public CustomSignInMananger(UserManager<TUser> userManager, IHttpContextAccessor contextAccessor, IUserClaimsPrincipalFactory<TUser> claimsFactory, IOptions<IdentityOptions> optionsAccessor, ILogger<SignInManager<TUser>> logger, IAuthenticationSchemeProvider schemes) 
            : base(userManager, contextAccessor, claimsFactory, optionsAccessor, logger, schemes)
        {
        }

        public override Task<ClaimsPrincipal> CreateUserPrincipalAsync(TUser user)
        {
            return base.CreateUserPrincipalAsync(user);
        }

        public override AuthenticationProperties ConfigureExternalAuthenticationProperties(string provider, string redirectUrl, string userId = null)
        {
            return base.ConfigureExternalAuthenticationProperties(provider, redirectUrl, userId);
        }

        public override Task<SignInResult> ExternalLoginSignInAsync(string loginProvider, string providerKey, bool isPersistent)
        {
            return base.ExternalLoginSignInAsync(loginProvider, providerKey, isPersistent);
        }

        public override Task SignInAsync(TUser user, AuthenticationProperties authenticationProperties, string authenticationMethod = null)
        {
            return base.SignInAsync(user, authenticationProperties, authenticationMethod);
        }

        public override Task SignInAsync(TUser user, bool isPersistent, string authenticationMethod = null)
        {
            return base.SignInAsync(user, isPersistent, authenticationMethod);
        }

        public override Task<bool> CanSignInAsync(TUser user)
        {
            return base.CanSignInAsync(user);
        }

        public override Task<SignInResult> ExternalLoginSignInAsync(string loginProvider, string providerKey, bool isPersistent, bool bypassTwoFactor)
        {
            return base.ExternalLoginSignInAsync(loginProvider, providerKey, isPersistent, bypassTwoFactor);
        }

        public override Task<IEnumerable<AuthenticationScheme>> GetExternalAuthenticationSchemesAsync()
        {
            return base.GetExternalAuthenticationSchemesAsync();
        }

        public override Task<ExternalLoginInfo> GetExternalLoginInfoAsync(string expectedXsrf = null)
        {
            return base.GetExternalLoginInfoAsync(expectedXsrf);
        }

        public override bool IsSignedIn(ClaimsPrincipal principal)
        {
            return base.IsSignedIn(principal);
        }

        public override Task<SignInResult> PasswordSignInAsync(string userName, string password, bool isPersistent, bool lockoutOnFailure)
        {
            return base.PasswordSignInAsync(userName, password, isPersistent, lockoutOnFailure);
        }

        public override Task RefreshSignInAsync(TUser user)
        {
            return base.RefreshSignInAsync(user);
        }

        public override Task<IdentityResult> UpdateExternalAuthenticationTokensAsync(ExternalLoginInfo externalLogin)
        {
            return base.UpdateExternalAuthenticationTokensAsync(externalLogin);
        }

        public override Task<TUser> ValidateSecurityStampAsync(ClaimsPrincipal principal)
        {
            return base.ValidateSecurityStampAsync(principal);
        }

        public override Task<bool> ValidateSecurityStampAsync(TUser user, string securityStamp)
        {
            return base.ValidateSecurityStampAsync(user, securityStamp);
        }
    }*/
}
