
namespace System.Collections
{
    /// <summary>
    /// Exposes the enumerator, which supports a simple iteration over a non-generic collection.
    /// </summary>
    public interface IEnumerable
    {
        /// <summary>
        /// Gets an enumerator that iterates through a collection.
        /// </summary>
        /// <returns>An enumerator object.</returns>
        IEnumerator GetEnumerator();
    }
}


