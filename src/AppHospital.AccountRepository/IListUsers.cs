using System.Collections.Generic;
using AppHospital.Account;

namespace AppHospital.AccountRepository
{
    public interface IListUsers
    {
         IEnumerable<UserWithId> ListAllUsers();
    }
}