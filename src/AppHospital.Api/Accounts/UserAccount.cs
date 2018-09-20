using System.Collections.Generic;
using AppHospital.Account;
using System.Linq;

namespace AppHospital.Api.Accounts
{
    public class UserAccount
    {
        public string Firstname { get; set; }

        public string Lastname { get; set; }

        public ICollection<UserGroup> Groups { get; set; } 
        public static UserAccount From(User user) => new UserAccount
        {
            Firstname = user.Firstname,
            Lastname = user.Lastname,
            Groups = user.Groups.Select(UserGroup.From).ToList()
        };
    }
}