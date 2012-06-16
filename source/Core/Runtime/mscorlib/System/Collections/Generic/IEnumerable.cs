using System;

namespace System.Collections.Generic
{
    /// <summary>
    /// Exposes the enumerator, which supports a simple iteration over a generic collection.
    /// </summary>
    /// <typeparam name="T">The collection data type.</typeparam>
    public interface IEnumerable<T> : IEnumerable
    {
        /// <summary>
        /// Gets the enumerator.
        /// </summary>
        /// <returns>A generic enumerator.</returns>
        IEnumerator<T> GetEnumerator();
    }
}
