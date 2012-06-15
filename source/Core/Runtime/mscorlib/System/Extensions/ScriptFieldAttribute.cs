
namespace System
{
    /// <summary>
    /// Specifies that a property should render as a field in script.
    /// </summary>
    [Extension(
        "Blade.Compiler, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null",
        "Blade.Compiler.Extensibility.ScriptFieldExtension")]
    [AttributeUsage(AttributeTargets.Property)]
    public sealed class ScriptFieldAttribute : Attribute
    {
    }
}