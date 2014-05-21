using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleSort
{
    /// <summary>
    /// Класс интововго компаратора, который реализует убывание
    /// </summary>
    public class IntDescendingComparator: IComparator<int>
    {
        /// <summary>
        /// Метод сравнения
        /// </summary>
        /// <param name="firstElement">первый элемент</param>
        /// <param name="secondElement">второй элемент</param>
        /// <returns>true, если первый больше либо равен второму.иначе false</returns>
        public bool Compare(int firstElement,int secondElement)
        {
            if (firstElement <= secondElement)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
