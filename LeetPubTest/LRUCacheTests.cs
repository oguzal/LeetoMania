using Microsoft.VisualStudio.TestTools.UnitTesting;



namespace LeetPub.Tests
{
    [TestClass()]
    public class LRUCacheTests
    {
        [TestMethod()]
        public void GetTest()
        {
            //            ["LRUCache","put","put","get","put","get","put","get","get","get"]
            //                  [[2], [1,1],[2,2],[1],  [3,3],[2],[4,4],[1],[3],[4]]

            var cl = new LRUCache(2);
            cl.Put(1, 1);
            cl.Put(2, 2);
            var res = cl.Get(1);
            Assert.AreEqual(res, 1);
            cl.Put(3, 3);
            res = cl.Get(2);
            Assert.AreEqual(res, -1);
            cl.Put(4, 4);
            res = cl.Get(1);
            Assert.AreEqual(res, -1);

            res = cl.Get(3);
            Assert.AreEqual(res, 3);
            res = cl.Get(4);
            Assert.AreEqual(res, 4);


            cl = new LRUCache(2);
            cl.Put(2, 1);
            cl.Put(2, 2);
            res = cl.Get(2);
            Assert.AreEqual(res, 2);
            cl.Put(1, 1);
            cl.Put(4, 1);
            res = cl.Get(2);
            Assert.AreEqual(res, -1);


            cl = new LRUCache(2);
            cl.Put(2, 1);
            cl.Put(1, 1);
            cl.Put(2, 3);
            cl.Put(4, 1);
            res = cl.Get(1);
            Assert.AreEqual(res, -1);
            res = cl.Get(2);
            Assert.AreEqual(res, 3);


            //            ["LRUCache","put","put","put","put","get","get"]
            //                    [[2],[2,1],[1,1],[2,3],[4,1],[1],[2]]


        }
    }
}