using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniqueListNamespace
{
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
        public virtual void AddToHead(T value)
        {
            var newElement = new ElementOfList(value, null, head);
            head = newElement;
            size++;
        }
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
        public void Clear()
        {
            head = null;
            size = 0;
        }
        public int Size()
        {
            return size;
        }

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
