using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTableNamespace
{
    /// <summary>
    /// класс Хэш-таблица
    /// </summary>
    public class HashTable
    {
        private const int hashSize = 100;

        private List.List<int>[] hashTable = new List.List<int>[hashSize];
        
        public HashTable()
        {
            for (int i = 0; i < hashSize; i++)
            {
                hashTable[i] = new List.List<int>();
            }
        }

        private int HashFunction(int value)
        {
            ulong result = 0;
            string temp = value.ToString();
            for (int i = 0; i != temp.Length; i++)
            {
                result += (ulong)(temp[i] * Math.Pow(101, i));
            }
            return (int)(result % hashSize);
        }

        /// <summary>
        /// вставляет элемент в Хэш-таблицу
        /// </summary>
        /// <param name="element">элемент, который мы вставляем в таблицу</param>
        public void InsertToHashTable(int element)
        {
            int position = HashFunction(element);
            hashTable[position].AddToEnd(element); 
        }

        /// <summary>
        /// Удаляем элемент из Хэш-таблицы
        /// </summary>
        /// <param name="element">элемент,который нужно удалить</param>
        public void DeleteFromHashTable(int element)
        {
            int position = HashFunction(element);
            int index = hashTable[position].FindIndex(element);
            hashTable[position].Delete(index);
        }

        /// <summary>
        /// Метод, который проверяет, существует ли элемент в таблице
        /// </summary>
        /// <param name="element">елемент, наличие которого мы хотим проверить</param>
        /// <returns>возвращает true или false</returns>
        public bool ExistHashTable(int element)
        {
            int position = HashFunction(element);
            bool result = hashTable[position].Exist(element);
            return result;
        }
    }
}
