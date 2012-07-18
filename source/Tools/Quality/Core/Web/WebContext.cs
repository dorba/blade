using System;
using System.ServiceModel;
using Blade.Tools.Quality.Hosting;

namespace Blade.Tools.Quality.Web
{
    /// <summary>
    /// Maintains state for the web server.
    /// </summary>
    public class WebContext
    {
        private static volatile WebContext _instance;
        private static object _lock = new object();

        private ChannelFactory<ITestHostService> _channelFactory;
        private ITestHostService _testHost;

        /// <summary>
        /// Gets the singleton context instance.
        /// </summary>
        public static WebContext Instance
        {
            get { return _instance; }
        }

        /// <summary>
        /// Gets the test host.
        /// </summary>
        public ITestHostService TestHost
        {
            get
            {
                if (_testHost == null)
                {
                    if (_channelFactory == null)
                        throw new InvalidOperationException("Channel factory is not valid.");

                    _testHost = _channelFactory.CreateChannel();
                }

                return _testHost;
            }
        }

        /// <summary>
        /// Creates the web context instance.
        /// </summary>
        internal static void CreateInstance()
        {
            lock (_lock)
            {
                if (_instance != null)
                    throw new InvalidOperationException("WebContext instance already exists.");

                _instance = new WebContext();
                _instance._channelFactory = new ChannelFactory<ITestHostService>(
                    new NetNamedPipeBinding(), new EndpointAddress("net.pipe://localhost/testhost"));
            }
        }
    }
}
