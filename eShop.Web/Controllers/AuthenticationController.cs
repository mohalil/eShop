using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;
using System.Collections.Generic;
using System.Security.Claims;
using System.Threading.Tasks;

namespace eShop.Web.Controllers
{
    public class AuthenticationController : Controller
    {
        [Route("/authenticate")]
        public async Task<IActionResult> Athenticate([FromQuery] string user, [FromQuery] string pwd)
        {
            if(user== "admin" && pwd== "adminadmin")
            {
                var userClaims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name, user),
                    new Claim(ClaimTypes.Email, "mohalil.naikwadi@agilepoint.com"),
                    new Claim(ClaimTypes.HomePhone, "8217595904")
                };

                var userIdentity = new ClaimsIdentity(userClaims, "eShop.CookieAuth");

                var userPrincipal = new ClaimsPrincipal(userIdentity);

                await HttpContext.SignInAsync("eShop.CookieAuth", userPrincipal);


            }
            return Redirect("/outstandingorders");
        }
        [Route("/logout")]
        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync();
            return Redirect("/outstandingorders");
        }
    }
}
