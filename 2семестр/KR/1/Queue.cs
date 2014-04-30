﻿using System.Collections.Generic;

namespace KR
{
    /// <summary>
    /// Queue with priority.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class Queue<T>
    {
        /// <summary>
        /// Constructor.
        /// </summary>
        public Queue()
        {
            list = new List<QueueElement<T>>();
        }

        /// <summary>
        /// Container of queue.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        private struct QueueElement<T>
        {
            public T value;
            public int priority;
        }
        /// <summary>
        /// Add new element in queue.
        /// </summary>
        /// <param name="value"></param>
        /// <param name="priority"></param>
        public void Enqueue(T value, int priority)
        {
            QueueElement<T> temp;
            temp.priority = priority;
            temp.value = value;
            list.Add(temp);
        }
        /// <summary>
        /// Return element with maximum priority and delete it in queue.
        /// </summary>
        /// <returns></returns>
        public T Dequeue()
        {
            int maxPriority = 0;
            T result = default(T);
            bool check = true;
            for (int i = 0; i < list.Count; ++i)
            {
                if (list[i].priority > maxPriority)
                {
                    maxPriority = list[i].priority;
                }
            }
            for (int i = 0; i < list.Count; ++i)
            {
                if (list[i].priority == maxPriority)
                {
                    result = list[i].value;
                    QueueElement<T> temp;
                    temp.value = result;
                    temp.priority = maxPriority;
                    list.Remove(temp);
                    check = false;
                    break;
                }
            }
            if (check)
            {
                throw new EmptyQueueException();
            }
            return result;
        }

        private List<QueueElement<T>> list;
    }
}
