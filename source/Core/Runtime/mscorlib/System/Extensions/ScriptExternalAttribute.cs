
namespace System
{
    /// <summary>
    /// Specifies that a target is defined externally.
    /// No script will be rendered for the declaration.
    /// </summary>
    [Extension(
        "Blade.Compiler, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null",
        "Blade.Compiler.Extensibility.ScriptExternalExtension")]
    [AttributeUsage(AttributeTargets.Assembly | AttributeTargets.Class | AttributeTargets.Event |
        AttributeTargets.Field | AttributeTargets.Method | AttributeTargets.Property | AttributeTargets.Struct)]
    public sealed class ScriptExternalAttribute : Attribute
    {
    }
}