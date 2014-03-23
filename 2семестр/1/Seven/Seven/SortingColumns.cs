using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seven
{
    public class SortingColumns
    {
        private static void SwapForTown(int[,] matrix, int firstTown, int secondTown, int stringsNumber)
        {
            for (int i = 0; i < stringsNumber; i++)
            {
                int temp = matrix[i, firstTown];
                matrix[i, firstTown] = matrix[i, secondTown];
                matrix[i, secondTown] = temp;
            }
        }
        public static void Sorting(int[,] matrix, int stringsNumber, int townsNumber)
        {
            for (int i = 0; i < townsNumber; i++)
            {
                for (int j = i; j > 0 && matrix[0, j - 1] > matrix[0, j]; j--)
                {
                    SwapForTown(matrix, j - 1, j, stringsNumber);
                }
            }
        }
    }
}
