
namespace System
{
    /// <summary>
    /// Marks the program elements that are no longer in use.
    /// </summary>
    [AttributeUsageAttribute(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Enum | AttributeTargets.Constructor | AttributeTargets.Method |
        AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Interface | AttributeTargets.Delegate, Inherited = false)]
    public class ObsoleteAttribute : Attribute
    {
        /// <summary>
        /// Initializes a new instance of the class.
        /// </summary>
        public ObsoleteAttribute() { }

        /// <summary>
        /// Initializes a new instance of the class.
        /// </summary>
        /// <param name="message">The compiler message.</param>
        public ObsoleteAttribute(string message) { }

        /// <summary>
        /// Initializes a new instance of the class.
        /// </summary>
        /// <param name="message">The compiler message.</param>
        /// <param name="isError">True to throw an error.</param>
        public ObsoleteAttribute(string message, bool isError) { }
    }
}