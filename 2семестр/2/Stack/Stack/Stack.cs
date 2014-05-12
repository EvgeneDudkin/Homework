using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{
    /// <summary>
    /// Стэк
    /// </summary>
    /// <typeparam name="T">тип,который нам нужен</typeparam>
    public class Stack<T>
    {
        private ElementOfStack head;
        private int size;
        private class ElementOfStack
        {
            public T Value { get; set; }
            public ElementOfStack Next { get; set; }
            public ElementOfStack(Stack<T> stack)
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
        /// Метод, который вставляет элемент в "голову"
        /// </summary>
        /// <param name="value">элемент, который мы хотим поместить в "голову"</param>
        public void Push(T value)
        {
            ElementOfStack newElement = new ElementOfStack(this);
            newElement.Value = value;
            head = newElement;
            size++;
        }

        /// <summary>
        /// Удаляет элемент в "голове"
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
        /// Возвращает размер стэка
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
        /// ВОзвращает элемент в "голове"
        /// </summary>
        /// <returns>элемент в "голове"</returns>
        public T Top()
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
        /// Обнуляет стэк
        /// </summary>
        public void Clear()
        {
            head = null;
            size = 0;
        }

        /// <summary>
        /// Печатает стэк
        /// </summary>
        /// <returns>элементы стэка</returns>
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
