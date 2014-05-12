using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTableNamespace
{
    /// <summary>
    /// Вторая хэш функция
    /// </summary>
    public class SecondHashFunction : IHashFunction
    {
        public int HashFunction(int value)
        {
            return (value.GetHashCode() % 100);
        }
    }
}
