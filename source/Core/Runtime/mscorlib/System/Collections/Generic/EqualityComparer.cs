using System.Reflection;

namespace System.Collections.Generic
{
    /// <summary>
    /// Provides a base class for implementations of the IEqualityComparer generic interface.
    /// </summary>
    /// <typeparam name="T">The type of objects to compare.</typeparam>
    /// <remarks>
    /// This is required and used by the C# compiler when creating anonymous type declarations.
    /// </remarks>
    [EditorBrowsable(EditorBrowsableState.Never)]
    public abstract class EqualityComparer<T>
    {
        /// <summary>
        /// Gets a default equality comparer for the type specified by the generic argument.
        /// </summary>
        public static EqualityComparer<T> Default
        {
            get { return null; }
        }

        /// <summary>
        /// When overridden in a derived class, determines whether two objects of type T are equal.
        /// </summary>
        /// <param name="x">The object to compare to.</param>
        /// <param name="y">The object to compare with.</param>
        /// <returns>True if the objects are equal, false otherwise.</returns>
        public abstract bool Equals(T x, T y);

        /// <summary>
        /// When overridden in a derived class, serves as a hash function for the specified
        /// object for hashing algorithms and data structures, such as a hash table.
        /// </summary>
        /// <param name="obj">The object to get the hash code of.</param>
        /// <returns>A hash code.</returns>
        public abstract int GetHashCode(T obj);
    }
}
