using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetPub;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace LeetPub.Tests
{
    [TestClass()]
    public class LongestCommonPrefix14Tests
    {
        [TestMethod()]
        public void LongestCommonPrefixTest()
        {
            var cl = new LongestCommonPrefix14();
            var result = cl.LongestCommonPrefix(new string[] { "abc", "ab", "a" });
            Assert.AreEqual("a", result);

            result = cl.LongestCommonPrefix(new string[] { "cir", "car" });
            Assert.AreEqual("c", result);

        }
    }
}