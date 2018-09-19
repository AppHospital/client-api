using System;
using Xunit;
using AppHospital.Account;
using Shouldly;

namespace AppHospital.Account.GroupTests
{
    public class Empty_Should
    {
        [Fact]
        public void Return_Empty_String_As_Name()
        {
            var result = Group.Empty;

            result.Name.ShouldBeEmpty();
        }

        [Fact]
        public void Return_No_Null_Group_Object()
        {
            var result = Group.Empty;

            result.ShouldNotBeNull();
        }
    }
}