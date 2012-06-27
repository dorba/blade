
namespace System
{
    /// <summary>
    /// Specifies that a class will render no declaration,
    /// and instead render in object literal notation for
    /// each instantiation of the class.
    /// </summary>
    [Extension(
        "Blade.Compiler, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null",
        "Blade.Compiler.Extensibility.ScriptObjectLiteralExtension")]
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct)]
    public sealed class ScriptObjectLiteralAttribute : Attribute
    {
    }
}