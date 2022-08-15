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
    public class MergeBinaryTrees617Tests
    {
        [TestMethod()]
        public void MergeTreesTest()
        {

            var root1 = new TreeNode(1);
            root1.left = new TreeNode(3);
            root1.right = new TreeNode(3);
            root1.left.left = new TreeNode(5);


            var root2 = new TreeNode(2);
            root2.left = new TreeNode(1);
            root2.right = new TreeNode(3);
            root2.right.right = new TreeNode(7);
            root2.left.right = new TreeNode(4);

            var cl = new MergeBinaryTrees617();
            var result = cl.MergeTrees(root1, root2);

            Assert.Fail();
        }
    }
}