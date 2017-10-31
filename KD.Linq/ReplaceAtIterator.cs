using System.Collections.Generic;

namespace KD.Linq
{
    /// <summary>
    /// Iterator used for ReplaceAt method.
    /// </summary>
    public class ReplaceAtIterator<TValue> : ByIndexIterator<TValue>
    {
        // Values needed for replace
        private TValue newValue;

        public ReplaceAtIterator(IEnumerable<TValue> source, int index, TValue newValue) :
            base(source, index)
        {
            this.newValue = newValue;
        }

        public override void OnWantedIndexHit()
        {
            this.Current = this.newValue;
        }

        public override void OnWrongIndexHit()
        {
            this.Current = this.Enumerator.Current;
        }
    }
}