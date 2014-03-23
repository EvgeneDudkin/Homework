using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Six;

namespace SpiralTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            int[,] matrix = new int[3, 3];
            for (int i = 0; i < 3; i++)
            {
                for(int j = 0; j < 3; j++)
                {
                    if (i == 0)
                    {
                        matrix[i, j] = 0;
                    }
                    if (i == 1)
                    {
                        matrix[i, j] = 1;
                    }
                    if (i == 2)
                    {
                        matrix[i, j] = 2;
                    }
                }
            }
            string answer = Spirals.Spiral(matrix, 3);
            string testAnswer = "1, 0, 0, 1, 2, 2, 2, 1, 0, ";
            Assert.IsTrue(answer == testAnswer);
        }
    }
}
