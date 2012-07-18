using System;
using System.Browser;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Blade.Tools.Quality.Host
{
    /// <summary>
    /// The client side host, responsible
    /// for communication with the server.
    /// </summary>
    [ScriptNamespace("Blade")]
    internal static class ClientHost
    {
        /// <summary>
        /// The singleton service proxy instance.
        /// </summary>
        public static ServiceProxy Service;

        static ClientHost()
        {
            // some clients seem to have trouble
            // working with an immediate init call
            // work around for now a delay
            window.setTimeout((Action)init, 1000);
        }

        /// <summary>
        /// Initializes the host.
        /// </summary>
        public static void init()
        {
            // create service proxy and connect
            var baseUrl = "http://localhost:" + location.port;
            Service = new ServiceProxy(baseUrl);

            ConsoleProxy.log("Connecting to " + baseUrl);
            Connect();
        }

        private static void Connect()
        {
            Service.Connect(() =>
            {
                GetNextOp();
            });
        }

        private static void GetNextOp()
        {
            Service.GetNextOp((op) =>
            {
                if ((dynamic)op)
                {
                    OperationHandler.HandleOp(op, GetNextOp);
                }
            });
        }
    }
}