using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Cci;

namespace Blade.Utilities.Interop
{
    /// <summary>
    /// Represents a member of a <see cref="ScriptType"/>.
    /// </summary>
    public abstract class ScriptMember
    {
        private ScriptType _container;
        private ITypeDefinitionMember _cciMember;
        private ScriptAttribute[] _attributes;

        /// <summary>
        /// Gets the containing type.
        /// </summary>
        public ScriptType Container
        {
            get { return _container; }
        }

        /// <summary>
        /// Gets a value indicating if the member is declared static.
        /// </summary>
        public virtual bool IsStatic
        {
            get { return false; }
        }

        /// <summary>
        /// Gets the attributes applied to the member
        /// </summary>
        public IEnumerable<ScriptAttribute> Attributes
        {
            get
            {
                if (_attributes == null)
                {
                    _attributes = _cciMember.Attributes
                        .Select(a => new ScriptAttribute(a)).ToArray();
                }

                return _attributes;
            }
        }

        /// <summary>
        /// Creates a new instance of the class.
        /// </summary>
        /// <param name="container">The containing type.</param>
        /// <param name="memberDef">The CCI member definition.</param>
        internal ScriptMember(ScriptType container, ITypeDefinitionMember memberDef)
        {
            if (container == null || memberDef == null)
                throw new InvalidOperationException();

            _container = container;
            _cciMember = memberDef;
        }
    }
}
