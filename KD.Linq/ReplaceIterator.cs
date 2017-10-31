using System.Collections.Generic;

namespace KD.Linq
{
    /// <summary>
    /// Class used when replacement is needed.
    /// </summary>
    public abstract class ReplaceIterator<TValue> : ByIndexIterator<TValue>
    {
        /// <summary>
        /// New value for which the selected one will be replaced.
        /// </summary>
        public TValue NewValue { get; }

        public ReplaceIterator(IEnumerable<TValue> source, int index, TValue newValue) :
            base(source, index)
        {
            this.NewValue = newValue;
        }

        public override abstract void OnWantedIndexHit();

        public override abstract void OnWrongIndexHit();
    }
}