using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using First;

namespace FactorialTest
{
    [TestClass]
    public class FactorialsTest
    {
        [TestMethod]
        public void FactorialTest()
        {
            Assert.IsTrue(Factorials.Factorial(5) == 120);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void BadFactorialTest()
        {
            Factorials.Factorial(-1);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void FactorialZeroTest()
        {
            Factorials.Factorial(0);
        }

    }
}
