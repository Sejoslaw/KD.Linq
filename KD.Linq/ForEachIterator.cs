using System;
using System.Collections.Generic;

namespace KD.Linq
{
    /// <summary>
    /// Iterator used by ForEach method.
    /// </summary>
    public class ForEachIterator<TValue> : ByIndexIterator<TValue>
    {
        public Action<TValue> Action { get; }

        public ForEachIterator(IEnumerable<TValue> source, Action<TValue> action) :
            base(source, -1)
        {
            this.Action = action;
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

        public virtual void ForEachIndex()
        {
            this.Current = this.Enumerator.Current;
            this.Action(this.Current);
        }
    }
}