using System;

namespace AppHospital.Account.Models
{
    public class Account
    {
        public Account() : this("Toto", "", null) { }

        public Account(string firstname, string lastname, Squad squad = null)
        {
            Firstname = firstname ?? "";
            Lastname = lastname ?? "";
            Squad = squad ?? Squad.Empty;
        }

        public string Firstname { get; set; }
        
        public string Lastname { get; set; }

        public Squad Squad { get; set; }
    }
}
