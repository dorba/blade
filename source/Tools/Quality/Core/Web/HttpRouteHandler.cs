using System.Web.Routing;

namespace Blade.Tools.Quality.Web
{
    /// <summary>
    /// A generic route handler that can instantiate a http handler and pass it route parameters.
    /// </summary>
    internal class HttpRouteHandler<T> : IRouteHandler where T : HttpHandler, new()
    {
        /// <summary>
        /// Gets the HTTP handler.
        /// </summary>
        /// <param name="requestContext">The routing request context.</param>
        /// <returns></returns>
        public System.Web.IHttpHandler GetHttpHandler(RequestContext requestContext)
        {
            var handler = new T();
            handler.RouteValues = requestContext.RouteData.Values;
            return handler;
        }
    }
}
