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
    public class ReversePolishNot150Tests
    {
        [TestMethod()]
        public void EvalRPNTest()
        {
            var cl = new ReversePolishNot150();
            string[] inp = new string[] { "2", "1", "+", "3", "*" };
            var result = cl.EvalRPN(inp);
            Assert.AreEqual(result,9);
        }
    }
}