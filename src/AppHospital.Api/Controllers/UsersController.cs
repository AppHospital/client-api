using System;
using AppHospital.AccountRepository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace AppHospital.Api.Controllers {
    [ApiController]
    [Route ("api/users")]
    public class UsersController : Controller {
        private readonly ILogger<UsersController> _logger;
        private readonly IListUsers _listUsers;

        public UsersController (ILogger<UsersController> logger, IListUsers listUsers) {
            _listUsers = listUsers;
            _logger = logger;
        }

        [HttpGet]
        public IActionResult GetAll ()
        {
            return Ok(_listUsers.ListAllUsers());
        }

        [HttpGet ("{id}")]
        public IActionResult GetUserById (string id) {
            _logger.LogInformation ($"Get user by id <{id}>");
            return Ok ();
        }
    }
}