using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;

namespace Blade.Utilities.Interop.Cci
{
    /// <summary>
    /// Runtime assembly loader for embedded CCI dependencies.
    /// </summary>
    internal static class CciAssemblyResolver
    {
        private static volatile Dictionary<string, Assembly> _cachedAssemblies;

        /// <summary>
        /// Applies the assembly resolver procedure.
        /// </summary>
        static CciAssemblyResolver()
        {
            _cachedAssemblies = new Dictionary<string, Assembly>();

            AppDomain.CurrentDomain.AssemblyResolve += (sender, args) =>
            {
                if (_cachedAssemblies.ContainsKey(args.Name))
                    return _cachedAssemblies[args.Name];

                var name = new System.Reflection.AssemblyName(args.Name).Name;

                using (var stream = Assembly.GetExecutingAssembly()
                    .GetManifestResourceStream(name))
                {
                    if (stream == null)
                        return null;

                    var mStream = new MemoryStream();
                    stream.CopyTo(mStream);

                    _cachedAssemblies.Add(args.Name, Assembly.Load(mStream.GetBuffer()));
                }

                return _cachedAssemblies[args.Name];
            };
        }

        /// <summary>
        /// Available only to ensure the static class constructor is invoked.
        /// </summary>
        internal static int Load = 0;
    }
}
