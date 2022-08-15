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
    public class SortedSquare977Tests
    {
        [TestMethod()]
        public void SortedSquaresTest()
        {
            var cl = new SortedSquare977();
            var result = cl.SortedSquares(new int[] { -4, -1, 0, 3, 10 });
            Assert.AreEqual(result[2], 9);
            var result2 = cl.SortedSquares(new int[] { -1 });
            Assert.AreEqual(result2[0], 1);

            var result3 = cl.SortedSquares(new int[] { -5, -3, -2, -1 });
            Assert.AreEqual(result3[2], 9);



        }
    }
}