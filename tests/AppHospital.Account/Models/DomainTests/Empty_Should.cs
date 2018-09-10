using System;
using Xunit;
using AppHospital.Account.Models;
using Shouldly;

namespace AppHospital.Account.Tests.Models.SquadTests
{
    public class Empty_Should
    {
        [Fact]
        public void Return_No_Null_Domain_Object()
        {
            var result = Squad.Empty;

            result.ShouldNotBeNull();
        }

        [Fact]
        public void Return_Empty_String_As_Name()
        {
            var result = Squad.Empty;

            result.Name.ShouldBeEmpty();
        }
    }
}
