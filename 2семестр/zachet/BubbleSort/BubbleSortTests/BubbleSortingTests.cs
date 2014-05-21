using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BubbleSort;

namespace BubbleSort
{
    [TestClass]
    public class BubbleSortingTests
    {
        [TestMethod]
        public void IntArrayTest()
        {
            int[] array = new int[]{1,2,4};
            IntDescendingComparator intComparator = new IntDescendingComparator();
            BubbleSort.BubbleSorting<int>(array, 3, intComparator);
            Assert.IsTrue(array[0] == 4 && array[1] == 2 && array[2] == 1);
        }

        [TestMethod]
        public void StringArrayTest()
        {
            string[] array = new string[] { "toa", "rrra", "fdaswf"};
            StringComparator stringComparator = new StringComparator();
            BubbleSort.BubbleSorting<string>(array, 3, stringComparator);
            Assert.IsTrue(array[0] == "fdaswf" && array[1] == "rrra" && array[2] == "toa");
        }

        [TestMethod]
        public void IntArrayAscendingTest()
        {
            int[] array = new int[] { 4, 2, 1 };
            IntAscendingComparator intComparator = new IntAscendingComparator();
            BubbleSort.BubbleSorting<int>(array, 3, intComparator);
            Assert.IsTrue(array[0] == 1 && array[1] == 2 && array[2] == 4);
        }
    }
}
