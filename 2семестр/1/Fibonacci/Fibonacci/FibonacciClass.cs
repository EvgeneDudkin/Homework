using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Second
{
    /// <summary>
    /// Считает числа Фибоначчи
    /// </summary>
   public class FibonacciClass
    {
       /// <summary>
       /// Считает Фибоначчи от число
       /// </summary>
       /// <param name="value">число, для которого нужно посчитать</param>
       /// <returns>Число Фибоначчи</returns>
        static public int Fibonacci(int value)
        {
            if (value <= 0)
            {
                throw new Exception();
            }
            if (value <= 2)
            {
                return 1;
            }
            return Fibonacci(value - 1) + Fibonacci(value - 2);
        }
    }
}
