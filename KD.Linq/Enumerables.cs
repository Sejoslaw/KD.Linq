using System;
using System.Collections.Generic;
using System.Linq;

namespace KD.Linq
{
    /// <summary>
    /// Provides extension methods for <see cref="IEnumerable{T}"/>
    /// </summary>
    public static class Enumerables
    {
        /// <summary>
        /// Returns all occurrence of specified element in current Enumerable.
        /// </summary>
        public static IEnumerable<TValue> Find<TValue>(this IEnumerable<TValue> source, TValue lookingFor)
        {
            var list = new List<TValue>();
            foreach (var value in source)
            {
                if (value.Equals(lookingFor))
                {
                    list.Add(value);
                }
            }
            return list;
        }

        /// <summary>
        /// Generic version of "ForEach" method.
        /// Made separate from <see cref="List{T}"/>.
        /// </summary>
        public static IEnumerable<TValue> ForEach<TValue>(this IEnumerable<TValue> source, Action<TValue> action)
        {
            if (action == null) throw new ArgumentNullException(nameof(action), "Cannot run null Action.");
            return new ForEachActionIterator<TValue>(source, action);
        }

        /// <summary>
        /// Generic version of "ForEach" method.
        /// Made separate from <see cref="List{T}"/>.
        /// </summary>
        public static IEnumerable<TValue> ForEach<TValue>(this IEnumerable<TValue> source, Func<TValue, TValue> function)
        {
            if (function == null) throw new ArgumentNullException(nameof(function), "Cannot run null Function.");
            return new ForEachFunctionIterator<TValue>(source, function);
        }

        /// <summary>
        /// Returns the index number of specified element; if not found, will return -1 instead.
        /// </summary>
        public static int IndexOf<TValue>(this IEnumerable<TValue> source, TValue value)
        {
            for (int i = 0; i < source.Count(); ++i)
            {
                var element = source.ElementAt(i);
                if (element.Equals(value))
                {
                    return i;
                }
            }
            return -1;
        }

        /// <summary>
        /// Replaces value at specified index with new value.
        /// </summary>
        public static IEnumerable<TValue> ReplaceAt<TValue>(this IEnumerable<TValue> source, int index, TValue newValue)
        {
            if (index < 0 || index > int.MaxValue) throw new IndexOutOfRangeException($"Wrong index value ({ index })");
            return new ReplaceAtIterator<TValue>(source, index, newValue);
        }

        /// <summary>
        /// Replaces multiple values by given selector.
        /// If the selector is null
        /// </summary>
        public static IEnumerable<TValue> ReplaceMultiple<TValue>(this IEnumerable<TValue> source, TValue newValue, Func<TValue, bool> selector = null)
        {
            return new ReplaceMultipleIterator<TValue>(source, newValue, selector);
        }
    }
}