using System;

namespace AppHospital.Account.Models
{
    public class Squad
    {
        public Squad(string name) : this (name, null) { }
        
        public Squad(string name, Tribe tribe)
        {
            Name = name;
            Tribe = tribe ?? Tribe.Empty;
        }
        
        public string Name { get; }

        public Tribe Tribe { get; }

        public static Squad Empty => new Squad(string.Empty);
    }
}