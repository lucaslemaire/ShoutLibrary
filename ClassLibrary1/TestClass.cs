using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ClassLibrary1
{
    [TestClass]
    class UppercaseTest
    {
        [TestMethod]
        public void TestTrueEqualTrue()
        {
            Assert.IsTrue(true);
        }
    }
}
