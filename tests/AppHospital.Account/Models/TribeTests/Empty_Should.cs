using System;
using Xunit;
using AppHospital.Account.Models;
using Shouldly;

namespace AppHospital.Account.Tests.Models.TribeTests
{
    public class Empty_Should
    {
        [Fact]
        public void Return_No_Null_Domain_Object()
        {
            var result = Tribe.Empty;

            result.ShouldNotBeNull();
        }

        [Fact]
        public void Return_Empty_String_As_Name()
        {
            var result = Tribe.Empty;

            result.Name.ShouldBeEmpty();
        }
    }
}
