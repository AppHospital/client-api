using Shouldly;
using Xunit;

namespace AppHospital.Account.Models.AccountTests
{
    public class Constructor_Should
    {
        private readonly string Firstname;
        
        private readonly string Lastname;
        
        private readonly Squad Squad;

        public Constructor_Should()
        {
            Firstname = "Fake Firstname";
            Lastname = "Last Firstname";
            Squad = new Squad("Fake Squad");
        }

        [Fact] 
        public void Initialize_Lastname_With_Empty_If_Parameter_Is_Null()
        {
            var target = new Account(Firstname, null, Squad);

            target.Lastname.ShouldBeEmpty();
        }

        [Fact] 
        public void Initialize_Firstname_With_Empty_If_Parameter_Is_Null()
        {
            var target = new Account(null, Lastname, Squad);

            target.Firstname.ShouldBeEmpty();
        }

        [Fact] 
        public void Initialize_Squad_With_Empty_Squad_If_Parameter_Is_Null()
        {
            var target = new Account(Firstname, Lastname, null);

            target.Squad.ShouldNotBeNull();
            target.Squad.Name.ShouldBeEmpty();
        }
    }
}