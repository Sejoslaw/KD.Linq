using System;
using System.Collections.Generic;

namespace KD.Linq
{
    /// <summary>
    /// Iterator used by ForEach methods.
    /// </summary>
    public abstract class ForEachIterator<TValue> : ByIndexIterator<TValue>
    {
        public ForEachIterator(IEnumerable<TValue> source) :
            base(source, -1)
        {
        }

        /// <summary>
        /// This should never be hit
        /// </summary>
        public override void OnWantedIndexHit()
        {
            throw new NotImplementedException();
        }

        public override void OnWrongIndexHit()
        {
            this.ForEachIndex();
        }

        // Abstract Methods

        public abstract void ForEachIndex();
    }
}