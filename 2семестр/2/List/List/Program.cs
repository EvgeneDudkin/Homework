using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>();
            list.AddToHead(5);
            list.AddToHead(4);
            list.AddToHead(3);
            list.AddToEnd(6);
            list.Insert(3, 2);
            Console.WriteLine(list.Write());
        }
    }
}
