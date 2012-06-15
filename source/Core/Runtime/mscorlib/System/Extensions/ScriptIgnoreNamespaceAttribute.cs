
namespace System
{
    /// <summary>
    /// Specifies that the namespace should be ingored when generating script.
    /// </summary>
    [Extension(
        "Blade.Compiler, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null",
        "Blade.Compiler.Extensibility.ScriptIgnoreNamespaceExtension")]
    [AttributeUsage(AttributeTargets.Assembly | AttributeTargets.Class | AttributeTargets.Interface | AttributeTargets.Struct)]
    public sealed class ScriptIgnoreNamespaceAttribute : Attribute
    {
    }
}