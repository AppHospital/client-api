namespace AppHospital.Account.Models
{
    public class Domain
    {
        public Domain(string name) => Name = name;

        public string Name { get; }

        public static Domain Empty => new Domain(string.Empty);
    }
}