using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading;
using Blade.Tools.Quality.Shared;
using Blade.Tools.Quality.Hosting.Clients;
using System.Runtime.InteropServices;

namespace Blade.Tools.Quality.Hosting
{
    /// <summary>
    /// Host provider for executing tests in a browser.
    /// </summary>
    public class TestHost : ITestHostService
    {
        private Dictionary<string, TestClient> _clients;
        private ManualResetEvent _connectEvent;
        private Process[] _processes;
        private TestServer _server;


        /// <summary>
        /// Initializes the web host provider.
        /// </summary>
        public void Initialize(string webRoot)
        {
            // start the server instance
            _server = new TestServer(webRoot, this);
            _server.Start();

            // create client collection
            _clients = new Dictionary<string, TestClient>();
            _connectEvent = new ManualResetEvent(false);

            // tests always occur on index.htm for now
            var url = _server.RootUrl + "index.htm";

            // start each client process
            _processes = BrowserClient.GetAvailableClients()
                .Select(c => CreateProcess(c, url))
                .Where(p => p != null).ToArray();

            // wait for them all to connect
            WaitForClients(_processes.Length);
        }

        /// <summary>
        /// Signals the provider that testing is complete.
        /// </summary>
        public void Cleanup()
        {
            // stop the web server
            _server.Stop();

            // try to close processes
            foreach (var proc in _processes)
                CleanProcess(proc);
        }

        /// <summary>
        /// Gets a web host.
        /// </summary>
        /// <returns>A web host.</returns>
        public IEnumerable<TestClient> GetClients()
        {
            return _clients.Values;
        }

        /// <summary>
        /// Connects a new client to the host.
        /// </summary>
        /// <returns>The resulting connection data.</returns>
        public ConnectionData Connect()
        {
            var id = Guid.NewGuid().ToString("N").Substring(8, 8);

            _clients.Add(id, new TestClient());
            _connectEvent.Set();

            return new ConnectionData
            {
                ClientId = id
            };
        }

        /// <summary>
        /// Gets the next operation for a client.
        /// </summary>
        /// <param name="clientId">The client ID.</param>
        /// <returns>The operation data.</returns>
        public OperationData GetNextOp(string clientId)
        {
            var client = _clients[clientId];

            if (client.QueuedTests.Count > 0)
            {
                var test = client.QueuedTests.Peek();
                return new RunTestOperation
                {
                    Command = "RunTest",
                    ClassName = test.ClassName,
                    MethodName = test.MethodName
                };
            }

            return new WaitOperation { Command = "Wait" };
        }

        /// <summary>
        /// Marks the currently in-progress test as passed.
        /// </summary>
        /// <param name="clientId">The client ID.</param>
        public void PassTest(string clientId)
        {
            var client = _clients[clientId];
            var test = client.QueuedTests.Dequeue();

            test.Callback(new TestExecutionResult());
        }

        /// <summary>
        /// Marks the currently in-progress test as failed.
        /// </summary>
        /// <param name="clientId">The client ID.</param>
        /// <param name="errorMessage">The error message.</param>
        public void FailTest(string clientId, string errorMessage)
        {
            var client = _clients[clientId];
            var test = client.QueuedTests.Dequeue();

            if (String.IsNullOrEmpty(errorMessage))
                errorMessage = "Failure not specified.";

            test.Callback(new TestExecutionResult
            {
                ErrorMessage = errorMessage,
            });
        }

        /// <summary>
        /// Blocks until all clients are connected.
        /// </summary>
        /// <param name="count">The expected number of clients.</param>
        private void WaitForClients(int count)
        {
            while (_clients.Count < count)
            {
                if (!_connectEvent.WaitOne(30000))
                    throw new InvalidOperationException("Unable to connect to client.");

                _connectEvent.Reset();
            }
        }

        private Process CreateProcess(BrowserClient client, string url)
        {
            try
            {
                var info = new ProcessStartInfo(client.ExePath, client.Arguments + " " + url);
                info.UseShellExecute = false;

                var proc = Process.Start(info);
                var handle = WaitForWindow(proc);

                if (handle != IntPtr.Zero)
                    ShowWindowAsync(handle, 11);

                return proc;
            }
            catch
            {
                return null;
            }
        }

        private IntPtr WaitForWindow(Process proc)
        {
            try
            {
                if (proc.HasExited)
                {
                    return IntPtr.Zero;
                }

                proc.WaitForInputIdle(3000);
                return proc.MainWindowHandle;
            }
            catch (InvalidOperationException)
            {
                return IntPtr.Zero;
            }
        }

        private Process[] GetValidProcesses()
        {
            var allProcs = Process.GetProcesses();
            var output = new List<Process>();

            foreach (var proc in allProcs)
            {
                try
                {
                    if (proc.StartTime < DateTime.MaxValue &&
                        proc.MainWindowHandle != null &&
                        proc.MainWindowHandle != IntPtr.Zero)
                    {
                        output.Add(proc);
                    }
                }
                catch { continue; }
            }

            return output.OrderByDescending(p => p.StartTime).ToArray();
        }

        private void CleanProcess(Process process)
        {
            try
            {
                // close the window
                process.CloseMainWindow();
            }
            catch
            {
                // else force kill the process
                try { process.Kill(); }
                catch { }
            }
            finally
            {
                // free local resources
                process.Close();
            }
        }

        [DllImport("user32.dll")]
        private static extern bool ShowWindowAsync(IntPtr hWnd, int nCmdShow);
    }
}