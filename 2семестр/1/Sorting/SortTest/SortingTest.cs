using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Third;

namespace SortTest
{
    [TestClass]
    public class SortingTest
    {
        [TestMethod]
        public void BubbleSortingGoodTest()
        {
            int[] array = new int[] { 1, 10, 14 };
            Sorting.BubbleSort(array);
            Assert.IsTrue(array[0] == 14 && array[1] == 10 && array[2] == 1);
        }

        [TestMethod]
        public void BubbleSortingEqualElemntsTest()
        {
            int[] array = new int[] { 1, 1, 1 };
            Sorting.BubbleSort(array);
            Assert.IsTrue(array[0] == 1 && array[1] == 1 && array[2] == 1);
        }

        [TestMethod]
        public void BubbleSortingEmptyArrayTest()
        {
            int[] array = new int[] {};
            Sorting.BubbleSort(array);
            Assert.IsTrue(array.Length == 0);
        }
    }
}
