using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using StackCalculatorNamespace;

namespace StackCalculatorNamespace
{
    [TestClass]
    public class ArrayStackTest
    {
        [TestMethod]
        public void ArraySizeTest()
        {
            ArrayStack stack = new ArrayStack();
            Assert.AreEqual(0, stack.Size());
        }

        [TestMethod]
        public void ArrayPushTest()
        {
            ArrayStack stack = new ArrayStack();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            Assert.IsTrue(stack.Top() == 3);
        }

        [TestMethod]
        public void ArrayTopTest()
        {
            ArrayStack stack = new ArrayStack();
            stack.Push(10);
            Assert.IsTrue(stack.Top() == 10);
        }

        [TestMethod]
        public void ArrayPopTest()
        {
            ArrayStack stack = new ArrayStack();
            stack.Push(10);
            stack.Push(9);
            stack.Pop();
            Assert.IsTrue(stack.Top() == 10);
        }

        [TestMethod]
        public void ArrayClearTest()
        {
            ArrayStack stack = new ArrayStack();
            stack.Push(10);
            stack.Clear();
            Assert.IsTrue(stack.Size() == 0);
        }

        [TestMethod]
        public void ArrayWriteTest()
        {
            ArrayStack stack = new ArrayStack();
            stack.Push(10);
            stack.Push(0);
            stack.Push(100);
            string test = "100 0 10 ";
            Assert.IsTrue(stack.Write() == test);
        }
    }
}
