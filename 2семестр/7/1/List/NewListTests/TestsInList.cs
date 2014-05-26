using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NewList;

namespace NewList
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void SizeTest()
        {
            MyList<int> list = new MyList<int>();
            Assert.IsTrue(list.Size() == 0);
        }

        [TestMethod]
        public void AddToHeadTest()
        {
            MyList<int> list = new MyList<int>();
            list.AddToHead(10);
            Assert.IsTrue(list.Size() == 1);
        }

        [TestMethod]
        public void ReturnByIndexGoodTest()
        {
            MyList<int> list = new MyList<int>();
            list.AddToHead(9);
            Assert.IsTrue(list.ReturnByIndex(0) == 9);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void ReturnByIndexBadTest()
        {
            MyList<int> list = new MyList<int>();
            list.ReturnByIndex(10);
        }

        [TestMethod]
        public void AddToEndTest()
        {
            MyList<int> list = new MyList<int>();
            list.AddToEnd(5);
            Assert.IsTrue(list.ReturnByIndex(0) == 5);
        }

        [TestMethod]
        public void InsertGoodTest()
        {
            MyList<int> list = new MyList<int>();
            list.AddToHead(5);
            list.AddToHead(4);
            list.Insert(1, 6);
            Assert.IsTrue(list.ReturnByIndex(1) == 6);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void InsertBadTest()
        {
            MyList<int> list = new MyList<int>();
            list.Insert(1, 5);
        }

        [TestMethod]
        public void DeleteGoodTest()
        {
            MyList<int> list = new MyList<int>();
            list.AddToHead(10);
            list.AddToHead(9);
            list.Delete(0);
            Assert.IsTrue(list.ReturnByIndex(0) == 10);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void DeleteBadTest()
        {
            MyList<int> list = new MyList<int>();
            list.AddToHead(10);
            list.AddToHead(9);
            list.Delete(4);
        }

        [TestMethod]
        public void ExistTest()
        {
            MyList<int> list = new MyList<int>();
            list.AddToHead(10);
            Assert.IsTrue(list.Exist(10) == true);
        }

        [TestMethod]
        public void FindIndexGoodTest()
        {
            MyList<int> list = new MyList<int>();
            list.AddToHead(10);
            Assert.IsTrue(list.FindIndex(10) == 0);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void FindIndexBadTest()
        {
            MyList<int> list = new MyList<int>();
            list.FindIndex(5);
        }

        [TestMethod]
        public void ClearTest()
        {
            MyList<int> list = new MyList<int>();
            list.AddToHead(10);
            list.Clear();
            Assert.IsTrue(list.Size() == 0);
        }

        [TestMethod]
        public void WriteGoodTest()
        {
            MyList<int> list = new MyList<int>();
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
            MyList<int> list = new MyList<int>();
            list.Write();
        }

        [TestMethod]
        public void ForeachTest()
        {
            MyList<int> list = new MyList<int>();
            int test = 0;
            list.AddToEnd(2);
            list.AddToEnd(1);
            foreach (var x in list)
            {
                test = test + x;
            }
            Assert.IsTrue(test == 3);
        }
    }
}
