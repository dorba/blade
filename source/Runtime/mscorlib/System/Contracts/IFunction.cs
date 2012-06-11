//----------------------------------------------
// Blade common JS/.NET interface
//----------------------------------------------
using System.Reflection;

namespace System
{
    /// <summary>
    /// Common interface class for all functions.
    /// </summary>
    [EditorBrowsable(EditorBrowsableState.Never)]
    public interface IFunction
    {
        /// <summary>
        /// Invokes the function with a specific context.
        /// </summary>
        /// <param name="thisArg">The context to use for this.</param>
        /// <returns></returns>
		object call(object thisArg);

        /// <summary>
        /// Invokes the function with a specific context, and arguments.
        /// </summary>
        /// <param name="thisArg">The context to use for this.</param>
        /// <param name="args">The function arguments.</param>
        /// <returns></returns>
		object call(object thisArg, params object[] args);

        /// <summary>
        /// Invokes the function with a specific context.
        /// </summary>
        /// <param name="thisArg">The context to use for this.</param>
        /// <returns></returns>
		object apply(object thisArg);

        /// <summary>
        /// Invokes the function with a specific context, and arguments.
        /// </summary>
        /// <param name="thisArg">The context to use for this.</param>
        /// <param name="args">The function arguments.</param>
        /// <returns></returns>
		object apply(object thisArg, object[] args);
    }
}