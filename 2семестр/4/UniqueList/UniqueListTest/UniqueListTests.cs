using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UniqueListNamespace;

namespace UniqueListTest
{
    [TestClass]
    public class UniqueListTests
    {
        
        [TestMethod]
        public void AddToHeadTest()
        {
            UniqueList<int> list = new UniqueList<int>();
            bool wasThrown = false;
            try
            {
                list.AddToHead(1);
                list.AddToHead(1);
            }
            catch (DublicateElementException)
            {
                wasThrown = true;
            }

            Assert.IsTrue(wasThrown);
        }
    }
}
