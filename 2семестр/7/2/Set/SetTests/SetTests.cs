using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Set;

namespace SetTests
{
    [TestClass]
    public class SetTests
    {
        [TestMethod]
        public void AddTest()
        {
            Set<int> set = new Set<int>();
            set.Add(1);
            Assert.IsTrue(set.Size == 1);
        }

        [TestMethod]
        public void ContainTest()
        {
            Set<int> set = new Set<int>();
            set.Add(1);
            Assert.IsTrue(set.Contain(1));
        }

        [TestMethod]
        public void DeleteTest()
        {
            Set<int> set = new Set<int>();
            set.Add(3);
            set.Delete(3);
            Assert.IsFalse(set.Contain(3));
            Assert.IsFalse(set.Delete(3));
        }

        [TestMethod]
        public void Clear()
        {
            Set<int> set = new Set<int>();
            set.Add(3);
            set.Clear();
            Assert.IsTrue(set.Size == 0);
        }

        [TestMethod]
        public void UnionTest()
        {
            Set<int> firstSet = new Set<int>();
            Set<int> secondSet = new Set<int>();
            secondSet.Add(1);
            secondSet.Add(2);
            secondSet.Add(3);
            firstSet.Add(0);
            firstSet.Add(2);
            firstSet.Add(3);
            var result = Set<int>.Union(firstSet, secondSet);
            Assert.IsTrue(result.Contain(0) && result.Contain(1) && result.Contain(2) && result.Contain(3) && result.Size == 4);
        }

        [TestMethod]
        public void IntersectionTest()
        {
            Set<int> firstSet = new Set<int>();
            var secondSet = new Set<int>();
            secondSet.Add(1);
            secondSet.Add(2);
            secondSet.Add(3);
            firstSet.Add(0);
            firstSet.Add(2);
            firstSet.Add(4);
            var result = Set<int>.Intersection(firstSet, secondSet);
            Assert.IsTrue(result.Contain(2) && result.Size == 1);
        }
    }
}
