using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilterFunction
{
    /// <summary>
    /// Класс необходимой нам функции
    /// </summary>
    public class Filter
    {
        /// <summary>
        /// Возвращает список с элементами, удовлетворяющими функции
        /// </summary>
        /// <param name="list">список</param>
        /// <param name="function">функция</param>
        /// <returns>получившийся список</returns>
        public static List<int> FilterFunc(List<int> list,Func<int, bool> function)
        {
            List<int> resultList = new List<int>();
            foreach(var x in list)
            {
                if (function(x) == true)
                {
                    resultList.Insert(resultList.Count, x);
                }
            }
            return resultList;
        }
    }
}
