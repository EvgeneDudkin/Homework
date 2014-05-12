using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using StackCalculatorNamespace;

namespace StackTest
{
    [TestClass]
    public class StackTest
    {
        [TestMethod]
        public void SizeTest()
        {
            Stack stack = new Stack();
            Assert.IsTrue(stack.Size() == 0);
        }

        [TestMethod]
        public void PushTest()
        {
            Stack stack = new Stack();
            stack.Push(1);
            Assert.IsTrue(stack.Size() == 1);
        }

        [TestMethod]
        public void TopTest()
        {
            Stack stack = new Stack();
            stack.Push(10);
            Assert.IsTrue(stack.Top() == 10);
        }

        [TestMethod]
        public void PopGoodTest()
        {
            Stack stack = new Stack();
            stack.Push(10);
            stack.Push(9);
            stack.Pop();
            Assert.IsTrue(stack.Top() == 10);
        }

        [TestMethod]
        [ExpectedException(typeof (Exception))]
        public void PopBadTest()
        {
            Stack stack = new Stack();
            stack.Pop();
        }

        [TestMethod]
        public void ClearTest()
        {
            Stack stack = new Stack();
            stack.Push(10);
            stack.Clear();
            Assert.IsTrue(stack.Size() == 0);
        }

        [TestMethod]
        public void WriteTest()
        {
            Stack stack = new Stack();
            stack.Push(10);
            stack.Push(0);
            stack.Push(100);
            string test = "100 0 10 ";
            Assert.IsTrue(stack.Write() == test);
        }
    }
}
