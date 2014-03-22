using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Second;

namespace FunctionTest
{
    [TestClass]
    public class FunctionTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.IsTrue(Function.Fibonacci(3) == 2);
        }
    }
}
