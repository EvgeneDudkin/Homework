using System;
using BinaryTree;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BinaryTreeTest
{
    [TestClass]
    public class BinaryTreeTest
    {
        [TestInitialize]
        public void Initialize()
        {
            tree = new BinaryTree<int>();
        }

        [TestMethod]
        public void FindTest()
        {
            Assert.IsFalse(tree.Find(3));
        }

        [TestMethod]
        public void AddTest()
        {
            tree.Add(3);
            Assert.IsTrue(tree.Find(3));
        }

        [TestMethod]
        public void DeleteTest()
        {
            Random rand = new Random();
            tree.Add(10);
            tree.Add(1);
            tree.Add(5);
            tree.Add(4);
            tree.Add(6);
            tree.Add(2);
            tree.Add(3);
            tree.Delete(2);
            Assert.IsFalse(tree.Find(2));
            Assert.IsTrue(tree.Find(3));
        }

        [TestMethod]
        [ExpectedException(typeof(NoFindObjectException))]
        public void NoFindObjectExceptionTest()
        {
            tree.Add(3);
            tree.Delete(5);
        }

        [TestMethod]
        public void IteratorTest()
        {
            tree.Add(1);
            tree.Add(2);
            tree.Add(3);
            tree.Add(4);
            tree.Add(5);
            int result = 0;
            foreach (int value in tree)
            {
                result += value;
            }
            Assert.IsTrue(result == 15);
        }

        private BinaryTree<int> tree;
    }

}
