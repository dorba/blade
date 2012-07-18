using System;

namespace Microsoft.VisualStudio.TestTools.UnitTesting
{
    /// <summary>
    /// Provides a safe use proxy for the browser console.
    /// </summary>
    [ScriptNamespace("Blade")]
    public static class ConsoleProxy
    {
        /// <summary>
        /// Clears all data from the console.
        /// </summary>
        public static void clear()
        {
            if (CanCall("clear"))
                console.clear();
        }

        /// <summary>
        /// Writes a log message to the console.
        /// </summary>
        /// <param name="message">The value to write.</param>
        public static void log(object message)
        {
            if (CanCall("log"))
                console.log(message);
        }

        /// <summary>
        /// Writes an informational message to the console.
        /// </summary>
        /// <param name="message">The value to write.</param>
        public static void info(object message)
        {
            if (CanCall("info"))
                console.info(message);
        }

        /// <summary>
        /// Writes a warning message to the console.
        /// </summary>
        /// <param name="message">The value to write.</param>
        public static void warn(object message)
        {
            if (CanCall("warn"))
                console.warn(message);
        }

        /// <summary>
        /// Writes an error message to the console.
        /// </summary>
        /// <param name="message">The value to write.</param>
        public static void error(object message)
        {
            if (CanCall("error"))
                console.error(message);
        }

        private static bool CanCall(string func)
        {
            return ((dynamic)window.self["console"] &&
                (window.self["console"][func] is Function));
        }
    }
}