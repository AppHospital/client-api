using AppHospital.Account;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AppHospital.InMemoryStore.Accounts
{
    internal class InMemoryAccountStore : IAccountStore
    {
        private static readonly Dictionary<string, Account.Models.Account> ACCOUNTS = new Dictionary<string, Account.Models.Account>
        {
            ["toto"] = new Account.Models.Account("toto", "cousin")
        };

        public Task<Account.Models.Account> Find(string id)
        {
            return Task.FromResult(ACCOUNTS[id]);
        }
    }
}
