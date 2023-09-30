using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetPub;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetPub.Tests
{
    [TestClass()]
    public class PascalTriangle2_119Tests
    {
        [TestMethod()]
        public void GetRowTest()
        {
            var pt = new PascalTriangle2_119();
            var result = pt.GetRow(3);
            Assert.IsTrue(result[2] == 3);
            Assert.IsTrue(result[3] == 1);

        }
    }
}