using AppHospital.Account;
using AppHospital.InMemoryStore.Accounts;
using Microsoft.Extensions.DependencyInjection;

namespace AppHospital.InMemoryStore
{
    public static class InMemoryStoreServiceCollectionExtensions
    {
        public static IServiceCollection AddInMemoryStore(this IServiceCollection services)
        {
            return services.AddSingleton<IAccountStore, InMemoryAccountStore>();
        }
    }
}
