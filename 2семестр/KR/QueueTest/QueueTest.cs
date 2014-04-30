using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using KR;

namespace QueueTest
{
    [TestClass]
    public class QueueTest
    {
        [TestInitialize]
        public void Initialize()
        {
            queue = new Queue<int>();
        }

        [TestMethod]
        [ExpectedException(typeof(EmptyQueueException))]
        public void EmptyQueueExceptionTest()
        {
            queue.Dequeue();
        }

        [TestMethod]
        public void EnqueueTest()
        {
            queue.Enqueue(10, 1);
            Assert.IsTrue(10 == queue.Dequeue());
            queue.Enqueue(10, 1);
            queue.Enqueue(11, 2);
            queue.Enqueue(12, 2);
            queue.Enqueue(100, 1);
            Assert.IsTrue(11 == queue.Dequeue());
            Assert.IsTrue(12 == queue.Dequeue());
        }

        private Queue<int> queue;
    }
}
