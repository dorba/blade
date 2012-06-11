
namespace System.Collections
{
    /// <summary>
    /// Service contract for any class that will act as an enumerator.
    /// </summary>
    public interface IEnumerator
    {
        /// <summary>
        /// Moves to the next item.
        /// </summary>
        /// <returns>True if an item is available, false otherwise.</returns>
        bool MoveNext();

        /// <summary>
        /// Gets the current object.
        /// </summary>
        Object Current { get; }

        /// <summary>
        /// Resets the enumerator.
        /// </summary>
        void Reset();
    }
}


