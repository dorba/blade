using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Cci;

namespace Blade.Utilities.Interop
{
    /// <summary>
    /// Represents a type compiled against the Blade core libraries.
    /// </summary>
    public sealed class ScriptType
    {
        #region Private Fields

        private ScriptAssembly _container;
        private INamedTypeDefinition _cciType;
        private ScriptAttribute[] _attributes;
        private ScriptField[] _fields;
        private ScriptProperty[] _properties;
        private ScriptEvent[] _events;
        private ScriptMethod[] _methods;
        private string _id;

        #endregion

        /// <summary>
        /// Gets the type unique ID string.
        /// </summary>
        public string Id
        {
            get { return _id; }
        }

        /// <summary>
        /// Gets the type name.
        /// </summary>
        public string Name
        {
            get { return _cciType.Name.Value; }
        }

        /// <summary>
        /// Gets the containing assembly.
        /// </summary>
        public ScriptAssembly Assembly
        {
            get { return _container; }
        }

        /// <summary>
        /// Gets the attributes applied to the type.
        /// </summary>
        public IEnumerable<ScriptAttribute> Attributes
        {
            get
            {
                if (_attributes == null)
                {
                    _attributes = _cciType.Attributes
                        .Select(a => new ScriptAttribute(a)).ToArray();
                }

                return _attributes;
            }
        }

        /// <summary>
        /// Gets all members of the type.
        /// </summary>
        public IEnumerable<ScriptMember> Members
        {
            get
            {
                foreach (var x in Fields) yield return x;
                foreach (var x in Properties) yield return x;
                foreach (var x in Events) yield return x;
                foreach (var x in Methods) yield return x;
            }
        }

        /// <summary>
        /// Gets all fields of the type.
        /// </summary>
        public IEnumerable<ScriptField> Fields
        {
            get
            {
                if (_fields == null)
                {
                    _fields = _cciType.Fields.Select(f =>
                        new ScriptField(this, f)).ToArray();
                }

                return _fields;
            }
        }

        /// <summary>
        /// Gets all properties of the type.
        /// </summary>
        public IEnumerable<ScriptProperty> Properties
        {
            get
            {
                if (_properties == null)
                {
                    _properties = _cciType.Properties.Select(p =>
                        new ScriptProperty(this, p)).ToArray();
                }

                return _properties;
            }
        }

        /// <summary>
        /// Gets all events of the type.
        /// </summary>
        public IEnumerable<ScriptEvent> Events
        {
            get
            {
                if (_events == null)
                {
                    _events = _cciType.Events.Select(e =>
                        new ScriptEvent(this, e)).ToArray();
                }

                return _events;
            }
        }

        /// <summary>
        /// Gets all methods of the type.
        /// </summary>
        public IEnumerable<ScriptMethod> Methods
        {
            get
            {
                if (_methods == null)
                {
                    _methods = _cciType.Methods.Select(m =>
                        new ScriptMethod(this, m)).ToArray();
                }

                return _methods;
            }
        }

        /// <summary>
        /// Creates a new instance of the class.
        /// </summary>
        /// <param name="container">The containing assembly.</param>
        /// <param name="typeDef">The CCI type definition.</param>
        internal ScriptType(ScriptAssembly container, INamedTypeDefinition typeDef)
        {
            if (container == null || typeDef == null)
                throw new InvalidOperationException();
            
            _container = container;
            _cciType = typeDef;
            _id = GetKey(this);
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
                var target = obj as ScriptType;
                if (target != null)
                {
                    return (_id == target._id);
                }

                var typeRef = obj as ITypeReference;
                if (typeRef != null)
                {
                    return typeRef.InternedKey == _cciType.InternedKey;
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
            return _cciType.Name.ToString();
        }

        #region Helper Methods

        // get the unique ID for a type
        private static string GetKey(ScriptType type)
        {
            if (type == null)
                return null;

            return type._container.Id + "/" + type.Name;
        }

        #endregion
    }
}
