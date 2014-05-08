using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace First
{
    /// <summary>
    /// Класс, считающий факториал 
    /// </summary>
    public class Factorials
    {
        /// <summary>
        /// Берем число и считаем его факториал 
        /// </summary>
        /// <param name="value">Число от которого мы считаем факториал</param>
        /// <returns>факториал</returns>
        public static int Factorial(int value)
        {
            if (value <= 0)
            {
                throw new Exception();
            }
            if (value == 1)
            {
                return 1;
            }
            return value * Factorial(value - 1);
        }
    }
}
