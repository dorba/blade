using System;

namespace Blade.Tools.Quality.Hosting
{
    /// <summary>
    /// Represents the details of a test run request.
    /// </summary>
    public sealed class TestExecutionRequest
    {
        /// <summary>
        /// Gets or sets the full name of the class containing the test.
        /// </summary>
        public string ClassName { get; set; }

        /// <summary>
        /// Gets or sets the test method name.
        /// </summary>
        public string MethodName { get; set; }

        /// <summary>
        /// Gets or sets the callback to invoke once the test completes.
        /// </summary>
        public Action<TestExecutionResult> Callback { get; set; }
    }
}