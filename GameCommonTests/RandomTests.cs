using GameCommon.Implementations;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GameCommonTests
{
    [TestClass]
    public class RandomTests
    {
        [TestMethod]
        [TestCategory("Unit")]
        public void GameCommonRandom_NextIntWithMinAndMax_DoesNotReturnAnythingOutOfBounds()
        {
            for (int seed = 0; seed < 100; ++seed)
            {
                var gameCommonRandom = new Random(seed);

                for (int min = 0; min < 100; ++min)
                {
                    for (int max = min; max < 100; ++max)
                    {
                        var result = gameCommonRandom.Next(min, max);

                        Assert.IsTrue(result >= min, "Should not return less than minimum");
                        Assert.IsTrue(result <= max, "Should not return more than maximum");
                    }
                }
            }
        }

        [TestMethod]
        [TestCategory("Unit")]
        public void GameCommonRandom_NextDoubleWithMinAndMax_DoesNotReturnAnythingOutOfBounds()
        {
            for (int seed = 0; seed < 100; ++seed)
            {
                var gameCommonRandom = new Random(seed);

                for (double min = -5.0; min < 5.0; min += 0.1)
                {
                    for (double max = min; max < 5.0; max += 0.1)
                    {
                        var result = gameCommonRandom.Next(min, max);

                        Assert.IsTrue(result >= min, "Should not return less than minimum");
                        Assert.IsTrue(result <= max, "Should not return more than maximum");
                    }
                }
            }
        }
    }
}
