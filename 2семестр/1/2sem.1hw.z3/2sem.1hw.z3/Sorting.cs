using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Third
{
    public class Sorting
    {
        public static void BubbleSort(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length - 1; j++)
                {
                    if (array[j + 1] > array[j])
                    {
                        array[j + 1] = array[j] + array[j + 1];
                        array[j] = array[j + 1] - array[j];
                        array[j + 1] = array[j + 1] - array[j];
                    }
                }
            }
        }
    }
}
