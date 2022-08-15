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
    public class SearchInsert35Tests
    {
        [TestMethod()]
        public void SearchInsertTest()
        {
            var cl = new SearchInsert35();
            var arr = new int[] { 1, 3, 5, 6 };

            var result= cl.SearchInsert(arr,4);
            Assert.AreEqual(2, result);


        }
    }
}