using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MApFunction
{
    /// <summary>
    /// Класс с нужной нам функцией
    /// </summary>
    public class Map
    {
        /// <summary>
        /// Возвращает лист с измененными функцией элементами 
        /// </summary>
        /// <param name="list">лист</param>
        /// <param name="function">функция</param>
        /// <returns>изменый лист</returns>
        public static List<int> MapFunc(List<int> list, Func<int, int> function)
        {
            List<int> resultList = new List<int>();
            foreach(var x in list)
            {
                resultList.Insert(resultList.Count, function(x));
            }
            return resultList;
        }
    }
}
