using System;
using Microsoft.Cci;

namespace Blade.Utilities.Interop
{
    /// <summary>
    /// Represents a property on a <see cref="ScriptType"/>.
    /// </summary>
    public sealed class ScriptProperty : ScriptMember
    {
        private IPropertyDefinition _cciProperty;

        /// <summary>
        /// Gets a value indicating if the property is declared static.
        /// </summary>
        public override bool IsStatic
        {
            get { return _cciProperty.IsStatic; }
        }

        /// <summary>
        /// Creates a new instance of the class.
        /// </summary>
        /// <param name="container">The containing type.</param>
        /// <param name="propDef">The CCI property definition.</param>
        internal ScriptProperty(ScriptType container, IPropertyDefinition propDef)
            : base(container, propDef)
        {
            _cciProperty = propDef;
        }
    }
}
