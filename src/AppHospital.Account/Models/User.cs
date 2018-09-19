using System;
using System.Collections.Generic;

namespace AppHospital.Account
{
    public class User
    {
        public User() : this("", "") { }

        public User(string firstname, string lastname, Group group = null)
        {
            Firstname = firstname ?? string.Empty;
            Lastname = lastname ?? string.Empty;

            if (group != null)
            {
                Groups.Add(group);
            }
        }

        public string Firstname { get; }

        public string Lastname { get; }

        public ICollection<Group> Groups { get; } = new List<Group>();
    }
}