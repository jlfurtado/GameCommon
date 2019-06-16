using GameCommon.Interfaces;

namespace GameCommon.Implementations
{
    public class Random : IRandom<int>, IRandom<double>
    {
        private readonly System.Random rand;

        public Random(int seed)
        {
            rand = new System.Random(seed);
        }

        public double Next(double min, double max)
        {
            return (rand.NextDouble() * (max - min)) + min;
        }

        public int Next(int min, int max)
        {
            return rand.Next(min, max);
        }
    }
}
