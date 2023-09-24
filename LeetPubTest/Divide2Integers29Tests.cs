using LeetPub;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;

namespace LeetPubTest
{
    [TestClass]
    public class Divide2Integers29Tests
    {
        private MockRepository mockRepository;



        [TestInitialize]
        public void TestInitialize()
        {
            this.mockRepository = new MockRepository(MockBehavior.Strict);
        }

        private Divide2Integers29 CreateDivide2Integers29()
        {
            return new Divide2Integers29();
        }

        [TestMethod]
        public void FindDivision_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var divide2Integers29 = this.CreateDivide2Integers29();
            int dividend = -3;
            int divisor = -1;

            // Act
            var result = divide2Integers29.FindDivision(dividend, divisor);

            // Assert
            Assert.AreEqual(result, 3);
            this.mockRepository.VerifyAll();

            dividend = -2147483648;
            divisor = -1;
            result = divide2Integers29.FindDivision(dividend, divisor);
            Assert.AreEqual(2147483647, result );

        }
    }
}
