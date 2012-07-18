using System;
using System.Web;

namespace Blade.Tools.Quality.Web
{
    /// <summary>
    /// Handles requests to mark a test as failed.
    /// </summary>
    internal class FailTestHandler : HttpHandler
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
                var errorMsg = context.Request.QueryString["errorMsg"];
                WebContext.Instance.TestHost.FailTest(clientId, errorMsg);
            }

            return null;
        }
    }
}
