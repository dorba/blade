
namespace System
{
    /// <summary>
    /// Specifies that an extension method will render as an add-on to the objects prototype,
    /// instead of a separate function in a utility class.
    /// </summary>
    [Extension(
        "Blade.Compiler, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null",
        "Blade.Compiler.Extensibility.ScriptMixinExtension")]
    [AttributeUsage(AttributeTargets.Method)]
    public sealed class ScriptMixinAttribute : Attribute
    {
    }
}