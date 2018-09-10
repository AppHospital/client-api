using System;

namespace AppHospital.Account.Models
{
    public class Account
    {
        public Account(string firstname, string lastname, Squad squad)
        {
            Firstname = firstname ?? string.Empty;
            Lastname = lastname ?? string.Empty;
            Squad = squad ?? Squad.Empty;
        }

        public string Firstname { get; }
        
        public string Lastname { get; }

        public Squad Squad { get; }
    }
}
