using AppHospital.Account;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AppHospital.InMemoryStore.Accounts
{
    internal class InMemoryAccountStore : IAccountStore
    {
        private static readonly Dictionary<string, User> ACCOUNTS = new Dictionary<string, User>
        {
            ["toto"] = new User("toto", "cousin")
        };

        public Task<User> Find(string id)
        {
            return Task.FromResult(ACCOUNTS[id]);
        }
    }
}
