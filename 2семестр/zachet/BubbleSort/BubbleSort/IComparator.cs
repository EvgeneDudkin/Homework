using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleSort
{
    /// <summary>
    /// Интерфейс компаратора
    /// </summary>
    /// <typeparam name="T">тип данных</typeparam>
    public interface IComparator<T>
    {
        /// <summary>
        /// Метод сравнения двух элементов
        /// </summary>
        /// <param name="firstElement">первый элемент</param>
        /// <param name="secondElement">второй элемент</param>
        /// <returns>булевое значение</returns>
        bool Compare(T firstElement, T secondElement);
    }
}
