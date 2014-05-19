using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoldFunc
{
    /// <summary>
    /// Класс нужной нам фкункции
    /// </summary>
    public class FoldFunction
    {
        /// <summary>
        /// Функция Fold
        /// </summary>
        /// <param name="list">список, который мы принимаем</param>
        /// <param name="firstElement">элемент</param>
        /// <param name="function">функция</param>
        /// <returns>значение </returns>
        public static int Fold(List<int> list, int firstElement, Func<int, int, int> function)
        {
            foreach (var x in list)
            {
                firstElement = function(firstElement, x);
            }
            return firstElement;
        }
    }
}
