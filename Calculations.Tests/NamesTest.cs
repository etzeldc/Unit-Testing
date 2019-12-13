using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Calculations.Tests
{
    public class NamesTest
    {
        [Fact]
        public void MakeFullNameTest() // MakeFullName_GivenTwoStrings_ReturnsString()
        {
            var names = new Names();
            var result = names.MakeFullName("David", "Etzel");
            Assert.Equal("david Etzel", result, ignoreCase:true); // compares exp vs act with strings of different letter cases
            Assert.Contains("David", result); // checks that act value "contains" exp value
            Assert.Contains("david", result, StringComparison.InvariantCultureIgnoreCase); // checks that act value "contains" exp value w/o regard to casing
            Assert.StartsWith("David E", result); // checks based on starting characters
            Assert.StartsWith("david E", result, StringComparison.InvariantCultureIgnoreCase); // checks based on starting characters w/o regard to casing
            Assert.EndsWith("tzel", result); // checks based on ending characters
            Assert.Matches("[A-Z]{1}[a-z]+ [A-Z]{1}[a-z]+", result); // checks based on regex
        }

        [Fact]
        public void NickName_MustBeNull()
        {
            var names = new Names();
            Assert.Null(names.NickName); // verifies a null value
            names.NickName = "Dave";
            Assert.NotNull(names.NickName); // verifies value is not null
        }

        [Fact]
        public void MakeFullName_AlwaysReturnValue()
        {
            var names = new Names();
            var result = names.MakeFullName("David", "Etzel");
            Assert.NotNull(result); // verifies the result of method is not null
            Assert.True(!string.IsNullOrEmpty(result)); // verifies the result of method is a string that is not null
            Assert.False(string.IsNullOrEmpty(result)); // same as above w/o double negative logic
        }
    }
}
