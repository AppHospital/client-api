using System;

namespace AppHospital.Account.Groups
{
    public interface ISearchGroup
    {
        Group ByIdentifier(Guid identifier);
    }
}