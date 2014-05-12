using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using List;

namespace ListTest
{
    [TestClass]
    public class ListTests
    {
        [TestMethod]
        public void SizeTest()
        {
            List<int> list = new List<int>();
            Assert.IsTrue(list.Size() == 0);
        }

        [TestMethod]
        public void AddToHeadTest()
        {
            List<int> list = new List<int>();
            list.AddToHead(10);
            Assert.IsTrue(list.Size() == 1);
        }

        [TestMethod]
        public void ReturnByIndexGoodTest()
        {
            List<int> list = new List<int>();
            list.AddToHead(9);
            Assert.IsTrue(list.ReturnByIndex(0) == 9);
        }

        [TestMethod]
        [ExpectedException(typeof (Exception))]
        public void ReturnByIndexBadTest()
        {
            List<int> list = new List<int>();
            list.ReturnByIndex(10);
        }

        [TestMethod]
        public void AddToEndTest()
        {
            List<int> list = new List<int>();
            list.AddToEnd(5);
            Assert.IsTrue(list.ReturnByIndex(0) == 5);
        }

        [TestMethod]
        public void InsertGoodTest()
        {
            List<int> list = new List<int>();
            list.AddToHead(5);
            list.AddToHead(4);
            list.Insert(1, 6);
            Assert.IsTrue(list.ReturnByIndex(1) == 6);
        }

        [TestMethod]
        [ExpectedException(typeof (Exception))]
        public void InsertBadTest()
        {
            List<int> list = new List<int>();
            list.Insert(1, 5);
        }

        [TestMethod]
        public void DeleteGoodTest()
        {
            List<int> list = new List<int>();
            list.AddToHead(10);
            list.AddToHead(9);
            list.Delete(0);
            Assert.IsTrue(list.ReturnByIndex(0) == 10);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void DeleteBadTest()
        {
            List<int> list = new List<int>();
            list.AddToHead(10);
            list.AddToHead(9);
            list.Delete(4);
        }

        [TestMethod]
        public void ExistTest()
        {
            List<int> list = new List<int>();
            list.AddToHead(10);
            Assert.IsTrue(list.Exist(10) == true);
        }

        [TestMethod]
        public void FindIndexGoodTest()
        {
            List<int> list = new List<int>();
            list.AddToHead(10);
            Assert.IsTrue(list.FindIndex(10) == 0);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void FindIndexBadTest()
        {
            List<int> list = new List<int>();
            list.FindIndex(5);
        }

        [TestMethod]
        public void ClearTest()
        {
            List<int> list = new List<int>();
            list.AddToHead(10);
            list.Clear();
            Assert.IsTrue(list.Size() == 0);
        }

        [TestMethod]
        public void WriteGoodTest()
        {
            List<int> list = new List<int>();
            list.AddToHead(10);
            list.AddToHead(9);
            list.AddToHead(9);
            string test = "9, 9, 10";
            Assert.IsTrue(list.Write() == test);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void WriteBadTest()
        {
            List<int> list = new List<int>();
            list.Write();
        }
    }
}
