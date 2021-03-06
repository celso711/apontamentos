﻿using System.Threading.Tasks;
using Microsoft.Owin.Security.OAuth;
using System.DirectoryServices.AccountManagement;
using System.Security.Claims;

namespace TokenAuthAPI.Providers
{
  public class ADAuthorizationServerProvider : OAuthAuthorizationServerProvider
  {
    public override async Task ValidateClientAuthentication(OAuthValidateClientAuthenticationContext context)
    {
      context.Validated();
    }

    public override async Task GrantResourceOwnerCredentials(OAuthGrantResourceOwnerCredentialsContext context)
    {

      context.OwinContext.Response.Headers.Add("Access-Control-Allow-Origin", new[] { "*" });

      using (PrincipalContext pc = new PrincipalContext(ContextType.Domain, "FAB"))
      {
        // validate the credentials
        bool isValid = pc.ValidateCredentials(context.UserName, context.Password);

        if (!isValid)
        {
          context.SetError("invalid_grant", "The user name or password is incorrect.");
          return;
        }
      }

      var identity = new ClaimsIdentity(context.Options.AuthenticationType);
      identity.AddClaim(new Claim(ClaimTypes.Role, "user"));

      context.Validated(identity);
    }
  }
}