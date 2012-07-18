using System;
using System.Web;

namespace Blade.Tools.Quality.Web
{
    /// <summary>
    /// Handles requests to mark a test as passed.
    /// </summary>
    internal class PassTestHandler : HttpHandler
    {
        /// <summary>
        /// Gets the operation data.
        /// </summary>
        /// <param name="context">The HTTP context.</param>
        /// <returns>The host response.</returns>
        protected override object GetData(HttpContext context)
        {
            var clientId = context.Request.QueryString["clientId"];

            if (!String.IsNullOrEmpty(clientId))
            {
                WebContext.Instance.TestHost.PassTest(clientId);
            }

            return null;
        }
    }
}
