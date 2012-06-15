
namespace System
{
    /// <summary>
    /// Specifies type bindings between script and .NET framework, for
    /// use when defining custom build extensions attributes.
    /// </summary>
    [AttributeUsage(AttributeTargets.Class)]
    public sealed class ExtensionAttribute : Attribute
    {
        /// <summary>
        /// Creates a new instance of the attribute.
        /// </summary>
        /// <param name="assemblyName">The qualified assembly name.</param>
        /// <param name="typeName">The full type name.</param>
        public ExtensionAttribute(string assemblyName, string typeName)
        {
        }
    }
}