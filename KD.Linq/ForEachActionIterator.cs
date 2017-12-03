using System;
using System.Collections.Generic;

namespace KD.Linq
{
    /// <summary>
    /// ForEach with Action as parameter.
    /// </summary>
    internal class ForEachActionIterator<TValue> : ForEachIterator<TValue>
    {
        public Action<TValue> Action { get; }

        public ForEachActionIterator(IEnumerable<TValue> source, Action<TValue> action) :
            base(source)
        {
            this.Action = action;
        }

        public override void ForEachIndex()
        {
            this.Current = this.Enumerator.Current;
            this.Action(this.Current);
        }
    }
}