using System.Collections;
using System.Collections.Generic;

namespace KD.Linq
{
    /// <summary>
    /// Top layer of abstract iterator.
    /// </summary>
    public abstract class Iterator<TValue> : IIterator<TValue>
    {
        public IEnumerable<TValue> Source { get; set; }

        public TValue Current { get; set; }

        object IEnumerator.Current { get; }

        public virtual IEnumerator<TValue> GetEnumerator()
        {
            return this;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this;
        }

        public virtual void Reset()
        {
        }

        public virtual void Dispose()
        {
            this.Current = default(TValue);
        }

        // Abstract Methods

        public abstract bool MoveNext();
    }
}