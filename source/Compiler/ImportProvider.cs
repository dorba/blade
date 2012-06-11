using System.Collections.Generic;
using System.ComponentModel.Composition.Hosting;
using System.Linq;
using System.Reflection;

namespace Blade.Compiler
{
    /// <summary>
    /// Internal helper class for resolving imported classes.
    /// </summary>
    /// <typeparam name="T">The imported type.</typeparam>
    internal class ImportProvider<T>
        where T : class
    {
        /// <summary>
        /// Imported objects.
        /// </summary>
        private IEnumerable<T> Imports { get; set; }

        /// <summary>
        /// Gets the current executing assembly.
        /// </summary>
        private Assembly ThisAssembly
        {
            get { return Assembly.GetExecutingAssembly(); }
        }

        /// <summary>
        /// Creates a new instance of the class.
        /// </summary>
        /// <param name="importAssemblies">The reference assemblies to import against.</param>
        public ImportProvider(IEnumerable<Assembly> importAssemblies = null)
        {
            var list = (importAssemblies ?? Enumerable.Empty<Assembly>()).ToList();
            if (!list.Contains(ThisAssembly))
                list.Add(ThisAssembly);

            // create MEF container
            var container = new CompositionContainer(new AggregateCatalog(
                list.Select(a => new AssemblyCatalog(a))));

            // compose into this class instance
            Imports = container.GetExportedValues<T>();
        }

        /// <summary>
        /// Gets all imported instances.
        /// </summary>
        /// <returns>A collection of imports.</returns>
        public virtual IEnumerable<T> GetImports()
        {
            return Imports;
        }
    }
}
