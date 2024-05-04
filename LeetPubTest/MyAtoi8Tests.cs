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
    public class MyAtoi8Tests
    {
        [TestMethod()]
        public void myAtoiTest()
        {
            var cl = new MyAtoi8();
            Assert.AreEqual(0, cl.myAtoi("+"));
            Assert.AreEqual(-1233, cl.myAtoi("-1233"));
            Assert.AreEqual(57575, cl.myAtoi("+57575"));
        }
    }
}