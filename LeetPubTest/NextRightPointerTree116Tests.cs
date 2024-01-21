using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetPub;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Node= LeetPub.NextRightPointerTree116.Node;

namespace LeetPub.Tests
{
    [TestClass()]
    public class NextRightPointerTree116Tests
    {
        [TestMethod()]
        public void ConnectTest()
        {
            var root = new  Node(1, null, null, null);
            root.left = new Node(2, null, null, null);
            root.right = new Node(3, null, null, null);
            root.left.left = new Node(4, null, null, null);
            root.left.right = new Node(5, null, null, null);
            root.right.left = new Node(6, null, null, null);
            root.right.right = new Node(7, null, null, null);
            var cl = new NextRightPointerTree116();
            cl.Connect(root);
            Assert.IsTrue(root.left.next == root.right);
            Assert.IsTrue(root.left.left.next == root.right.right);

        }
    }
}