using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MApFunction;
using System.Collections.Generic;

namespace MapFunction
{
    [TestClass]
    public class MApFunctionTests
    {
        [TestMethod]
        public void FirstMapTest()
        {
            List<int> list = new List<int>() { 1, 2, 3 };
            List<int> testList = new List<int>();
            testList = Map.MapFunc(list, x => x * 2);
            Assert.IsTrue(testList[0] == 2 && testList[1] == 4 && testList[2] == 6);
        }
    }
}
