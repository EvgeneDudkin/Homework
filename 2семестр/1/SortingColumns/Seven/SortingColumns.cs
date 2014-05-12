using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seven
{
    /// <summary>
    /// класс, который сортирует столбцы матрицы по первым элементам
    /// </summary>
    public class SortingColumns
    {
        /// <summary>
        /// Метод, который меняет местами столбцы
        /// </summary>
        /// <param name="matrix">матрица, в которой мы работает</param>
        /// <param name="firstColumn">первый столбец</param>
        /// <param name="secondColumn">второй столбец</param>
        /// <param name="stringsNumber">количество строк</param>
        private static void SwapForColumns(int[,] matrix, int firstColumn, int secondColumn, int stringsNumber)
        {
            for (int i = 0; i < stringsNumber; i++)
            {
                int temp = matrix[i, firstColumn];
                matrix[i, firstColumn] = matrix[i, secondColumn];
                matrix[i, secondColumn] = temp;
            }
        }

        /// <summary>
        /// Метод, который сортирует столбцы матрицы
        /// </summary>
        /// <param name="matrix">матрица, в которой мы должны отсортировать столбцы</param>
        /// <param name="stringsNumber">количество строк</param>
        /// <param name="columnsNumber">количесвто столбцов</param>
        public static void Sorting(int[,] matrix, int stringsNumber, int columnsNumber)
        {
            for (int i = 0; i < columnsNumber; i++)
            {
                for (int j = i; j > 0 && matrix[0, j - 1] > matrix[0, j]; j--)
                {
                    SwapForColumns(matrix, j - 1, j, stringsNumber);
                }
            }
        }
    }
}
