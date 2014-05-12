﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Six
{
    /// <summary>
    /// Класс, который выводит элементы матрицы по спирали
    /// </summary>
    public class Spirals
    {
        /// <summary>
        /// Метод, который вывод элементы матрицы по спирали
        /// </summary>
        /// <param name="matrix">квадратная матрица, от которой нам нужны элементыпо спирали </param>
        /// <param name="size">размер матрицы (нечет)</param>
        /// <returns>элементы по спирали</returns>
        public static string Spiral(int[,] matrix, int size)
        {
            int i = size / 2;
            int j = size / 2;
            int numberOfSteps = 1;
            int directions = 0;
            int commitedSteps = 0;
            string result = Convert.ToString(matrix[i, j]) + ", ";
            for (int count = 0; count < size * size - 1; count++)
            {
                switch (directions % 4)
                {
                    case 0:
                        {
                            i--;
                            result = result + Convert.ToString(matrix[i, j]) + ", ";
                            break;
                        }
                    case 1:
                        {
                            j++;
                            result = result + Convert.ToString(matrix[i, j]) + ", ";
                            break;
                        }
                    case 2:
                        {
                            i++;
                            result = result + Convert.ToString(matrix[i, j]) + ", ";
                            break;
                        }
                    case 3:
                        {
                            j--;
                            result = result + Convert.ToString(matrix[i, j]) + ", ";
                            break;
                        }
                    default:
                        {
                            break;
                        }
                }
                commitedSteps++;
                if (commitedSteps == numberOfSteps)
                {
                    directions++;
                    commitedSteps = 0;
                    if (directions % 2 == 0)
                    {
                        numberOfSteps++;
                    }
                }
            }
            return result;
        }
    }
}