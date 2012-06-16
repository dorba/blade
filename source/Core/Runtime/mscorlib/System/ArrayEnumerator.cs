using System.Collections;

namespace System
{
    /// <summary>
    /// The array enumerator implementation
    /// </summary>
    [ScriptName("ArrayEnum")]
    public sealed class ArrayEnumerator : IEnumerator
    {
        /// <summary>
        /// Creates a new array enumerator.
        /// </summary>
        /// <param name="array">The array to enumerate over.</param>
        public ArrayEnumerator(Array array)
        {
        }

        /// <summary>
        /// Moves to the next item.
        /// </summary>
        /// <returns>True if the enumerator moved, false if at the end of the array.</returns>
        public bool MoveNext()
        {
            return false;   
        }

        /// <summary>
        /// Gets the current item.
        /// </summary>
        public object Current
        {
            get { return null;  }
        }

        /// <summary>
        /// Resets the enumerator back to index zero of the array.
        /// </summary>
        public void Reset()
        {
            
        }
    }
}