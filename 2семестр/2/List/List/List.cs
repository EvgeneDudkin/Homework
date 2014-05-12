using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List
{ 
    /// <summary>
    /// Список
    /// </summary>
    /// <typeparam name="T">тип, который мы будем использовать</typeparam>
    public class List<T>
    {
        private ElementOfList head;
        private int size;
        private class ElementOfList
        {
            public T Value { get; set; } 
            public ElementOfList Next { get; set; }
            public ElementOfList Back { get; set; }

            public ElementOfList(T value, ElementOfList back, ElementOfList next)
            {
                Value = value;
                Back = back;
                Next = next;
            }
        }

        /// <summary>
        /// Метод, который добавляет значение в голову
        /// </summary>
        /// <param name="value">элемент, который мы добавляем</param>
        public void AddToHead(T value)
        {
            var newElement = new ElementOfList(value, null, head);
            head = newElement;
            size++;
        }

        /// <summary>
        /// Метод, который добавляет значение в конец
        /// </summary>
        /// <param name="value">Элемент, который мы добавляем</param>
        public void AddToEnd(T value)
        {
            if (size == 0)
            {
                AddToHead(value);
                return;
            }
            var count = head;
            for (int i = 1; i != size; i++)
            {
                count = count.Next;
            }
            var newElement = new ElementOfList(value, count, null);
            count.Next = newElement;
            size++;
        }

        /// <summary>
        /// Метод, который добавляет значение на заданную позицию
        /// </summary>
        /// <param name="position">позиция, на которую мы хотим вставить элемент</param>
        /// <param name="value">элемент, который мы хотим добавить</param>
        public void Insert(int position,T value)
        {
            if (position < 0 || position > size)
            {
                throw new Exception();
            }
            if (position == 0)
            {
                AddToHead(value);
                return;
            }
            if (position == size)
            {
                AddToEnd(value);
                return;
            }
            var count = head;
            while (position > 0)
            {
                var c = count;
                count = count.Next;
                count.Back = c;
                position--;
            }
            var newElement = new ElementOfList(value, count.Back, count);
            count.Back.Next = newElement;
            count.Back = newElement;
            size++;
        }

        /// <summary>
        /// Метод, который удаляет элемент с позиции
        /// </summary>
        /// <param name="position">позиция, с которой мы хотим удалить элемент</param>
        public void Delete(int position)
        {
            if (position < 0 || position >= size)
            {
                throw new Exception();
            }
            var count = head;
            for (int i = 0; i < position; i++)
            {
                count = count.Next;
            }
            if (count == head)
            {
                head = head.Next;
                size--;
                return;
            }
            if (count.Next == null)
            {
                count.Back.Next = null;
                size--;
                return;
            }
            count.Back.Next = count.Next;
            count.Next.Back = count.Back;
            size--;
        }

        /// <summary>
        /// Метод, который показывает существует ли этот элемент в списке
        /// </summary>
        /// <param name="value">элемент, который мы проверяем</param>
        /// <returns>возвращает true или false</returns>
        public bool Exist(T value)
        {
            for (var temp = head; temp != null; temp = temp.Next)
            {
                if (Equals(temp.Value, value))
                {
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// Метод, который возвращает элемент с позиции
        /// </summary>
        /// <param name="position">позиция, которая нас интересует</param>
        /// <returns>элемент на пазиции</returns>
        public T ReturnByIndex(int position)
        {
            if (position < 0 || position >= size)
            {
                throw new Exception();
            }
            var count = head;
            for (int i = 0; i < position; i++)
            {
                count = count.Next;
            }
            return count.Value;
        }

        /// <summary>
        /// Метод, который возвращает позицию по элементу
        /// </summary>
        /// <param name="value">элемент, позицию которого мы хотим найти</param>
        /// <returns>бросает исключение, если такого элемента в списке нет, иначе возвращает позицию</returns>
        public int FindIndex(T value)
        {
            int count = 0;
            for (var temp = head; temp != null; temp = temp.Next)
            {
                if (Equals(temp.Value, value))
                {
                    return count;
                }
                count++;
            }
            throw new Exception();
        }

        /// <summary>
        /// Обнуляет список
        /// </summary>
        public void Clear()
        {
            head = null;
            size = 0;
        }

        /// <summary>
        /// Метод, который возвращает размер списка
        /// </summary>
        /// <returns>размер списка</returns>
        public int Size()
        {
            return size;
        }

        /// <summary>
        /// Метод, который печатает список
        /// </summary>
        /// <returns>строка со всеми элементами списка (если пустой - исключение)</returns>
        public string Write()
        {
            if (this.head == null)
            {
                throw new Exception();
            }
            else
            {
                var temp = this.head;
                string stringOfList = Convert.ToString(temp.Value);
                temp = temp.Next;
                while (temp != null)
                {
                    stringOfList += ", " + Convert.ToString(temp.Value);
                    temp = temp.Next;
                }
                return stringOfList;
            }
        }
    }
}
