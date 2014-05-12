using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTableNamespace
{
    /// <summary>
    /// интерфейс хэш функции
    /// </summary>
    public interface IHashFunction
    {
         int HashFunction(int value);
    }
}
