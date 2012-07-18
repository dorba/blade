using System;

// Note: these attributes are targeted by the
// test framework to identify test methods.
// These must have the same full name as those expected
// in the regular .NET unit test framework assembly.

namespace Microsoft.VisualStudio.TestTools.UnitTesting
{
    /// <summary>
    /// Indicates that a class may contain test methods.
    /// </summary>
    [ScriptExternal]
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = false)]
    public class TestClassAttribute : Attribute
    {
    }
}