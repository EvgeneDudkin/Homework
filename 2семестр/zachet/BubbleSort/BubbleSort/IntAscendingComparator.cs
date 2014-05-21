using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleSort
{
    /// <summary>
    /// Класс, интового компаратора, который будет реализовывать возврастание
    /// </summary>
    public class IntAscendingComparator: IComparator<int>
    {
        /// <summary>
        /// Метод сравнения
        /// </summary>
        /// <param name="firstElement">первый элемент</param>
        /// <param name="secondElement">второй элемент</param>
        /// <returns>true, если первый больше либо равен второму.иначе falsе</returns>
        public bool Compare(int firstElement, int secondElement)
        {
            if (firstElement >= secondElement)
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
