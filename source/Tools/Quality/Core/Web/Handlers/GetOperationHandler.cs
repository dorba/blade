using System;
using System.Web;
using Blade.Tools.Quality.Shared;

namespace Blade.Tools.Quality.Web
{
    /// <summary>
    /// Handles requests for the next client operation.
    /// </summary>
    internal class GetOperationHandler : HttpDataHandler<OperationData>
    {
        /// <summary>
        /// Gets the operation data.
        /// </summary>
        /// <param name="context">The HTTP context.</param>
        /// <returns>The host response.</returns>
        protected override DataObject<OperationData> GetDataObject(HttpContext context)
        {
            var clientId = context.Request.QueryString["clientId"];

            if (String.IsNullOrEmpty(clientId))
                return null;

            return new DataObject<OperationData>
            {
                Data = WebContext.Instance.TestHost.GetNextOp(clientId)
            };
        }
    }
}
