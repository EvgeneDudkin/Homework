using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTableNamespace
{
    /// <summary>
    /// первая хеш функция
    /// </summary>
    public class FirstHashFuntion : IHashFunction
    {
        public int HashFunction(int value)
        {
            ulong result = 0;
            string temp = value.ToString();
            for (int i = 0; i != temp.Length; i++)
            {
                result += (ulong)(temp[i] * Math.Pow(101, i));
            }
            return (int)(result % 100);
        }
    }
}
