using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree
{
    /// <summary>
    /// Класс двоичного дерева
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class BinaryTree<T> : ITree<T>, IEnumerable<T> where T : IComparable<T>
    {
        /// <summary>
        /// Класс узла в дереве
        /// </summary>
        private class Node
        {
            public T Value { get; set; }
            public Node LeftNode { get; set; }
            public Node RightNode { get; set; }
            public Node Parent { get; set; }

            public Node(T value)
            {
                this.Value = value;
            }
        }

        private Node Head { get; set; }

        /// <summary>
        /// Функция для добавления элемента в дерево
        /// </summary>
        /// <param name="value"></param>
        public void Add(T value)
        {
            Node newNode = new Node(value);
            if (Head == null)
            {
                Head = newNode;
            }
            AddFunction(ref newNode, Head);
        }

        /// <summary>
        /// Метод для добавления
        /// </summary>
        /// <param name="newNode"></param>
        /// <param name="nowPosition"></param>
        private void AddFunction(ref Node newNode, Node nowPosition)
        {
            if (newNode.Value.CompareTo(nowPosition.Value) == 1)
            {
                if (nowPosition.RightNode == null)
                {
                    newNode.Parent = nowPosition;
                    nowPosition.RightNode = newNode;
                    return;
                }
                AddFunction(ref newNode, nowPosition.RightNode);
                return;
            }
            if (newNode.Value.CompareTo(nowPosition.Value) == -1)
            {
                if (nowPosition.LeftNode == null)
                {
                    newNode.Parent = nowPosition;
                    nowPosition.LeftNode = newNode;
                    return;
                }
                AddFunction(ref newNode, nowPosition.LeftNode);
                return;
            }
        }

        /// <summary>
        /// Удаление элемента из дерева
        /// </summary>
        /// <param name="value"></param>
        public void Delete(T value)
        {
            DeleteFunction(value, Head);
        }

        /// <summary>
        /// Метод удаления
        /// </summary>
        /// <param name="value"></param>
        /// <param name="nowPosition"></param>
        private void DeleteFunction(T value, Node nowPosition)
        {
            if (value.CompareTo(nowPosition.Value) == 1)
            {
                if (nowPosition.RightNode == null)
                {
                    throw new NoFindObjectException();
                }
                DeleteFunction(value, nowPosition.RightNode);
                return;
            }
            if (value.CompareTo(nowPosition.Value) == -1)
            {
                if (nowPosition.LeftNode == null)
                {
                    throw new NoFindObjectException();
                }
                DeleteFunction(value, nowPosition.LeftNode);
                return;
            }

            if (value.CompareTo(nowPosition.Value) == 0)
            {
                if (nowPosition.LeftNode == null && nowPosition.RightNode == null)
                {
                    if (nowPosition == Head)
                    {
                        Head = null;
                        return;
                    }
                    if (nowPosition.Parent.LeftNode == nowPosition)
                    {
                        nowPosition.LeftNode = null;
                    }
                    else
                    {
                        nowPosition.Parent.RightNode = null;
                    }
                }
                if (nowPosition.LeftNode != null && nowPosition.RightNode == null)
                {
                    if (nowPosition == Head)
                    {
                        Head = Head.LeftNode;
                        return;
                    }
                    if (nowPosition.Parent.LeftNode == nowPosition)
                    {
                        nowPosition.Parent.LeftNode = nowPosition.LeftNode;
                    }
                    else
                    {
                        nowPosition.Parent.RightNode = nowPosition.LeftNode;
                    }
                    return;
                }
                if (nowPosition.LeftNode == null && nowPosition.RightNode != null)
                {
                    if (nowPosition == Head)
                    {
                        Head = Head.RightNode;
                        return;
                    }
                    if (nowPosition.Parent.LeftNode == nowPosition)
                    {
                        nowPosition.Parent.LeftNode = nowPosition.RightNode;
                    }
                    else
                    {
                        nowPosition.Parent.RightNode = nowPosition.RightNode;
                    }
                    return;
                }
                if (nowPosition.LeftNode != null && nowPosition.RightNode != null)
                {
                    if (nowPosition.RightNode.LeftNode == null)
                    {
                        nowPosition.RightNode.LeftNode = nowPosition.LeftNode;
                        if (nowPosition == Head)
                        {
                            Head = Head.RightNode;
                            return;
                        }
                        if (nowPosition.Parent.LeftNode == nowPosition)
                        {
                            nowPosition.Parent.LeftNode = nowPosition.RightNode;
                        }
                        else
                        {
                            nowPosition.Parent.RightNode = nowPosition.RightNode;
                        }
                        return;
                    }
                    Node temp = nowPosition.RightNode.LeftNode;
                    while (temp.LeftNode != null)
                    {
                        temp = temp.LeftNode;
                    }
                    nowPosition.Value = temp.Value;
                    if (temp.Parent.LeftNode == temp)
                    {
                        temp.Parent.LeftNode = temp.RightNode;
                    }
                    else
                    {
                        temp.Parent.RightNode = temp.RightNode;
                    }
                    return;
                }
            }
        }

        /// <summary>
        /// Функция поиска элемента в дереве
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public bool Find(T value)
        {
            return FindFunction(value, Head);
        }

        /// <summary>
        /// Метод поиска
        /// </summary>
        /// <param name="value"></param>
        /// <param name="nowPosition"></param>
        /// <returns></returns>
        private bool FindFunction(T value, Node nowPosition)
        {
            if (nowPosition == null)
            {
                return false;
            }
            if (value.CompareTo(nowPosition.Value) == -1)
            {
                return FindFunction(value, nowPosition.LeftNode);
            }
            if (value.CompareTo(nowPosition.Value) == 1)
            {
                return FindFunction(value, nowPosition.RightNode);
            }
            return true;
        }


        public IEnumerator<T> GetEnumerator()
        {
            Stack<Node> stack = new Stack<Node>();
            stack.Push(Head);
            while (stack.Count != 0)
            {
                Node temp = stack.Pop();
                if (temp.LeftNode != null)
                {
                    stack.Push(temp.LeftNode);
                }
                if (temp.RightNode != null)
                {
                    stack.Push(temp.RightNode);
                }
                yield return temp.Value;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
   

 


        
}
