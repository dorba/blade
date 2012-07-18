using System.Web;
using Blade.Tools.Quality.Shared;

namespace Blade.Tools.Quality.Web
{
    /// <summary>
    /// The base implementation for all class that will response with data object.
    /// </summary>
    /// <typeparam name="T">The inner data type.</typeparam>
    internal abstract class HttpDataHandler<T> : HttpHandler
        where T : class
    {
        /// <summary>
        /// Gets the data object.
        /// </summary>
        /// <param name="context">The HTTP context.</param>
        /// <returns>The host response.</returns>
        protected abstract DataObject<T> GetDataObject(HttpContext context);

        /// <summary>
        /// Gets the data object.
        /// </summary>
        /// <param name="context">The HTTP context.</param>
        /// <returns>The host response.</returns>
        protected override object GetData(HttpContext context)
        {
            return GetDataObject(context);
        }
    }
}
