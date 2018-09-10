namespace AppHospital.Account.Models
{
    public class Tribe
    {
        public Tribe(string name) : this (name, null)
        {
        }
        
        public Tribe(string name, Domain domain)
        {
            Name = name;
            Domain = domain ?? Domain.Empty;
        }

        public string Name { get; }
        public Domain Domain { get; }

        public static Tribe Empty => new Tribe(string.Empty);
    }
}