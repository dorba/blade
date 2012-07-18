using System.Web;
using Blade.Tools.Quality.Shared;

namespace Blade.Tools.Quality.Web
{
    /// <summary>
    /// Handles requests for a host connection.
    /// </summary>
    internal class HostConnectionHandler : HttpDataHandler<ConnectionData>
    {
        /// <summary>
        /// Gets the connection data.
        /// </summary>
        /// <param name="context">The HTTP context.</param>
        /// <returns>The host response.</returns>
        protected override DataObject<ConnectionData> GetDataObject(HttpContext context)
        {
            return new DataObject<ConnectionData>
            {
                Data = WebContext.Instance.TestHost.Connect()
            };
        }
    }
}
