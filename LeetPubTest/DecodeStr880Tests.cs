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
    public class DecodeStr880Tests
    {
        [TestMethod()]
        public void DecodeAtIndexTest()
        {

            var s = "leet2code3";
            var k = 10;

            var cl = new DecodeStr880();
            Assert.AreEqual(cl.DecodeAtIndex(s, k), "o");

            s = "a2b3c4d5e6f7g8h9";
            k = 10;
            Assert.AreEqual(cl.DecodeAtIndex(s, k), "c");

            s = "a23";k = 6;
            Assert.AreEqual(cl.DecodeAtIndex(s, k), "a");


        }
    }
}