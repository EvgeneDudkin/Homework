using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Second
{
   public class Function
    {
        static public int Fibonacci(int value)
        {
            if (value <= 2)
            {
                return 1;
            }
            return Fibonacci(value - 1) + Fibonacci(value - 2);
        }
    }
}
