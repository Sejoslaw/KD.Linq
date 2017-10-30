﻿using System.Collections.Generic;

namespace KD.Linq
{
    /// <summary>
    /// Provides extension methods for <see cref="IEnumerable{T}"/>
    /// </summary>
    public static class Enumerables
    {
        /// <summary>
        /// Replaces value at specified index with new value.
        /// </summary>
        public static IEnumerable<TValue> ReplaceAt<TValue>(this IEnumerable<TValue> source, int index, TValue newValue)
        {
            return new ReplaceAtIterator<TValue>(source, index, newValue);
        }
    }
}