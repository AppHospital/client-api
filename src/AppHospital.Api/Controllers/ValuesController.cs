using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace AppHospital.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private readonly ILogger<ValuesController> _logger;

        private readonly SignInManager<Account.Models.Account> _signInManager;

        public ValuesController(ILogger<ValuesController> logger, SignInManager<Account.Models.Account> signInManager)
        {
            _logger = logger;
            _signInManager = signInManager;
        }
        // GET api/values
        [HttpGet]
        [Authorize(AuthenticationSchemes = "Microsoft")]
        public ActionResult<IEnumerable<string>> Get()
        {
            _logger.LogError("test log");

            return new string[] { "value1", "value2", User.Identity.Name };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
