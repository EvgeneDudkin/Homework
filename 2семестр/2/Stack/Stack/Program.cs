using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> stack = new Stack<int>();
            stack.Push(1);
            stack.Push(2);
            stack.Push(2);
            //stack.Pop();
            Console.WriteLine(stack.Write());
            //Console.WriteLine(stack.Top());
            Console.WriteLine("{0}, " ,stack.Size());
        }
    }
}
