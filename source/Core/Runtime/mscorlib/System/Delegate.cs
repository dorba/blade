
namespace System
{
    /// <summary>
    /// The System Delegate class.
    /// </summary>
    public abstract class Delegate : IFunction
    {
        /// <summary>
        /// Invokes the function with a specific context.
        /// </summary>
        /// <param name="thisArg">The context to use for this.</param>
        /// <returns></returns>
        public object call(object thisArg) { return null; }

        /// <summary>
        /// Invokes the function with a specific context, and arguments.
        /// </summary>
        /// <param name="thisArg">The context to use for this.</param>
        /// <param name="args">The function arguments.</param>
        /// <returns></returns>
        public object call(object thisArg, params object[] args) { return null; }

        /// <summary>
        /// Invokes the function with a specific context.
        /// </summary>
        /// <param name="thisArg">The context to use for this.</param>
        /// <returns></returns>
        public object apply(object thisArg) { return null; }

        /// <summary>
        /// Invokes the function with a specific context, and arguments.
        /// </summary>
        /// <param name="thisArg">The context to use for this.</param>
        /// <param name="args">The function arguments.</param>
        /// <returns></returns>
        public object apply(object thisArg, object[] args) { return null; }

        public static Delegate Combine(Delegate a, Delegate b) { return null; }
        public static Delegate Combine(params Delegate[] delegates) { return null; }
        public static Delegate Remove(Delegate source, Delegate value) { return null; }
    }
}


