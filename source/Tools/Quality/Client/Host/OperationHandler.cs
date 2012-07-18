using System;
using Blade.Tools.Quality.Shared;

namespace Blade.Tools.Quality.Host
{
    /// <summary>
    /// The static operation handler, which picks the correct handler instance.
    /// </summary>
    [ScriptNamespace("Blade")]
    internal static class OperationHandler
    {
        /// <summary>
        /// Routes the operation to the correct handler, based on the command.
        /// </summary>
        /// <param name="op">The operation data.</param>
        /// <param name="done">The completion callback.</param>
        public static void HandleOp(OperationData op, Action done)
        {
            if (!(dynamic)op || !(dynamic)op.Command)
                return;

            IOperationHandler handler = null;

            switch (op.Command)
            {
                case "RunTest": handler = new RunTestHandler();
                    break;

                case "Wait": handler = new WaitHandler();
                    break;

                default:
                    throw new Error("Unexpected command: " + op.Command);
            }

            if (handler != null)
                handler.HandleOp(op, done);
            else done();
        }
    }
}