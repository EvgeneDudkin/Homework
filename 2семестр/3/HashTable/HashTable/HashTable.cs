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
        public IHashFunction HashFunction { get; set; }

        private const int hashSize = 100;

        private List.List<int>[] hashTable = new List.List<int>[hashSize];
        
        public HashTable(IHashFunction hashFunction)
        {
            HashFunction = hashFunction;
            for (int i = 0; i < hashSize; i++)
            {
                hashTable[i] = new List.List<int>();
            }
        }

        /// <summary>
        /// вставляет элемент в Хэш-таблицу
        /// </summary>
        /// <param name="element">элемент, который мы вставляем в таблицу</param>
        public void InsertToHashTable(int element)
        {
            int position = HashFunction.HashFunction(element);
            hashTable[position].AddToEnd(element); 
        }

        /// <summary>
        /// Удаляем элемент из Хэш-таблицы
        /// </summary>
        /// <param name="element">элемент,который нужно удалить</param>
        public void DeleteFromHashTable(int element)
        {
            int position = HashFunction.HashFunction(element);
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
            int position = HashFunction.HashFunction(element);
            bool result = hashTable[position].Exist(element);
            return result;
        }

        /// <summary>
        /// Изменение хеш-функции
        /// </summary>
        /// <param name="hasfunstion">хеш-функция</param>
        public void ChangeHashFunction(IHashFunction hasfunstion)
        {
            HashFunction = hasfunstion;
            for (int i = 0; i < 100; i++)
            {
                for (int j = 0; j < hashTable[i].Size(); j++)
                {
                    int temp = hashTable[i].ReturnByIndex(0);
                    InsertToHashTable(temp);
                    hashTable[i].Delete(0);
                }
            }
        }
    }
}
