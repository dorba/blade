using System;
using Microsoft.Cci;

namespace Blade.Utilities.Interop.Cci
{
    /// <summary>
    /// Wraps the CCI metadata host object.
    /// </summary>
    internal sealed class CciAssemblyLoader : IDisposable
    {
        private int _load = CciAssemblyResolver.Load;

        // this must be of type object, 
        // otherwise the library may not load,
        // due to use of indirect CCI references
        private object _host;

        /// <summary>
        /// Creates a new instance of the class.
        /// </summary>
        public CciAssemblyLoader()
        {
            _host = new Microsoft.Cci.PeReader.DefaultHost();
        }

        /// <summary>
        /// Loads an assembly.
        /// </summary>
        /// <param name="path">The file path.</param>
        /// <returns>The resulting assembly.</returns>
        public object LoadFrom(string path)
        {
            return ((Microsoft.Cci.PeReader.DefaultHost)_host).LoadUnitFrom(path);
        }

        /// <summary>
        /// Disposes of the underlying PE reader.
        /// </summary>
        public void Dispose()
        {
            ((Microsoft.Cci.PeReader.DefaultHost)_host).Dispose();
        }
    }
}
