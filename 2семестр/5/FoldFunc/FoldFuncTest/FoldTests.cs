using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using FoldFunc;

namespace FoldFunc
{
    [TestClass]
    public class FoldTests
    {
        [TestMethod]
        public void FoldFirstTest()
        {
            int result = FoldFunction.Fold(new List<int>() { 1, 2, 3 }, 1, (acc, elem) => acc * elem);
            Assert.IsTrue(result == 6);
        }
    }
}
