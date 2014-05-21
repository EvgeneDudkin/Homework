using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleSort
{
    /// <summary>
    /// Класс стрингового компаратора 
    /// </summary>
    public  class StringComparator: IComparator<string>
    {
        /// <summary>
        /// Метод сравнения по длине 
        /// </summary>
        /// <param name="firstElement">первый элемент</param>
        /// <param name="secondElement">второй элемент</param>
        /// <returns>true, если длина первого меньше либо равна длине второго. иначе false </returns>
        public bool Compare(string firstElement, string secondElement)
        {
            return firstElement.Length <= secondElement.Length;
        }
    }
}
