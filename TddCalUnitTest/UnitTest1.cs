using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using tddcalapp.library;

namespace TddCalUnitTest
{
    [TestClass]
    public class TestCalculator
    {
        [TestMethod]
        public void Should_Return_addition_of_two_numbers()
        {
            Calculator testcalculator = new Calculator();
            int num1 = 3;
            int num2 = 2;
            int result;
            result = testcalculator.Add(num1, num2);
            Assert.AreEqual(5, result, "Testing two integers 3 and 2");
        }
    }
}
