using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace First
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Enter value ");
            int value = int.Parse(System.Console.ReadLine());
            if (value < 0)
            {
                System.Console.WriteLine("Error");
            }
            else
            {
                System.Console.WriteLine("Factorial {0} = {1}", value, Factorials.Factorial(value));
            }
        }
    }
}
