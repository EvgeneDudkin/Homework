using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Seven;

namespace SotringColumnsTest
{
    [TestClass]
    public class SotringColumnsTest
    {
        [TestMethod]
        public void TestSorting()
        {
            int[,] matrix = new int[3, 3];
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (j == 0)
                    {
                        matrix[i, j] = 2;
                    }
                    if (j == 1)
                    {
                        matrix[i, j] = 1;
                    }
                    if (j == 2)
                    {
                        matrix[i, j] = 0;
                    }
                }
            }
            SortingColumns.Sorting(matrix, 3, 3);
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (j == 0)
                    {
                        Assert.IsTrue(matrix[i, j] == 0);
                    }
                    if (j == 1)
                    {
                        Assert.IsTrue(matrix[i, j] == 1);
                    }
                    if (j == 2)
                    {
                        Assert.IsTrue(matrix[i, j] == 2);
                    }
                }
            }
        }
    }
}
