using System.Web.Routing;

namespace Blade.Tools.Quality.Web
{
    /// <summary>
    /// Extension methods to the route collection class.
    /// </summary>
    internal static class RouteCollectionExtensions
    {
        /// <summary>
        /// Creats a data route using the specified handler.
        /// </summary>
        /// <typeparam name="T">The handler type.</typeparam>
        /// <param name="routes">The routes context.</param>
        /// <param name="path">The route path.</param>
        public static void MapHttpRoute<T>(this RouteCollection routes, string path)
            where T : HttpHandler, new()
        {
            var routeHandler = new HttpRouteHandler<T>();
            routes.Add(path, new Route(path, routeHandler));
        }
    }
}
