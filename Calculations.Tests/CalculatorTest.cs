using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Calculations.Tests
{
    public class CalculatorTest
    {
        [Fact]
        // Bad test method name
        public void TestAdd()
        {
            Assert.True(true);
        }

        [Fact]
        // Good test method name
        public void Add_GivenTwoIntValues_ReturnsInt()
        {
            var calc = new Calculator(); //instance of the class with method to be tested
            var result = calc.Add(1, 2); //execution of method for testing with input values
            Assert.Equal(3, result); //comparing expectation (3) with actual result (result) 
        }

        [Fact]
        public void AddDouble_GivenTwoDoubleValues_ReturnsDouble()
        {
            var calc = new Calculator();
            var result = calc.AddDouble(1.23, 3.55);
            Assert.Equal(4.7, result, 0); // compares exp vs act within "precision" (number of decimal places)
        }

        [Fact]
        public void Add_GivenTwoIntValues_ReturnsSum()
        {
            var calc = new Calculator();
            var result = calc.Add(1, 2);
            Assert.Equal(3, result);
        }

        [Fact]
        public void AddDouble_GivenDoubleIntValues_ReturnsSum()
        {
            var calc = new Calculator();
            var result = calc.AddDouble(1.53, 1.45);
            Assert.Equal(2.9, result, 0);
        }
    }
}
