using AppHospital.Account;

namespace AppHospital.Api.Accounts
{
    public class UserGroup
    {
        public string Name { get; set; }

        public static UserGroup From(Group group) => new UserGroup
        {
            Name = group.Name
        };
    }
}