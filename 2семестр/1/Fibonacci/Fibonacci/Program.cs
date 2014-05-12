using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Second
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Enter number ");
            int number = int.Parse(System.Console.ReadLine());
            if (number <= 0)
            {
                Console.WriteLine("Error ");
            }
            else
            System.Console.WriteLine("Answer : {0}", FibonacciClass.Fibonacci(number));
        }
    }
}
