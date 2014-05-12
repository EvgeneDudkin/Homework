using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackCalculatorNamespace
{
    public class StackCalculator
    {
        public StackCalculator(IStack stack)
        {
            this.stack = stack;
        }

        private IStack stack;

        public void Add()
        {
            double firstElement = stack.Top();
            stack.Pop();
            double secondElement = stack.Top();
            stack.Pop();
            stack.Push(firstElement + secondElement);
        }

        public double Result()
        {
            double result = stack.Top();
            return result;
        }

        public void Push(double element)
        {
            stack.Push(element);
        }

        public void Deduct()
        {
            double firstElement = stack.Top();
            stack.Pop();
            double secondElement = stack.Top();
            stack.Pop();
            stack.Push(secondElement - firstElement);
        }

        public void Increase()
        {
            double firstElement = stack.Top();
            stack.Pop();
            double secondElement = stack.Top();
            stack.Pop();
            stack.Push(secondElement * firstElement);
        }

        public void Division()
        {
            double firstElement = stack.Top();
            stack.Pop();
            if (firstElement == 0)
            {
                throw new Exception();
            }
            double secondElement = stack.Top();
            stack.Pop();
            stack.Push(secondElement / firstElement);
        }
 
    }
}
