using System;

// Note: these attributes are targeted by the
// test framework to identify test methods.
// These must have the same full name as those expected
// in the regular .NET unit test framework assembly.

namespace Microsoft.VisualStudio.TestTools.UnitTesting
{
    /// <summary>
    /// Indicates that a method is a test method.
    /// </summary>
    [ScriptExternal]
    [AttributeUsage(AttributeTargets.Method, AllowMultiple = false)]
    public class TestMethodAttribute : Attribute
    {
    }
}