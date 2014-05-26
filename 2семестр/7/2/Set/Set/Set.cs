using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Set
{
    /// <summary>
    /// Класс множеств
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class Set<T> : IEnumerable<T>
    {
        private HashSet<T> ourSet;
        public int Size
        {
            get
            {
                return ourSet.Count;
            }
        }

        /// <summary>
        /// Метод создания множества
        /// </summary>
        public Set()
        {
            ourSet = new HashSet<T>();
        }

        /// <summary>
        /// Метод добавления элемента
        /// </summary>
        /// <param name="value"></param>
        public void Add(T value)
        {
            ourSet.Add(value);
        }

        /// <summary>
        /// Метод удаления элемента
        /// </summary>
        /// <param name="value"></param>
        public bool Delete(T value)
        {
            return ourSet.Remove(value);
        }

        /// <summary>
        /// Метод проверки существования элемента в нашем множестве
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public bool Contain(T value)
        {
            return ourSet.Contains(value);
        }

        /// <summary>
        /// Объединения двух множеств
        /// </summary>
        /// <param name="firstSet"></param>
        /// <param name="secondSet"></param>
        /// <returns></returns>
        public static Set<T> Union(Set<T> firstSet, Set<T> secondSet)
        {
            Set<T> result = new Set<T>();
            foreach (var x in firstSet)
            {
                result.Add(x);
            }
            foreach (var x in secondSet)
            {
                if (!result.Contain(x))
                {
                    result.Add(x);
                }
            }
            return result;
        }

        /// <summary>
        /// Пересечение двух множеств
        /// </summary>
        /// <param name="firstSet"></param>
        /// <param name="secondSet"></param>
        /// <returns></returns>
        public static Set<T> Intersection(Set<T> firstSet, Set<T> secondSet)
        {
            Set<T> result = new Set<T>();
            foreach (var x in firstSet)
            {
                if (secondSet.Contain(x))
                {
                    result.Add(x);
                }
            }
            return result;
        }

        /// <summary>
        /// Метод "обнуления"
        /// </summary>
        public void Clear()
        {
            ourSet.Clear();
        }

        /// <summary>
        /// Энумератор
        /// </summary>
        /// <returns></returns>
        public IEnumerator<T> GetEnumerator()
        {
            return ourSet.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}

