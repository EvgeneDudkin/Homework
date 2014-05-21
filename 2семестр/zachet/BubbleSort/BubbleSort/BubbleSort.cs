using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleSort
{
    /// <summary>
    /// Класс, который реализует наш шаблонную сортировку
    /// </summary>
    public class BubbleSort
    {
        /// <summary>
        /// Шаблонный метод сортировки массива 
        /// </summary>
        /// <typeparam name="T">тип данных</typeparam>
        /// <param name="array">массив, который мы сортируем</param>
        /// <param name="sizeOfArray">размер массива</param>
        /// <param name="comparator">компоратор, который мы используем</param>
        public static void BubbleSorting<T>(T[] array, int sizeOfArray, IComparator<T> comparator)
        {
            for (int i = 0; i < sizeOfArray; i++)
            {
                for(int j = 0; j < sizeOfArray - 1;j++)
                {
                    if(comparator.Compare(array[j],array[j+1]))
                    {
                        T temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                    }
                }
            }
        }
    }
}
