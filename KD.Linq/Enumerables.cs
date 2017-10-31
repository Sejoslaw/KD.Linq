﻿using System;
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
        /// Generic version of "ForEach" method.
        /// Made separate from <see cref="List{T}"/>.
        /// </summary>
        public static IEnumerable<TValue> ForEach<TValue>(this IEnumerable<TValue> source, Action<TValue> action)
        {
            if (action == null) throw new ArgumentNullException(nameof(action), "Cannot run null Action.");
            return new ForEachIterator<TValue>(source, action);
        }

        /// <summary>
        /// Returns the index number of specified element.
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