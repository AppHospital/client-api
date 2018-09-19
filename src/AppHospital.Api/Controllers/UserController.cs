using AppHospital.Account;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace AppHospital.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IAccountStore _accountStore;

        public UserController(IAccountStore accountStore)
        {
            _accountStore = accountStore;
        }

        [HttpGet("{username}")]
        public Task<Account.Models.Account> GetAccount(string username)
        {
            return _accountStore.Find(username);
        }
    }
}