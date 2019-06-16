using GameCommon.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GameCommon.Implementations
{
    public class FakeRandom<T> : IRandom<T>
    {
        private IEnumerator<T> sequenceEnumerator;

        public FakeRandom(IEnumerable<T> sequence)
        {
            if (sequence == null)
            {
                throw new ArgumentNullException(nameof(sequence));
            }

            sequenceEnumerator = sequence.GetEnumerator();
        }

        public T Next(T min, T max)
        {
            if (!sequenceEnumerator.MoveNext())
            {
                throw new InvalidOperationException("End of random sequence has been reached.");
            }

            return sequenceEnumerator.Current;
        }
    }
}
