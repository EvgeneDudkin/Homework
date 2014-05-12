using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HashTableNamespace;

namespace HashTableTest
{
    [TestClass]
    public class HashTableTests
    {
        [TestInitialize]
        public void Initialize()
        {
            hashTable = new HashTable(new FirstHashFuntion());
        }

        [TestMethod]
        public void InsertToHashTable()
        {
            hashTable.InsertToHashTable(9);
            bool result = hashTable.ExistHashTable(9);
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void ExistHashTable()
        {
            hashTable.InsertToHashTable(9);
            hashTable.InsertToHashTable(10);
            hashTable.InsertToHashTable(1);
            bool result = hashTable.ExistHashTable(8);
            Assert.IsFalse(result);
            Assert.IsTrue(hashTable.ExistHashTable(10));
            Assert.IsTrue(hashTable.ExistHashTable(9));
            Assert.IsTrue(hashTable.ExistHashTable(1));
        }

        [TestMethod]
        public void DeleteFromHashTable()
        {
            hashTable.InsertToHashTable(9);
            hashTable.InsertToHashTable(10);
            hashTable.DeleteFromHashTable(10);
            bool result = hashTable.ExistHashTable(10);
            Assert.IsFalse(result);
            Assert.IsTrue(hashTable.ExistHashTable(9));
        }

        [TestMethod]
        public void ChangeHashFunctionTest()
        {
            hashTable.InsertToHashTable(9);
            hashTable.InsertToHashTable(10);
            hashTable.InsertToHashTable(1);
            bool result = hashTable.ExistHashTable(8);
            Assert.IsFalse(result);
            Assert.IsTrue(hashTable.ExistHashTable(10));
            Assert.IsTrue(hashTable.ExistHashTable(9));
            Assert.IsTrue(hashTable.ExistHashTable(1));
            hashTable.ChangeHashFunction(new SecondHashFunction());
            Assert.IsTrue(hashTable.ExistHashTable(1));
            hashTable.InsertToHashTable(101);
            Assert.IsTrue(hashTable.ExistHashTable(101));
        }

        private HashTable hashTable;
    }
}
