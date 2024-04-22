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
    public class UniqueBinaryTreesII_96Tests
    {
        [TestMethod()]
        public void GenerateTreesTest()
        {
            var trees = new UniqueBinaryTreesII_96().GenerateTrees(3);
            Assert.AreEqual(5, trees.Count);
        }
    }
}