using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Microsoft.Win32;

namespace Blade.Tools.Quality.Hosting.Clients
{
    /// <summary>
    /// Base for any browser.
    /// </summary>
    internal abstract class BrowserClient
    {
        private string _cachedExePath;

        /// <summary>
        /// Gets the name of the browser.
        /// </summary>
        public abstract string Name { get; }

        /// <summary>
        /// Gets the process start args.
        /// </summary>
        public virtual string Arguments
        {
            get { return ""; }
        }

        /// <summary>
        /// Gets the executable file name.
        /// </summary>
        public abstract string ExeName { get; }

        /// <summary>
        /// Gets the default install path.
        /// </summary>
        public abstract string DefaultPath { get; }

        /// <summary>
        /// Gets a value indicating if the path can be located.
        /// </summary>
        public bool IsAvailable
        {
            get { return !String.IsNullOrEmpty(ExePath); }
        }

        /// <summary>
        /// Gets the executable path.
        /// </summary>
        public string ExePath
        {
            get
            {
                if (_cachedExePath == null)
                {
                    // try the most common path
                    if (File.Exists(DefaultPath))
                    {
                        _cachedExePath = DefaultPath;
                        return _cachedExePath;
                    }

                    // try the app path registry
                    var appPath = Registry.LocalMachine.GetValue(@"Microsoft\Windows\CurrentVersion\App Paths\" + ExeName, "").ToString();

                    if (File.Exists(appPath))
                    {
                        _cachedExePath = appPath;
                        return _cachedExePath;
                    }
                }

                return _cachedExePath;
            }
        }

        // static list of all known clients
        private static BrowserClient[] Clients = new BrowserClient[] {
            new IExplorerClient(),
            new FirefoxClient(),
            new ChromeClient()
        };

        /// <summary>
        /// Gets all available clients for this machine.
        /// </summary>
        internal static IEnumerable<BrowserClient> GetAvailableClients()
        {
            return Clients.Where(c => c.IsAvailable);
        }
    }
}
