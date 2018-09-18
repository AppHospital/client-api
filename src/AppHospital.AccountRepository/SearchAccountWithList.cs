using System;
using AppHospital.Account.Accounts;
using AppHospital.Account;
using Polly;
using Polly.CircuitBreaker;
using Microsoft.Extensions.Logging;
using System.Threading.Tasks;
using System.Threading;
using Newtonsoft.Json;
using System.IO;
using System.Text;
using System.Collections.Generic;
using System.Linq;

namespace AppHospital.AccountRepository
{
    public class SearchAccountWithList : ISearchAccount, IListUsers
    {
        private static Dictionary<Guid, User> _users = new Dictionary<Guid, User>()
        {
            [Guid.NewGuid()] = new User("Marco", "Polo", new Group("La route de la soie")),
            [Guid.NewGuid()] = new User("Arne", "Saknussemm", new Group("Le centre de la Terre"))
        };

        private static CircuitBreakerPolicy _breaker;
        private readonly ILogger<SearchAccountWithList> _logger;

        public SearchAccountWithList(ILogger<SearchAccountWithList> logger)
        {
            System.Console.WriteLine(_users.Keys.FirstOrDefault().ToString());

            _breaker = _breaker ?? Policy
                .Handle<Exception>()
                .AdvancedCircuitBreaker(
                    failureThreshold: 0.5d,
                    samplingDuration: TimeSpan.FromHours(1),
                    minimumThroughput: 10,
                    durationOfBreak: TimeSpan.FromSeconds(10),
                    onBreak: (__, _) => _logger.LogError("break"),
                    onReset: () => _logger.LogWarning("reset")
                );
            this._logger = logger;
        }
        public User ByIdentifier(Guid identifier)
        {
            if (CircuitBreakerNotClosed())
            {
                return User.Empty;
            }

            var captured = _breaker.ExecuteAndCapture<User>(() =>
            {
                if (_users.TryGetValue(identifier, out User account))
                {
                    return account;
                }

                return null;
            });

            return captured.Result ?? User.Empty;

        }

        private static bool CircuitBreakerNotClosed() => _breaker.CircuitState == CircuitState.Open || _breaker.CircuitState == CircuitState.Isolated;

        public IEnumerable<UserWithId> ListAllUsers() => _users.Select(
            (user) =>
            {
                var userWithId = (UserWithId)(user.Value);
                userWithId.Id = user.Key;
                return userWithId;
            });
    }
}