
namespace System.Reflection
{
    /// <summary>
    /// Specifies that a property or method is viewable in an editor.
    /// </summary>
    [AttributeUsage((AttributeTargets)6140)]
    public sealed class EditorBrowsableAttribute : Attribute
    {
        /// <summary>
        /// Creates a new instance of the class.
        /// </summary>
        /// <param name="state">The editor browsable state.</param>
        public EditorBrowsableAttribute(EditorBrowsableState state) { }
    }
}


