using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using AppHospital.Account.Models;
using Microsoft.AspNetCore.Identity;

namespace AppHospital.Account.Stores
{
    public class AppHospitalUserStore : IUserStore
        <Models.Account>
    {
        private readonly Dictionary<string, Models.Account> _users = new Dictionary<string, Models.Account>();

        public Task<IdentityResult> CreateAsync(Models.Account user, CancellationToken cancellationToken)
        {
            _users.Add(user.Firstname, user);

            return Task.FromResult(IdentityResult.Success);
        }

        public Task<IdentityResult> DeleteAsync(Models.Account user, CancellationToken cancellationToken)
        {
            _users.Remove(user.Firstname);

            return Task.FromResult(IdentityResult.Success);
        }

        public void Dispose()
        {
            
        }

        public Task<Models.Account> FindByIdAsync(string userId, CancellationToken cancellationToken)
        {
            return Task.FromResult(_users[userId]);
        }

        public Task<Models.Account> FindByNameAsync(string normalizedUserName, CancellationToken cancellationToken)
        {
            return Task.FromResult(_users[normalizedUserName]);
        }

        public Task<string> GetNormalizedUserNameAsync(Models.Account user, CancellationToken cancellationToken)
        {
            return Task.FromResult(_users[user.Firstname].Lastname);
        }

        public Task<string> GetUserIdAsync(Models.Account user, CancellationToken cancellationToken)
        {
            return Task.FromResult(user.Firstname);
        }

        public Task<string> GetUserNameAsync(Models.Account user, CancellationToken cancellationToken)
        {
            return Task.FromResult(user.Firstname);
        }

        public Task SetNormalizedUserNameAsync(Models.Account user, string normalizedName, CancellationToken cancellationToken)
        {
            return Task.FromResult(user.Firstname);
        }

        public Task SetUserNameAsync(Models.Account user, string userName, CancellationToken cancellationToken)
        {
            _users.Remove(user.Firstname);

            var u = new Models.Account(userName, user.Lastname, user.Squad);
            _users.Add(u.Firstname, u);

            return Task.CompletedTask;
        }

        public Task<IdentityResult> UpdateAsync(Models.Account user, CancellationToken cancellationToken)
        {
            _users[user.Firstname] = user;

            return Task.FromResult(IdentityResult.Success);
        }
    }
}