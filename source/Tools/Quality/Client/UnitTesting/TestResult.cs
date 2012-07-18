using System;

namespace Microsoft.VisualStudio.TestTools.UnitTesting
{
    /// <summary>
    /// Represents the result of an individual test method.
    /// </summary>
    [ScriptNamespace("Blade")]
    public sealed class TestResult
    {
        /// <summary>
        /// Gets a value indicating if the test is complete.
        /// </summary>
        public bool IsComplete { get; set; }

        /// <summary>
        /// Gets the error message, or null if the test passed.
        /// </summary>
        public string ErrorMessage { get; set; }
    }
}