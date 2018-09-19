using System.Threading.Tasks;

namespace AppHospital.Account
{
    public interface IAccountStore
    {
        Task<Account.Models.Account> Find(string id);
    }
}
