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
    }
}
