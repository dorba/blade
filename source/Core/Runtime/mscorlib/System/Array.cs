using System.Collections;

namespace System
{
    /// <summary>
    /// The System array object.
    /// </summary>
	public abstract class Array : IEnumerable
    {
        /// <summary>
        /// Gets or sets an array item by index.
        /// </summary>
        /// <param name="index">The array index.</param>
        /// <returns>The specified array item.</returns>
        public object this[int index]
        {
            get { return null; }
            set { }
        }

        /// <summary>
        /// Gets or sets the array length.
        /// </summary>
        [ScriptField]
        public int length { get; set; }

        /// <summary>
        /// Gets the array enumerator.
        /// </summary>
        /// <returns></returns>
        IEnumerator IEnumerable.GetEnumerator()
        {
            return null;
        }
    }
}