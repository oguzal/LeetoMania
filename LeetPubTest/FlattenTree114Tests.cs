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
    public class FlattenTree114Tests
    {
        
        [TestMethod()]
        public void FlattenTest()
        {
            var root1 = new TreeNode(1);
            root1.left = new TreeNode(2);
            root1.right = new TreeNode(5);
            root1.left.left = new TreeNode(3);
            root1.left.right = new TreeNode(4);
            root1.right.right= new TreeNode(6);

            var cl = new FlattenTree114();
            cl.Flatten(root1);
        }
    }
}