using System;
using Blade.Tools.Quality.Shared;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Blade.Tools.Quality.Host
{
    /// <summary>
    /// Handles the wait command.
    /// </summary>
    [ScriptNamespace("Blade")]
    internal class WaitHandler : IOperationHandler
    {
        /// <summary>
        /// Waits for a short period.
        /// </summary>
        /// <param name="op">The operation data.</param>
        /// <param name="done">The completion callback.</param>
        public void HandleOp(OperationData op, Action done)
        {
            ConsoleProxy.log("Waiting...");
            window.setTimeout(done, 1500);
        }
    }
}