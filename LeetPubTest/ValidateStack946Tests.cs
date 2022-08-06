using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetPub;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetPub.Tests
{
    [TestClass()]
    public class ValidateStack946Tests
    {
        [TestMethod()]
        public void ValidateStackSequencesTest()
        {
            var pushed = new int[] { 1, 2, 3, 4, 5 };

            var popped = new int[] { 4, 5, 3, 2, 1 };
            var cl = new ValidateStack946();
            Assert.IsTrue(cl.ValidateStackSequences(pushed, popped));
        }
    }
}