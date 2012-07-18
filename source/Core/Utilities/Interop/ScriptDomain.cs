using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Blade.Utilities.Interop.Cci;
using Microsoft.Cci;

namespace Blade.Utilities.Interop
{
    /// <summary>
    /// Provides an application domain for use with assemblies generated for the Blade framework.
    /// </summary>
    public sealed class ScriptDomain : IDisposable
    {
        #region Private Fields

        // this ensures the CCI assembly resolver is
        // setup before we attempt to use any CCI types
        private int _load = CciAssemblyResolver.Load;

        private static volatile ScriptDomain
            _instance = new ScriptDomain();

        private List<string> _searchDirs;
        private List<ScriptAssembly> _assemblies;
        private CciAssemblyLoader _loader;

        #endregion

        /// <summary>
        /// Gets the current Blade application domain.
        /// </summary>
        public static ScriptDomain CurrentDomain
        {
            get { return _instance; }
        }

        // no default ctor
        private ScriptDomain()
        {
            _assemblies = new List<ScriptAssembly>();
            _loader = new CciAssemblyLoader();
            _searchDirs = new List<string>();
        }

        /// <summary>
        /// Loads an assembly from a file on disk.
        /// </summary>
        /// <param name="path">The file path.</param>
        /// <returns>The loaded assembly.</returns>
        public ScriptAssembly LoadAssembly(string path)
        {
            if (!File.Exists(path))
                throw new FileNotFoundException();

            return LoadAssembly(_loader.LoadFrom(path) as IAssembly);
        }

        /// <summary>
        /// Gets an assembly by ID.
        /// </summary>
        /// <param name="id">The assembly ID.</param>
        /// <returns>The matching assembly.</returns>
        public ScriptAssembly GetAssembly(string id)
        {
            return _assemblies.SingleOrDefault(a => a.Id == id);
        }

        /// <summary>
        /// Gets all assemblies loaded in the domain.
        /// </summary>
        /// <returns>All loaded assemblies.</returns>
        public IEnumerable<ScriptAssembly> GetAssemblies()
        {
            return _assemblies;
        }

        /// <summary>
        /// Resolves a type reference from the assembly and type names.
        /// </summary>
        /// <param name="assemblyName">The assembly name.</param>
        /// <param name="typeName">The type name.</param>
        /// <returns>The resolved type, or null if one was not found.</returns>
        public ScriptType ResolveType(string assemblyName, string typeName)
        {
            var assembly = _assemblies.SingleOrDefault(a =>
                a.Name.Equals(assemblyName, StringComparison.OrdinalIgnoreCase));

            if (assembly == null)
                return null;

            return assembly.Types.SingleOrDefault(t =>
                t.Name.Equals(typeName, StringComparison.OrdinalIgnoreCase));
        }

        /// <summary>
        /// Adds a search path used to resolve assembly references.
        /// </summary>
        /// <param name="dir">The directory path.</param>
        public void AddSearchDirectory(string dir)
        {
            if (String.IsNullOrEmpty(dir))
                return;

            dir = dir.TrimEnd('\\');

            if (_searchDirs.Any(d => d.Equals(dir, StringComparison.OrdinalIgnoreCase)))
                return;

            _searchDirs.Add(dir);
        }

        /// <summary>
        /// Disposes of the app domain.
        /// </summary>
        void IDisposable.Dispose()
        {
            _loader.Dispose();
        }

        /// <summary>
        /// Loads an assembly from its CCI identity.
        /// </summary>
        /// <param name="identity">The identity.</param>
        /// <param name="container">The referencing assembly.</param>
        /// <returns>The loaded assembly.</returns>
        internal ScriptAssembly LoadAssembly(AssemblyIdentity identity, IAssembly container = null)
        {
            if (identity == null)
                throw new InvalidOperationException();

            var asmPath = identity.Location;

            if (String.IsNullOrEmpty(asmPath))
            {
                // use any custom search directories
                var searchDirs = new List<string>(_searchDirs);

                // also if applicable include the referencing assembly directory
                if (container != null && !String.IsNullOrEmpty(container.Location))
                    searchDirs.Add(Path.GetDirectoryName(container.Location));

                asmPath = ResolveFilePath(identity.Name.Value + ".dll", searchDirs);

                if (!File.Exists(asmPath))
                    throw new InvalidOperationException();
            }

            return LoadAssembly(_loader.LoadFrom(asmPath) as IAssembly);
        }

        /// <summary>
        /// Resolves a type from its CCI type reference.
        /// </summary>
        /// <param name="typeRef">The type reference.</param>
        /// <returns>The resolved type, or null if one is not found.</returns>
        internal ScriptType ResolveType(ITypeReference typeRef)
        {
            foreach (var asm in _assemblies)
            {
                foreach (var type in asm.Types)
                {
                    if (type.Equals(typeRef))
                        return type;
                }
            }

            return null;
        }

        #region Helper Methods

        // load assembly from CCI assembly inteface
        private ScriptAssembly LoadAssembly(IAssembly assembly)
        {
            if (assembly == null)
                throw new InvalidOperationException();

            if (String.IsNullOrEmpty(assembly.Location))
                throw new InvalidOperationException();

            var target = new ScriptAssembly(this, assembly);
            var existing = _assemblies.SingleOrDefault(a => a.Equals(target));

            if (existing != null)
                return existing;

            _assemblies.Add(target);
            LoadDependencies(assembly);

            return target;
        }

        // load all referenced assemblies from CCI interface
        private void LoadDependencies(IAssembly assembly)
        {
            foreach (var item in assembly.AssemblyReferences)
            {
                LoadAssembly(item.AssemblyIdentity, assembly);
            }
        }

        // finds a valid file path, from a list of search directories
        private string ResolveFilePath(string name, IEnumerable<string> searchDirs)
        {
            foreach (var dir in searchDirs)
            {
                var path = Path.Combine(dir, name);
                if (File.Exists(path))
                    return path;
            }

            return null;
        }

        #endregion
    }
}
