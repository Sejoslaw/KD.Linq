using System.Collections.Generic;

namespace KD.Linq
{
    /// <summary>
    /// Iterator which iterates over each index.
    /// </summary>
    internal abstract class ByIndexIterator<TValue> : Iterator<TValue>
    {
        /// <summary>
        /// Index on which the action should be done.
        /// </summary>
        public int Index { get; }
        /// <summary>
        /// Source collection enumerator.
        /// </summary>
        public IEnumerator<TValue> Enumerator { get; set; }

        /// <summary>
        /// Indicates on which index we are currently.
        /// </summary>
        private int currentIndex = 0;

        public ByIndexIterator(IEnumerable<TValue> source, int index)
        {
            this.Source = source;
            this.Index = index;
            this.Enumerator = this.Source.GetEnumerator();
        }

        public override bool MoveNext()
        {
            var moved = this.Enumerator.MoveNext();
            if (moved)
            {
                if (this.currentIndex == this.Index)
                {
                    OnWantedIndexHit();
                }
                else
                {
                    OnWrongIndexHit();
                }
                this.currentIndex++;
                return true;
            }
            return false;
        }

        /// <summary>
        /// Method which is run when we hit an index which we wanted.
        /// </summary>
        public abstract void OnWantedIndexHit();

        /// <summary>
        /// Method which is run when we hit an index which is not the one we wanted.
        /// </summary>
        public abstract void OnWrongIndexHit();
    }
}