using Microsoft.VisualStudio.TestTools.UnitTesting;
using JAMK.IT;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAMK.IT.Tests
{
    [TestClass()]
    public class CalculatorTests
    {
        [TestMethod()]
        public void AddTest()
        {
            Calculator calc = new Calculator();
            // arrange
            int number1 = 5;
            int number2 = 7;
            int expected = 12;
            // act
            int actual = calc.Add(number1, number2);
            // assert 
            Assert.AreEqual(actual,expected);
        }

        [TestMethod()]
        public void MultiplyTest()
        {
            Calculator calc = new Calculator();
            // arrange
            int n1 = 5;
            int n2 = 7;
            int expected = 35;

            // act
            int actual = calc.Multiply(n1, n2);

            // assert
            Assert.AreEqual(expected,actual);
        }
    }
}