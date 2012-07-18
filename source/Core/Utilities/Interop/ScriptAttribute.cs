using System;
using System.Linq;
using Microsoft.Cci;
using System.Collections.Generic;

namespace Blade.Utilities.Interop
{
    /// <summary>
    /// Represents an attribute compiled against the Blade core libraries.
    /// </summary>
    public sealed class ScriptAttribute
    {
        #region Private Fields

        private ScriptType _type;
        private ICustomAttribute _cciAttribute;
        private object[] _arguments;
        private Dictionary<string, object> _namedArgs;

        #endregion

        /// <summary>
        /// Gets the type of the attribute.
        /// </summary>
        public ScriptType Type
        {
            get { return _type; }
        }

        /// <summary>
        /// Gets the constructor argument values.
        /// </summary>
        public object[] Arguments
        {
            get { return _arguments; }
        }

        /// <summary>
        /// Gets the named argument values.
        /// </summary>
        public IDictionary<string, object> NamedArguments
        {
            get { return _namedArgs; }
        }

        /// <summary>
        /// Creates a new instance of the class.
        /// </summary>
        /// <param name="type">The attribute type.</param>
        /// <param name="attribute">The CCI attribute.</param>
        internal ScriptAttribute(ICustomAttribute attribute)
        {
            if (attribute == null)
                throw new InvalidOperationException();

            var typeRef = attribute.Type as INamedTypeReference;

            if (typeRef == null)
            {
                throw new InvalidOperationException("Attribute type must be a named type.");
            }

            var type = ScriptDomain.CurrentDomain.ResolveType(typeRef);

            if (type == null)
            {
                throw new InvalidOperationException("Unable to resolve type for attribute: " + typeRef.Name);
            }

            _type = type;
            _cciAttribute = attribute;

            _arguments = _cciAttribute.Arguments
                .Select(a => GetConstantValue(a)).ToArray();

            _namedArgs = _cciAttribute.NamedArguments.ToDictionary(a =>
                a.ArgumentName.Value, a => GetConstantValue(a));
        }

        /// <summary>
        /// Gets the type display string.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return _type.ToString();
        }

        #region Helper Methods

        // get a constant value or null
        private object GetConstantValue(IMetadataExpression expression)
        {
            var constExp = expression as IMetadataConstant;
            return constExp != null ? constExp.Value : null;
        }

        #endregion
    }
}
