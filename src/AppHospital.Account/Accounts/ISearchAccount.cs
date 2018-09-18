using System;

namespace AppHospital.Account.Accounts
{
    public interface ISearchAccount
    {
         User ByIdentifier(Guid identifier);
    }
}