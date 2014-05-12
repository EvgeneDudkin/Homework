using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FilterFunction;
using System.Collections.Generic;

namespace FilterFunction
{
    [TestClass]
    public class FilterFunctionTests
    {
        [TestMethod]
        public void FilterFunctionTest()
        {
            List<int> list = new List<int> { 1, 2, 3 };
            List<int> result = Filter.FilterFunc(list, x => (x % 2) == 0);
            Assert.IsTrue(result[0] == 2 && result.Count == 1);
        }
    }
}
