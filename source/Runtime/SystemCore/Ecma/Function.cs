//----------------------------------------------
// ECMA core object
//----------------------------------------------

namespace System
{
    /// <summary>
    /// Represents the ECMA Function object.
    /// </summary>
	public sealed class Function : IFunction
    {
        /// <summary>
        /// Creates a new function from string arguments.
        /// </summary>
        /// <param name="args">The function parameters and body text.</param>
        public Function(params string[] args) { }

        /// <summary>
        /// Invokes the function with a specific context.
        /// </summary>
        /// <param name="thisArg">The context to use for this.</param>
        /// <returns>The result of the invoked function.</returns>
        public object call(object thisArg) { return null; }

        /// <summary>
        /// Invokes the function with a specific context, and arguments.
        /// </summary>
        /// <param name="thisArg">The context to use for this.</param>
        /// <param name="args">The function arguments.</param>
        /// <returns>The result of the invoked function.</returns>
        public object call(object thisArg, params object[] args) { return null; }

        /// <summary>
        /// Invokes the function with a specific context.
        /// </summary>
        /// <param name="thisArg">The context to use for this.</param>
        /// <returns>The result of the invoked function.</returns>
        public object apply(object thisArg) { return null; }

        /// <summary>
        /// Invokes the function with a specific context, and arguments.
        /// </summary>
        /// <param name="thisArg">The context to use for this.</param>
        /// <param name="args">The function arguments.</param>
        /// <returns>The result of the invoked function.</returns>
        public object apply(object thisArg, object[] args) { return null; }
    }
}