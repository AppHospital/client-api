using System;
using AppHospital.Account;

namespace AppHospital.AccountRepository
{
    public class UserWithId : User
    {
        public UserWithId(string firstname, string lastname, Group group = null)
            : base(firstname, lastname, group)
        {

        }

        public Guid Id { get; set; }
    }
}