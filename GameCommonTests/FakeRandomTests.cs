using GameCommon.Implementations;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace GameCommonTests
{
    [TestClass]
    public class FakeRandomTests
    {
        [TestMethod]
        [TestCategory("Unit")]
        public void FakeRandom_Constructor_NullSequence_ThrowsArgumentNullException()
        {
            Assert.ThrowsException<ArgumentNullException>(() => new FakeRandom<int>(null));
        }

        [TestMethod]
        [TestCategory("Unit")]
        public void FakeRandom_IntNext_ReturnsSequence()
        {
            var testSequence = new int[] { 1, 2, 3, 4, 5};
            var fakeRandom = new FakeRandom<int>(testSequence);

            for (int i = 0; i < testSequence.Length; ++i)
            {
                Assert.AreEqual(
                    expected: testSequence[i],
                    actual: fakeRandom.Next(0, 5)
                );
            }
        }

        [TestMethod]
        [TestCategory("Unit")]
        public void FakeRandom_IntNext_EndOfSequence_ThrowsException()
        {
            var testSequence = new int[] { 1, 2, 3 };
            var fakeRandom = new FakeRandom<int>(testSequence);

            for (int i = 0; i < testSequence.Length; ++i)
            {
                fakeRandom.Next(0, 5);
            }

            Assert.ThrowsException<InvalidOperationException>(() => fakeRandom.Next(0, 5));
        }
    }
}
