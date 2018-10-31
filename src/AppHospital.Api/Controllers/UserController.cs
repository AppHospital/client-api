using AppHospital.Account;
using AppHospital.Api.Accounts;
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
        public async Task<UserAccount> GetAccountAsync(string username)
        {
            return UserAccount.From(await _accountStore.Find(username));
        }
    }
}