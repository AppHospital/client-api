using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppHospital.Api.Controllers
{
    [Route("api/[controller]/[action]")]
    public class AccountController : Controller
    {
        [HttpGet]
        public IActionResult Login(string returnUrl = "/")
        {
            //return Challenge("Microsoft");
            return Challenge(new AuthenticationProperties() { RedirectUri = returnUrl }, "Microsoft");
        }
    }
}
