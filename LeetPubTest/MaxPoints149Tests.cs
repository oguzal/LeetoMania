using LC;
using LC.Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTests
{
    [TestClass]
    public class MaxPoints149Tests
    {


        [TestInitialize]
        public void TestInitialize()
        {

        }


        private MaxPoints149 CreateMaxPoints149()
        {
            return new MaxPoints149();
        }

        [TestMethod]
        public void MaxPoints_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var unitUnderTest = this.CreateMaxPoints149();
            Point[] points = new Point[6];
            points[0] = new Point(1, 1);
            points[1] = new Point(3, 2);
            points[2] = new Point(5, 3);
            points[3] = new Point(4, 1);
            points[4] = new Point(2, 3);
            points[5] = new Point(1, 4);

            var result = unitUnderTest.MaxPoints(points);
            Assert.AreEqual(4, result);
        }


        [TestMethod]
        public void MaxPoints_StateUnderTest_ExpectedBehavior2()
        {
            // Arrange
            var unitUnderTest = this.CreateMaxPoints149();
            Point[] points = new Point[3];
            points[0] = new Point(1, 1);
            points[1] = new Point(2, 2);
            points[2] = new Point(3, 3);

            var result = unitUnderTest.MaxPoints(points);
            Assert.AreEqual(3, result);
        }
        [TestMethod]
        public void MaxPoints_StateUnderTest_ExpectedBehavior4()
        {
            // Arrange
            var unitUnderTest = this.CreateMaxPoints149();
            Point[] points = new Point[4];
            points[0] = new Point(3, 10);
            points[1] = new Point(0, 2);
            points[2] = new Point(0, 2);
            points[3] = new Point(3, 10);

            var result = unitUnderTest.MaxPoints(points);
            Assert.AreEqual(4, result);
        }

        //[]
        [TestMethod]
        public void MaxPoints_StateUnderTest_ExpectedBehavior5()
        {
            // Arrange
            var unitUnderTest = this.CreateMaxPoints149();
            Point[] points = new Point[3];
            points[0] = new Point(0, 0);
            points[1] = new Point(94911151, 94911150);
            points[2] = new Point(94911152, 94911151);

            var result = unitUnderTest.MaxPoints(points);
            Assert.AreEqual(2, result);
        }


        [TestMethod]
        public void MaxPoints_StateUnderTest_ExpectedBehavior3()
        {
            // Arrange
            var unitUnderTest = this.CreateMaxPoints149();
            Point[] points = new Point[15];
            points[0] = new Point(0, -12);
            points[1] = new Point(5, 2);
            points[2] = new Point(2, 5);
            points[3] = new Point(0, -5);
            points[4] = new Point(1, 5);
            points[5] = new Point(2, -2);

            points[6] = new Point(5, -4);
            points[7] = new Point(3, 4);
            points[8] = new Point(-2, 4);

            points[9] = new Point(-1, 4);
            points[10] = new Point(0, -5);
            points[11] = new Point(0, -8);
            points[12] = new Point(-2, -1);
            points[13] = new Point(0, -11);
            points[14] = new Point(0, -9);

            var result = unitUnderTest.MaxPoints(points);
            Assert.AreEqual(6, result);
        }

    }
}
