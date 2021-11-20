using Microsoft.AspNetCore.Authentication;
using Microsoft.Extensions.Options;
using server.Models;
using server.Services;
using System;
using System.Net.Http.Headers;
using System.Security.Claims;
using System.Text;
using System.Text.Encodings.Web;
using System.Threading.Tasks;

namespace server.Handlers
{
  public class BasicAuthenticationHandler : AuthenticationHandler<AuthenticationSchemeOptions>
  {
    private readonly IUserService _userDBService;

    public BasicAuthenticationHandler(
           IOptionsMonitor<AuthenticationSchemeOptions> options,
           ILoggerFactory logger,
           UrlEncoder encoder,
           ISystemClock clock,
           IUserService userService)
           : base(options, logger, encoder, clock)
    {
      _userDBService = userService;
    }
    protected override async Task<AuthenticateResult> HandleAuthenticateAsync()
    {


      //string encodeString = Convert.ToBase64String(byteArray);

      if (!Request.Headers.ContainsKey("Authorization"))
        return AuthenticateResult.Fail("Authorization header was not found");
       
      try
      { 

        var credentialBytes = System.Convert.FromBase64String(Request.Headers["Authorization"]); 
 
        var credentials = Encoding.UTF8.GetString(credentialBytes).Split(new[] { ':' }, 2);
        var username = credentials[0];
        var password = credentials[1];

        var user = _userDBService.Authenticate(username, password);

        if (user == null)
        {
          return AuthenticateResult.Fail("Invalid username or password");
        }
        else
        {
          var claims = new[] { new Claim(ClaimTypes.Name, username) };
          var identity = new ClaimsIdentity(claims, Scheme.Name);
          var principle = new ClaimsPrincipal(identity);
          var ticket = new AuthenticationTicket(principle, Scheme.Name);

          return AuthenticateResult.Success(ticket);
        }

      }
      catch (Exception)
      {
        return AuthenticateResult.Fail("Error has occured");
      }
       return AuthenticateResult.Fail("");
    }
  }
}
