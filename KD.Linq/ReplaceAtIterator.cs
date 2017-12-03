using System.Collections.Generic;

namespace KD.Linq
{
    /// <summary>
    /// Iterator used for ReplaceAt method.
    /// </summary>
    internal class ReplaceAtIterator<TValue> : ReplaceIterator<TValue>
    {
        public ReplaceAtIterator(IEnumerable<TValue> source, int index, TValue newValue) :
            base(source, index, newValue)
        {
        }

        public override void OnWantedIndexHit()
        {
            this.Current = this.NewValue;
        }

        public override void OnWrongIndexHit()
        {
            this.Current = this.Enumerator.Current;
        }
    }
}