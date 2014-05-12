using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Stack;

namespace StackTest
{
    [TestClass]
    public class StackTest
    {
        [TestMethod]
        public void SizeTest()
        {
            Stack<int> stack = new Stack<int>();
            Assert.IsTrue(stack.Size() == 0);
        }

        [TestMethod]
        public void PushTest()
        {
            Stack<int> stack = new Stack<int>();
            stack.Push(1);
            Assert.IsTrue(stack.Size() == 1);
        }

        [TestMethod]
        public void Top()
        {
            Stack<int> stack = new Stack<int>();
            stack.Push(10);
            Assert.IsTrue(stack.Top() == 10);
        }

        [TestMethod]
        public void PopGoodTest()
        {
            Stack<int> stack = new Stack<int>();
            stack.Push(10);
            stack.Push(9);
            stack.Pop();
            Assert.IsTrue(stack.Top() == 10);
        }

        [TestMethod]
        [ExpectedException(typeof (Exception))]
        public void PopBadTest()
        {
            Stack<int> stack = new Stack<int>();
            stack.Pop();
        }

        [TestMethod]
        public void Clear()
        {
            Stack<int> stack = new Stack<int>();
            stack.Push(10);
            stack.Clear();
            Assert.IsTrue(stack.Size() == 0);
        }

        [TestMethod]
        public void Write()
        {
            Stack<int> stack = new Stack<int>();
            stack.Push(10);
            stack.Push(0);
            stack.Push(100);
            string test = "100 0 10 ";
            Assert.IsTrue(stack.Write() == test);
        }
    }
}
