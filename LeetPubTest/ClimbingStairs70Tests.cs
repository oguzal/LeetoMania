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
    public class ClimbingStairs70Tests
    {
        [TestMethod()]
        public void ClimbStairsTest()
        {
            var cl = new ClimbingStairs70();
            var result = cl.ClimbStairs(4);
            Assert.AreEqual(result, 5);

             result = cl.ClimbStairs(1);
            Assert.AreEqual(result, 1);

        }
    }
}