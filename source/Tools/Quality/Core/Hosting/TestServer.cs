using System;
using System.ServiceModel;
using System.Threading;
using Microsoft.VisualStudio.WebHost;

namespace Blade.Tools.Quality.Hosting
{
    /// <summary>
    /// Provides an HTTP server implementation that will forward requests to a specific service.
    /// </summary>
    internal class TestServer
    {
        #region Private Fields

        private int _port;
        private string _physicalPath;
        private ITestHostService _serviceProvider;
        private ManualResetEvent _hostCloseEvent;
        private ManualResetEvent _serverStopEvent;

        #endregion

        /// <summary>
        /// Gets root URL of the test site.
        /// </summary>
        public string RootUrl
        {
            get { return "http://localhost:" + _port + "/"; }
        }

        /// <summary>
        /// Creates a new instance of the class
        /// </summary>
        /// <param name="physicalPath">The directory path to the website.</param>
        /// <param name="serviceProvider">The host service provider.</param>
        public TestServer(string physicalPath, ITestHostService serviceProvider)
        {
            _physicalPath = physicalPath;
            _serviceProvider = serviceProvider;
            _port = (int)((double)DateTime.Now.Millisecond * 56.0 + 8000.0);

            _hostCloseEvent = new ManualResetEvent(false);
            _serverStopEvent = new ManualResetEvent(false);
        }

        /// <summary>
        /// Starts the web server.
        /// </summary>
        public void Start()
        {
            new Thread(() =>
            {
                // create the cross process service
                var svcHost = new ServiceHost(_serviceProvider, new Uri("net.pipe://localhost/testhost"));
                svcHost.AddServiceEndpoint(typeof(ITestHostService), new NetNamedPipeBinding(), "");

                // service must be set to single instance mode 
                svcHost.Description.Behaviors.Find<ServiceBehaviorAttribute>()
                    .InstanceContextMode = InstanceContextMode.Single;

                // open and wait for close event
                svcHost.Open();
                _hostCloseEvent.WaitOne();
                svcHost.Close();
            }).Start();

            new Thread(() =>
            {
                // start the web server process
                var server = new Server(_port, "/", _physicalPath);

                // start and wait for cstop event
                server.Start();
                _serverStopEvent.WaitOne();
                server.Stop();
            }).Start();
        }

        /// <summary>
        /// Stops the web server.
        /// </summary>
        public void Stop()
        {
            _hostCloseEvent.Set();
            _serverStopEvent.Set();
        }
    }
}