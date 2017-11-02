using System;
using System.Collections.Generic;

namespace KD.Linq
{
    /// <summary>
    /// ForEach with Function as parameter.
    /// </summary>
    public class ForEachFunctionIterator<TValue> : ForEachIterator<TValue>
    {
        public Func<TValue, TValue> Function { get; }

        public ForEachFunctionIterator(IEnumerable<TValue> source, Func<TValue, TValue> function) :
            base(source)
        {
            this.Function = function;
        }

        public override void ForEachIndex()
        {
            this.Current = this.Function(this.Enumerator.Current);
        }
    }
}