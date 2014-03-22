using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace First
{
    public class Factorials
    {
        public static int Factorial(int value)
        {
            if (value <= 0)
            {
                return 1;
            }
            return value * Factorial(value - 1);
        }
    }
}
