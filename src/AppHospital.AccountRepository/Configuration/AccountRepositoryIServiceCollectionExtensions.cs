using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AppHospital.Account.Accounts;
using Microsoft.Extensions.DependencyInjection;

namespace AppHospital.AccountRepository.Configuration
{
    public static class AccountRepositoryIServiceCollectionExtensions
    {
        public static string Title => "AppHospital Api";

        public static string Name => "AppHospital_Api";

        public static IServiceCollection AddAccountRepository(this IServiceCollection servicesCollection)
        {
            servicesCollection.AddSingleton<ISearchAccount, SearchAccountWithList>();
            servicesCollection.AddSingleton<IListUsers, SearchAccountWithList>();

            return servicesCollection;
        }
    }
}
