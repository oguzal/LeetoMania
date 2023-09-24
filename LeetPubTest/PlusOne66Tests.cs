using LeetPub;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;
using System.Linq;

namespace LeetPubTest
{
    [TestClass]
    public class PlusOne66Tests
    {
        private MockRepository mockRepository;



        [TestInitialize]
        public void TestInitialize()
        {
            this.mockRepository = new MockRepository(MockBehavior.Strict);


        }

        private PlusOne66 CreatePlusOne66()
        {
            return new PlusOne66();
        }

        [TestMethod]
        public void PlusOne_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var plusOne66 = this.CreatePlusOne66();
            int[] digits = new int[] { 1, 9, 9 };

            // Act
            var result = plusOne66.PlusOne(digits);

            // Assert
            Assert.IsTrue(result.SequenceEqual(new int[] { 2, 0, 0 }));


            digits = new int[] { 1, 2, 3 };
            result = plusOne66.PlusOne(digits);
            Assert.IsTrue(result.SequenceEqual(new int[] { 1, 2, 4 }));

            this.mockRepository.VerifyAll();
        }
    }
}
