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
    public class AncestorNodeGraph2192Tests
    {
        [TestMethod()]
        public void GetAncestorsTest()
        {
            int[][] ed = new int[][]
{
new int[] { 0, 1},
new int[] { 1, 2},
new int[] { 1, 3},
new int[] { 1, 4},
new int[] { 2, 4},
};

            int[][] ed2 = new int[][]
{
new int[] { 0, 1},
new int[] { 0, 2},
new int[] { 0, 3},
new int[] { 0, 4},
new int[] { 1, 2},
new int[] { 1, 3},
new int[] { 1, 4},
new int[] { 2, 3},
new int[] { 2, 4},
new int[] { 3, 4}
};

            var cl = new AncestorNodeGraph2192();
            var result = cl.GetAncestors(2, ed);
        }
    }
}