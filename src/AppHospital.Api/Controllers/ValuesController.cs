using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AppHospital.Account;
using AppHospital.Account.Accounts;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace AppHospital.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private readonly ISearchAccount _accounts;

        private readonly ILogger<ValuesController> _logger;

        public ValuesController(ILogger<ValuesController> logger, ISearchAccount accounts)
        {
            _logger = logger;
            _accounts = accounts;
        }

        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            _logger.LogError("test log");
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<User> Get(string id)
        {
            var res = _accounts.ByIdentifier(Guid.Empty);
            return res;
        }
    }
}
