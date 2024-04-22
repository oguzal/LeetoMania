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
    public class RemoveDupes26Tests
    {
        [TestMethod()]
        public void RemoveDuplicatesTest()
        {
            var cl=new RemoveDupes26();
            var result= cl.RemoveDuplicates(new int[] {1,1,2});// 1 2 222

            Assert.AreEqual(2,result);

        }
    }
}