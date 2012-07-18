using System;
using Blade.Tools.Quality.Shared;

namespace Blade.Tools.Quality.Host
{
    /// <summary>
    /// Service contract for operation handlers.
    /// </summary>
    [ScriptNamespace("Blade")]
    internal interface IOperationHandler
    {
        /// <summary>
        /// Handles the operation.
        /// </summary>
        /// <param name="op">The operation data.</param>
        /// <param name="done">The completion callback.</param>
        void HandleOp(OperationData op, Action done);
    }
}