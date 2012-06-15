
namespace System
{
    /// <summary>
    /// The system Object which all other types inherit from.
    /// </summary>
    public class Object
    {
        /// <summary>
        /// Gets a string representation of the object.
        /// </summary>
        /// <returns>A string value.</returns>
        public virtual string toString() { return null; }

        /// <summary>
        /// Gets a string representation of the object, using locale conventions.
        /// </summary>
        /// <returns>A string value.</returns>
        public string toLocaleString() { return null; }
    }
}