using System.Web;
using System.Web.Routing;
using Blade.Tools.Quality.Web;

/// <summary>
/// Wires up pre application statup method.
/// </summary>
[assembly: PreApplicationStartMethod(typeof(WebInitializer), "Init")]

namespace Blade.Tools.Quality.Web
{
    /// <summary>
    /// The web application initializer class.
    /// </summary>
    public static class WebInitializer
    {
        /// <summary>
        /// The initializer method.
        /// </summary>
        public static void Init()
        {
            // setup service routes
            RouteTable.Routes.MapHttpRoute<HostConnectionHandler>("connect");
            RouteTable.Routes.MapHttpRoute<GetOperationHandler>("nextop");
            RouteTable.Routes.MapHttpRoute<PassTestHandler>("pass");
            RouteTable.Routes.MapHttpRoute<FailTestHandler>("fail");

            // create the web context 
            WebContext.CreateInstance();
        }
    }
}
