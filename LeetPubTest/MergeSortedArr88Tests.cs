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
    public class MergeSortedArr88Tests
    {
        [TestMethod()]
        public void MergeTest()
        {
            var cl = new MergeSortedArr88();
            cl.Merge(new int[] { 1, 2, 3, 0, 0, 0 }, 3, new int[] { 2, 5, 6 }, 3);

            cl.Merge(new int[] { 1 }, 1, new int[] { }, 0);
        }
    }
}