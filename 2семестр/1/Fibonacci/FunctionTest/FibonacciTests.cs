using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Second;

namespace FunctionTest
{
    [TestClass]
    public class FibonacciTests
    {
        [TestMethod]
        public void FibonacciTest()
        {
            Assert.IsTrue(FibonacciClass.Fibonacci(3) == 2);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void BadFibonacciTest()
        {
            FibonacciClass.Fibonacci(-1);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void FibonacciZeroTest()
        {
            FibonacciClass.Fibonacci(0);
        }

        [TestMethod]
        public void FibonacciOneTest()
        {
            Assert.AreEqual(1, FibonacciClass.Fibonacci(1));
        }

        [TestMethod]
        public void FibonacciTwoTest()
        {
            Assert.AreEqual(1, FibonacciClass.Fibonacci(2));
        }

    }
}
