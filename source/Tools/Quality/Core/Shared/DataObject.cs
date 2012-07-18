using System;

namespace Blade.Tools.Quality.Shared
{
    /// <summary>
    /// Represents the base contract for a data object.
    /// </summary>
    /// <typeparam name="T">The internal data type.</typeparam>
    [ScriptObjectLiteral]
    public class DataObject<T>
        where T : class
    {
        /// <summary>
        /// The internal data.
        /// </summary>
        public T Data { get; set; }
    }
}
