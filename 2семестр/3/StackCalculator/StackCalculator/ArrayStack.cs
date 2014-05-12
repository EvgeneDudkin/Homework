using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackCalculatorNamespace
{
    /// <summary>
    /// класс, реализующий стэк на масивах
    /// </summary>
    public class ArrayStack : IStack
    {
        /// <summary>
        /// Метод, вствавляющий элемент в голову
        /// </summary>
        /// <param name="value">элемент, который нам нужно вставить</param>
        public void Push(double value)
        {
            headIndex++;
            array[headIndex] = value;
        }

        /// <summary>
        /// Метод, который удаляет элемент в голове
        /// </summary>
        public void Pop()
        {
            headIndex--;
        }

        /// <summary>
        /// Метод, который возвращает размер стэка
        /// </summary>
        /// <returns>размер стэка</returns>
        public int Size()
        {
            return headIndex + 1;
        }

        /// <summary>
        /// Метод, который возвращает элемент в голове
        /// </summary>
        /// <returns>элемент в голове</returns>
        public double Top()
        {
            return array[headIndex];
        }

        /// <summary>
        /// Метод, который обнуляет стэк
        /// </summary>
        public void Clear()
        {
            headIndex = -1;
        }

        /// <summary>
        /// Метод, который печатает стэк
        /// </summary>
        /// <returns>все элементы стэка в виде строки</returns>
        public string Write()
        {
            string result = "";
            for (int i = headIndex; i >= 0; i--)
            {
                result += array[i].ToString() + " ";
            }
            return result;
        }

        private double[] array = new double[100];
        private int headIndex = -1;
    }
}
