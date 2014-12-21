using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree
{
    /// <summary>
    /// Интерфейс для дерева
    /// </summary>
    /// <typeparam name="T"></typeparam>
    interface ITree<T>
    {
        void Add(T value);

        void Delete(T value);

        bool Find(T value);
    }
}
