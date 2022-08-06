using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetPub;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LC.Common;

namespace LeetPub.Tests
{
    [TestClass()]
    public class MinAbsDiffTreeTests
    {
        [TestMethod()]
        public void GetMinimumDifferenceTest()
        {
            var root = new TreeNode(4);
            root.left = new TreeNode(2);
            root.right = new TreeNode(6);
            root.left.left = new TreeNode(1);
            root.left.right = new TreeNode(3);
            var cl = new MinAbsDiffTree();
            var result = cl.GetMinimumDifference(root);
            Assert.AreEqual(1, result);
        }
    }
}