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
    public class Fib509Tests
    {
        [TestMethod()]
        public void FibTest()
        {

            var fib = new Fib509();
            Assert.AreEqual(fib.Fib(4), 3);

            Assert.AreEqual(fib.Fib(0), 0);

        }
    }
}