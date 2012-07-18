using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Microsoft.Cci;

namespace Blade.Utilities.Interop
{
    /// <summary>
    /// Represents an assembly compiled against the Blade core libraries.
    /// </summary>
    public sealed class ScriptAssembly
    {
        #region Private Fields

        private const string ScriptResourceName = "blade.script.resource";

        private ScriptDomain _container;
        private IAssembly _cciAssembly;
        private ScriptType[] _types;
        private ScriptAttribute[] _attributes;
        private string _id;

        #endregion

        /// <summary>
        /// Gets the assembly unique ID string.
        /// </summary>
        public string Id
        {
            get { return _id; }
        }

        /// <summary>
        /// Gets the simple assembly name.
        /// </summary>
        public string Name
        {
            get { return _cciAssembly.Name.Value; }
        }

        /// <summary>
        /// Gets a value indicating whether or not the assembly has any resources.
        /// </summary>
        public bool HasResources
        {
            get { return _cciAssembly.Resources.Any(); }
        }

        /// <summary>
        /// Gets a value indicating whether or not the assembly has a script implementation embedded.
        /// </summary>
        public bool HasScriptResource
        {
            get { return _cciAssembly.Resources.Any(r => r.Name.Value == ScriptResourceName); }
        }

        /// <summary>
        /// Gets the name used for the output script, if this assembly contains a script resource.
        /// </summary>
        public string ScriptName
        {
            get
            {
                var nameAttr = Attributes.SingleOrDefault(a =>
                    a.Type.Assembly.Name == "mscorlib" &&
                    a.Type.Name == "AssemblyScriptNameAttribute");

                if (nameAttr != null)
                {
                    var scriptName = nameAttr.Arguments.SingleOrDefault() as string;

                    if (!String.IsNullOrWhiteSpace(scriptName) && !scriptName.Any(c =>
                        Path.GetInvalidFileNameChars().Contains(c)))
                    {
                        return scriptName;
                    }
                }

                return Name;
            }
        }

        /// <summary>
        /// Gets the types defined in the assembly.
        /// </summary>
        public IEnumerable<ScriptType> Types
        {
            get
            {
                if (_types == null)
                {
                    _types = _cciAssembly.GetAllTypes()
                        .Select(t => new ScriptType(this, t))
                        .ToArray();
                }

                return _types;
            }
        }

        /// <summary>
        /// Gets the attributes applied to the assembly.
        /// </summary>
        public IEnumerable<ScriptAttribute> Attributes
        {
            get
            {
                if (_attributes == null)
                {
                    _attributes = _cciAssembly.AssemblyAttributes
                        .Select(a => new ScriptAttribute(a)).ToArray();
                }

                return _attributes;
            }
        }

        // interal ctor only
        internal ScriptAssembly(ScriptDomain container, IAssembly cciAssembly)
        {
            if (container == null || cciAssembly == null)
                throw new ArgumentNullException();

            _container = container;
            _cciAssembly = cciAssembly;
            _id = GetKey(this);
        }

        /// <summary>
        /// Loads an assembly from a file on disk.
        /// </summary>
        /// <param name="path">The file path.</param>
        /// <returns>The loaded assembly.</returns>
        public static ScriptAssembly Load(string path)
        {
            return ScriptDomain.CurrentDomain.LoadAssembly(path);
        }

        /// <summary>
        /// Gets the names of all resources in the assembly.
        /// </summary>
        /// <returns>A collection of strings.</returns>
        public IEnumerable<string> GetResourceNames()
        {
            return _cciAssembly.Resources.Select(r => r.Name.Value);
        }

        /// <summary>
        /// Gets the data stream for a specific resource.
        /// </summary>
        /// <param name="name">The resource name.</param>
        /// <returns>A data stream.</returns>
        public Stream GetResourceStream(string name)
        {
            return new MemoryStream(GetResourceData(this, name));
        }

        /// <summary>
        /// Gets the embedded script implementation data stream.
        /// </summary>
        /// <returns>A data stream.</returns>
        public Stream GetScriptResource()
        {
            return GetResourceStream(ScriptResourceName);
        }

        /// <summary>
        /// Gets the embedded script implementation as text.
        /// </summary>
        /// <returns>A script string.</returns>
        public string GetScriptResourceText()
        {
            var data = GetResourceData(this, ScriptResourceName);
            return data != null ? Encoding.UTF8.GetString(data) : String.Empty;
        }

        /// <summary>
        /// Gets the assemblies referenced directly by this assembly.
        /// </summary>
        /// <returns>A collection of assemblies.</returns>
        public IEnumerable<ScriptAssembly> GetReferencedAssemblies()
        {
            foreach (var item in _cciAssembly.AssemblyReferences)
            {
                var itemId = GetKey(item);
                var loaded = _container.GetAssembly(itemId);

                if (loaded != null)
                    yield return loaded;
                else
                {
                    // load and ensure it is accessible
                    _container.LoadAssembly(item.AssemblyIdentity);
                    loaded = _container.GetAssembly(itemId);

                    if (loaded == null)
                        throw new InvalidOperationException();

                    yield return loaded;
                }
            }
        }

        /// <summary>
        /// Gets an ordered set of all referenced assemblies,
        /// traversing through the entire dependency chain.
        /// </summary>
        /// <returns>A collection of assemblies.</returns>
        public IEnumerable<ScriptAssembly> GetDependencyChain()
        {
            var list = new List<ScriptAssembly>();
            CreateDependencyChain(this, list);

            return list;
        }

        /// <summary>
        /// Determines if an object is equal to this object.
        /// </summary>
        /// <param name="obj">The object to compare to.</param>
        /// <returns>True if the objects are equal, false otherwise.</returns>
        public override bool Equals(object obj)
        {
            if (obj != null)
            {
                var target = obj as ScriptAssembly;
                if (target != null)
                {
                    return (_id == target._id);
                }
            }

            return false;
        }

        /// <summary>
        /// Gets the objects hash code.
        /// </summary>
        /// <returns>An integer.</returns>
        public override int GetHashCode()
        {
            return _id.GetHashCode();
        }

        /// <summary>
        /// Gets the type display string.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return _cciAssembly.Name.ToString();
        }

        #region Helper Methods

        private static byte[] GetResourceData(ScriptAssembly assembly, string name)
        {
            if (assembly == null || String.IsNullOrEmpty(name))
                return null;

            var target = assembly._cciAssembly.Resources
                .SingleOrDefault(r => r.Name.Value == name);

            if (target == null || target.Resource == null)
                return null;

            return target.Resource.Data.ToArray();
        }

        private static void CreateDependencyChain(ScriptAssembly target, List<ScriptAssembly> list)
        {
            foreach (var item in target.GetReferencedAssemblies())
            {
                if (!list.Contains(item))
                {
                    list.Add(item);
                    CreateDependencyChain(item, list);
                }
                else
                {
                    // this effectively sorts the list
                    var itemIdx = list.IndexOf(item);
                    var targetIdx = list.IndexOf(target);

                    if (itemIdx < targetIdx)
                    {
                        list.RemoveAt(itemIdx);
                        list.Insert(targetIdx, item);
                    }
                }
            }
        }

        private static string GetKey(ScriptAssembly assembly)
        {
            if (assembly == null)
                return null;

            return GetKey(assembly._cciAssembly.AssemblyIdentity);
        }

        private static string GetKey(IAssemblyReference assemblyRef)
        {
            if (assemblyRef == null)
                return null;

            return GetKey(assemblyRef.AssemblyIdentity);
        }

        private static string GetKey(AssemblyIdentity identity)
        {
            if (identity == null)
                return null;

            return (identity.Name + "/" + identity.Version).ToLower();
        }

        #endregion
    }
}
