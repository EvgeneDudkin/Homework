using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackCalculatorNamespace
{
    /// <summary>
    /// класс, который реализует стэк на списках
    /// </summary>
    public class Stack : IStack
    {
        private ElementOfStack head;
        private int size;
        private class ElementOfStack
        {
            public double Value { get; set; }
            public ElementOfStack Next { get; set; }
            public ElementOfStack(Stack stack)
            {
                this.Next = stack.head;
            }
        }

        public Stack()
        {
            head = null;
            size = 0;
        }

        /// <summary>
        /// Метод, который вставляет элемент в голову 
        /// </summary>
        /// <param name="value">элемент, который нам нужно вставить</param>
        public void Push(double value)
        {
            ElementOfStack newElement = new ElementOfStack(this);
            newElement.Value = value;
            head = newElement;
            size++;
        }

        /// <summary>
        /// Метод, который удаляет элемент из головы
        /// </summary>
        public void Pop()
        {
            if (head != null)
            {
                this.head = this.head.Next;
                size--;
            }
            else
            {
                throw new Exception();
            }
        }

        /// <summary>
        /// Метод, который возвращает размер стэка
        /// </summary>
        /// <returns>размер стэка</returns>
        public int Size()
        {
            int count = 0;
            if (head != null)
            {
                while (this.head != null)
                {
                    this.head = this.head.Next;
                    count++;
                }
                return count;
            }
            else
            {
                return count;   
            }
        }

        /// <summary>
        /// Метод, который возвращает элемнет из головы
        /// </summary>
        /// <returns>элемент из головы</returns>
        public double Top()
        {
            if (head != null)
            {
                return head.Value;
            }
            else
            {
                throw new Exception();
            }
        }

        /// <summary>
        /// Метод который обнуляет стэк
        /// </summary>
        public void Clear()
        {
            head = null;
            size = 0;
        }

        /// <summary>
        /// Метод, который печатает стэк
        /// </summary>
        /// <returns>все элементы стэка в виде строки</returns>
        public string Write()
        {
            string result = "";
            for (ElementOfStack temp = head; temp != null; temp = temp.Next)
            {
                result += temp.Value;
                result += " ";
            }
            return result;
        }
    }
}
