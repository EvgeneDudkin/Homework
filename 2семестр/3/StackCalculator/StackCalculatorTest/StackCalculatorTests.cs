using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using StackCalculatorNamespace;

namespace StackCalculatorNamespace
{
    [TestClass]
    public class StackCalculatorTests
    {
        [TestMethod]
        public void SimpleAddTest()
        {
            IStack stack = new ArrayStack();
            StackCalculator calculator = new StackCalculator(stack);
            calculator.Push(1);
            calculator.Push(2);
            calculator.Add();
            Assert.AreEqual(3, calculator.Result());
        }

        [TestMethod]
        public void SimpleDeductTest()
        {
            IStack stack = new ArrayStack();
            StackCalculator calculator = new StackCalculator(stack);
            calculator.Push(10);
            calculator.Push(2);
            calculator.Deduct();
            Assert.AreEqual(8, calculator.Result());
        }

        [TestMethod]
        public void SimpleIncreaseTest()
        {
            IStack stack = new ArrayStack();
            StackCalculator calculator = new StackCalculator(stack);
            calculator.Push(10);
            calculator.Push(2);
            calculator.Increase();
            Assert.AreEqual(20, calculator.Result());
        }

        [TestMethod]
        public void SimpleDivisionTest()
        {
            IStack stack = new Stack();
            StackCalculator calculator = new StackCalculator(stack);
            calculator.Push(10);
            calculator.Push(2);
            calculator.Division();
            Assert.AreEqual(5, calculator.Result());
        }

        [TestMethod]
        [ExpectedException(typeof (Exception))]
        public void DivisionBadTest()
        {
            IStack stack = new Stack();
            StackCalculator calculator = new StackCalculator(stack);
            calculator.Push(10);
            calculator.Push(0);
            calculator.Division();
        }

        [TestMethod]
        public void StrongTest()
        {
            IStack stack = new Stack();
            StackCalculator calculator = new StackCalculator(stack);
            calculator.Push(7);
            calculator.Push(8);
            calculator.Add();
            calculator.Push(13);
            calculator.Deduct();
            calculator.Push(2);
            calculator.Division();
            Assert.AreEqual(1, calculator.Result());
        }
    }
}
