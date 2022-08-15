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
    public class RemoveElement27Tests
    {
        [TestMethod()]
        public void RemoveElementTest()
        {
            var cl = new RemoveElement27();
            var res = cl.RemoveElement(new int[] { 3, 2, 2, 3 }, 3);

            Assert.AreEqual(res, 2);
            var res2 = cl.RemoveElement(new int[] { 0, 1, 2, 2, 3, 0, 4, 2 }, 2);
            Assert.AreEqual(res, 5);

        }

    }
}