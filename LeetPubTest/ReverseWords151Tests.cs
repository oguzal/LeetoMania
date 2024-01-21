using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetPub;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace LeetPub.Tests
{
    [TestClass()]
    public class ReverseWords151Tests
    {
        [TestMethod()]
        public void ReverseWordsTest()
        {
            var cl = new ReverseWords151();
            var result=cl.ReverseWords("the sky is blue");
            var expected = "blue is sky the";
            Assert.AreEqual(result,expected);
             result = cl.ReverseWords("  hello world  ");
            expected = "world hello"; 
            Assert.AreEqual(result, expected);
        }
    }
}