
namespace System.Reflection
{
    /// <summary>
    /// Specifies whether a property or event should be displayed in a Properties window.
    /// </summary>
    [AttributeUsage((AttributeTargets)960, Inherited = true, AllowMultiple = false)]
    public sealed class BrowsableAttribute : Attribute
    {
        /// <summary>
        /// Initializes a new instance of the class.
        /// </summary>
        /// <param name="browsable">True if the item is browsable, false otherwise.</param>
        public BrowsableAttribute(bool browsable) { }
    }
}


