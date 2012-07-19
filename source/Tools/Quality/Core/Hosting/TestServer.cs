using System;
using System.Diagnostics;
using System.IO;
using System.ServiceModel;
using System.Threading;

namespace Blade.Tools.Quality.Hosting
{
    /// <summary>
    /// Provides an HTTP server implementation that will forward requests to a specific service.
    /// </summary>
    internal class TestServer
    {
        private int _port;
        private Process _webDev;
        private ServiceHost _svcHost;
        private string _physicalPath;
        private ITestHostService _serviceProvider;
        private ManualResetEvent _stopEvent;

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
            _stopEvent = new ManualResetEvent(false);
        }

        /// <summary>
        /// Starts the web server.
        /// </summary>
        public void Start()
        {
            new Thread(() =>
            {
                // create the cross process service
                _svcHost = new ServiceHost(_serviceProvider, new Uri("net.pipe://localhost/testhost"));
                _svcHost.AddServiceEndpoint(typeof(ITestHostService), new NetNamedPipeBinding(), "");

                // service must be set to single instance mode 
                _svcHost.Description.Behaviors.Find<ServiceBehaviorAttribute>()
                    .InstanceContextMode = InstanceContextMode.Single;

                _svcHost.Open();
                _stopEvent.WaitOne();
                _svcHost.Close();
            }).Start();

            // start the webdav web server process
            _webDev = Process.Start(GetWebDevPath(), "/port:" + _port + " /path:\"" + _physicalPath + "\"");
        }

        /// <summary>
        /// Stops the web server.
        /// </summary>
        public void Stop()
        {
            // stop the webdev server
            StopWebDev();

            // close the WCF connection
            _stopEvent.Set();
        }

        #region Helper Methods

        private const string WebDevPath = @"Common Files\microsoft shared\DevServer\10.0\WebDev.WebServer40.EXE";

        private string GetWebDevPath()
        {
            var progFilesX86 = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86);

            if (String.IsNullOrEmpty(progFilesX86))
                throw new DirectoryNotFoundException("Unable to location program files directory.");

            var fullPath = Path.Combine(progFilesX86, WebDevPath);

            if (!File.Exists(fullPath))
                throw new FileNotFoundException("Unable to locate WebDev Web Server executable.");

            return fullPath;
        }

        private void StopWebDev()
        {
            if (_webDev == null || _webDev.HasExited)
                return;

            // the process only closes with by forcing it
            try { _webDev.Kill(); }
            finally
            {
                // this only cleans up local
                // resources for the object
                _webDev.Close();

                // this repaints the system tray so that
                // server icons don't build up on each test run
                // SysTrayCleaner.Cleanup();
            }
        }

        #endregion
    }
}