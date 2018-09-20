using System.Threading.Tasks;

namespace AppHospital.Account
{
    public interface IAccountStore
    {
        Task<User> Find(string id);
    }
}
