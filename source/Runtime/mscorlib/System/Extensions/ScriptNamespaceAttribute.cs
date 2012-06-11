
namespace System
{
    /// <summary>
    /// Specifies that a target should use an alternate namespace in script.
    /// </summary>
    [Extension(
        "Blade.Compiler, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null",
        "Blade.Compiler.Extensibility.ScriptNamespaceExtension")]
    [AttributeUsage(AttributeTargets.Assembly | AttributeTargets.Class | AttributeTargets.Struct)]
    public sealed class ScriptNamespaceAttribute : Attribute
    {
        /// <summary>
        /// Creates a new instance of the attribute.
        /// </summary>
        /// <param name="name">The namespace name to use in script.</param>
        public ScriptNamespaceAttribute(string name)
        {
        }
    }
}