using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackCalculatorNamespace
{
    /// <summary>
    /// класс, который реализует стэковый калькулятор
    /// </summary>
    public class StackCalculator
    {
        public StackCalculator(IStack stack)
        {
            this.stack = stack;
        }

        private IStack stack;

        /// <summary>
        /// Метод суммы
        /// </summary>
        public void Add()
        {
            double firstElement = stack.Top();
            stack.Pop();
            double secondElement = stack.Top();
            stack.Pop();
            stack.Push(firstElement + secondElement);
        }

        /// <summary>
        /// Метод, который возвращает результат
        /// </summary>
        /// <returns>результат</returns>
        public double Result()
        {
            double result = stack.Top();
            return result;
        }

        /// <summary>
        /// Метод вставки
        /// </summary>
        /// <param name="element">элемент, который мы добавляем</param>
        public void Push(double element)
        {
            stack.Push(element);
        }

        /// <summary>
        /// Метод вычитания
        /// </summary>
        public void Deduct()
        {
            double firstElement = stack.Top();
            stack.Pop();
            double secondElement = stack.Top();
            stack.Pop();
            stack.Push(secondElement - firstElement);
        }

        /// <summary>
        /// Умножение
        /// </summary>
        public void Increase()
        {
            double firstElement = stack.Top();
            stack.Pop();
            double secondElement = stack.Top();
            stack.Pop();
            stack.Push(secondElement * firstElement);
        }

        /// <summary>
        /// Деление
        /// </summary>
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
