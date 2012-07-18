using System;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Routing;
using System.Web.Script.Serialization;
using Blade.Tools.Quality.Shared;

namespace Blade.Tools.Quality.Web
{
    /// <summary>
    /// Inherit from this class to easily handle requests coming through the routing engine with the GenericRouteHandler.
    /// </summary>
    internal abstract class HttpHandler : IHttpHandler
    {
        private static object _lock = new object();

        /// <summary>
        /// Gets or sets the route values.
        /// </summary>
        public RouteValueDictionary RouteValues { get; set; }

        /// <summary>
        /// Gets a value indicating whether or not the handler is reusable.
        /// </summary>
        public bool IsReusable
        {
            get { return false; }
        }

        /// <summary>
        /// Processes the HTTP request.
        /// </summary>
        /// <param name="context">The HTTP context.</param>
        public void ProcessRequest(HttpContext context)
        {
            lock (_lock) // force single threaded request execution
            {
                var buffer = GetBuffer(context);
                var eTag = GenerateETag(buffer, DateTime.Now);

                // content setup
                context.Response.ContentType = "application/json";
                context.Response.AddHeader("Content-Length", buffer.Length.ToString());
                context.Response.ContentEncoding = Encoding.UTF8;

                // caching setup
                context.Response.Cache.SetCacheability(System.Web.HttpCacheability.NoCache);
                context.Response.Cache.SetETag(eTag);

                // write output
                context.Response.OutputStream.Write(buffer, 0, buffer.Length);
                context.Response.Flush();
            }
        }

        /// <summary>
        /// Gets the resulting response data.
        /// </summary>
        /// <param name="context">The HTTP context.</param>
        /// <returns>The data object.</returns>
        protected abstract object GetData(HttpContext context);

        #region Helper Methods

        private byte[] GetBuffer(HttpContext context)
        {
            var data = GetData(context);

            if (data == null)
                data = new DataObject<object>();

            // serialize object to JSON
            return Encoding.UTF8.GetBytes((
                new JavaScriptSerializer()).Serialize(data));
        }

        // generates an eTag base on buffer and date/time
        private static string GenerateETag(byte[] buffer, DateTime time)
        {
            byte[] localBuffer;

            if (buffer.Length < 64)
                localBuffer = Enumerable.Repeat<byte>(0, 64).ToArray();
            else
            {
                localBuffer = new byte[64];
                Array.Copy(buffer, localBuffer, 64);
            }

            BitConverter.GetBytes(time.ToBinary()).CopyTo(localBuffer, 0);

            var md5 = System.Security.Cryptography.MD5CryptoServiceProvider.Create();
            return "\"" + BitConverter.ToString(md5.ComputeHash(localBuffer)).Replace("-", "") + "\"";
        }

        #endregion
    }
}
