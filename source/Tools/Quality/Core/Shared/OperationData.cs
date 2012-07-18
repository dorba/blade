using System;

namespace Blade.Tools.Quality.Shared
{
    /// <summary>
    /// The entity provided as a result of an operation request.
    /// </summary>
    [ScriptObjectLiteral]
    public abstract class OperationData
    {
        /// <summary>
        /// The operation command.
        /// </summary>
        public string Command { get; set; }
    }
}
