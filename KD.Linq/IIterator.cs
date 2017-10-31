using System.Collections.Generic;

namespace KD.Linq
{
    /// <summary>
    /// Iterator which iterates over specified source Collection.
    /// </summary>
    public interface IIterator<TValue> : IEnumerable<TValue>, IEnumerator<TValue>
    {
        /// <summary>
        /// Source from which the iteration was started.
        /// </summary>
        IEnumerable<TValue> Source { get; set; }
    }
}