namespace AppHospital.Account
{
    public class Group
    {
        public Group() : this("")
        {
        }

        public Group(string name)
        {
            Name = name;
        }

        public static Group Empty => new Group(string.Empty);
        
        public string Name { get; }
    }
}