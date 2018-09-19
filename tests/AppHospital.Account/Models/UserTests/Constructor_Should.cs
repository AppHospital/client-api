using Xunit;
using AppHospital.Account;
using Shouldly;
using System.Linq;

namespace AppHospital.Account.UserTests
{
    public class Constructor_Should
    {
        private readonly string Firstname;
        private readonly Group Group;
        private readonly string Lastname;

        public Constructor_Should()
        {
            Firstname = "Fake Firstname";
            Lastname = "Last Firstname";
            Group = new Group("Fake Group");
        }

        [Fact]
        public void Initialize_Firstname_With_Empty_If_Parameter_Is_Null()
        {
            var target = new User(null, Lastname, Group);

            target.Firstname.ShouldBeEmpty();
        }

        [Fact]
        public void Initialize_Lastname_With_Empty_If_Parameter_Is_Null()
        {
            var target = new User(Firstname, null, Group);

            target.Lastname.ShouldBeEmpty();
        }

        [Fact]
        public void Not_Add_Null_Group_To_List()
        {
            var target = new User(Firstname, Lastname, null);

            target.Groups.ShouldNotBeNull();
            target.Groups.ShouldBeEmpty();
        }

        [Fact]
        public void Initialize_Add_Group_To_List()
        {
            var target = new User(Firstname, Lastname, Group);

            target.Groups.ShouldNotBeNull();
            target.Groups.Single().Name.ShouldBe("Fake Group");
        }
    }
}