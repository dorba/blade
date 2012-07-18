using System;

namespace Blade.Tools.Quality.Shared
{
    /// <summary>
    /// Represents the run test operation data.
    /// </summary>
    [ScriptObjectLiteral]
    public class RunTestOperation : OperationData
    {
        /// <summary>
        /// The full name of the class to test.
        /// </summary>
        public string ClassName { get; set; }

        /// <summary>
        /// The method name to test.
        /// </summary>
        public string MethodName { get; set; }
    }
}
