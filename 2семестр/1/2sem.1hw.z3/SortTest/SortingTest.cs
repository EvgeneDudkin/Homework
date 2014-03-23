using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Third;

namespace SortTest
{
    [TestClass]
    public class SortingTest
    {
        [TestMethod]
        public void bubbleSorting()
        {
            int[] array = new int[] { 1, 10, 14 };
            Sorting.BubbleSort(array);
            Assert.IsTrue(array[0] == 14 && array[1] == 10 && array[2] == 1);
        }
    }
}
