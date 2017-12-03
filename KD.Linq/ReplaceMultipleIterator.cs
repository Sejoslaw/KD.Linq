using System;
using System.Collections.Generic;

namespace KD.Linq
{
    /// <summary>
    /// Iterator used for ReplaceMultiple method.
    /// </summary>]
    internal class ReplaceMultipleIterator<TValue> : ReplaceIterator<TValue>
    {
        public Func<TValue, bool> Selector { get; }

        public ReplaceMultipleIterator(IEnumerable<TValue> source, TValue newValue, Func<TValue, bool> selector) :
            base(source, -1, newValue) // -1 will prevent from any hit
        {
            this.Selector = selector;
        }

        /// <summary>
        /// This should never be hit.
        /// </summary>
        public override void OnWantedIndexHit()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// All logic should be here.
        /// </summary>
        public override void OnWrongIndexHit()
        {
            var canReplace = this.Selector(this.Enumerator.Current);
            if (this.Selector != null && canReplace)
            {
                this.Current = this.NewValue;
            }
            else
            {
                this.Current = this.Enumerator.Current;
            }
        }
    }
}