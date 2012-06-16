using System;

namespace System.Collections.Generic
{
    /// <summary>
    /// Service contract for any class that will act as a generic enumerator.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IEnumerator<out T> : IEnumerator
    {
        /// <summary>
        /// Gets the current item.
        /// </summary>
        new T Current { get; }
    }
}
