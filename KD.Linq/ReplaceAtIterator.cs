using System.Collections;
using System.Collections.Generic;

namespace KD.Linq
{
    /// <summary>
    /// Iterator used for ReplaceAt method.
    /// </summary>
    public class ReplaceAtIterator<TValue> : IEnumerable<TValue>, IEnumerator<TValue>
    {
        // Values needed for replace
        private IEnumerable<TValue> source;
        private int index;
        private TValue newValue;

        // Local variables
        private int currentIndex = 0;
        private IEnumerator<TValue> enumerator;

        public ReplaceAtIterator(IEnumerable<TValue> source, int index, TValue newValue)
        {
            this.source = source;
            this.index = index;
            this.newValue = newValue;
            this.enumerator = this.source.GetEnumerator();
        }

        public TValue Current { get; set; }

        object IEnumerator.Current { get; }

        public void Dispose()
        {
            this.Current = default(TValue);
        }

        public IEnumerator<TValue> GetEnumerator()
        {
            return this;
        }

        public bool MoveNext()
        {
            while (this.enumerator.MoveNext())
            {
                if (this.currentIndex == this.index)
                {
                    this.Current = this.newValue;
                }
                else
                {
                    this.Current = this.enumerator.Current;
                }
                currentIndex++;
                return true;
            }
            return false;
        }

        public void Reset()
        {
            this.currentIndex = -1;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this;
        }
    }
}