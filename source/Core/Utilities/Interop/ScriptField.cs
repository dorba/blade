using System;
using Microsoft.Cci;

namespace Blade.Utilities.Interop
{
    /// <summary>
    /// Represents a field on a <see cref="ScriptType"/>.
    /// </summary>
    public sealed class ScriptField : ScriptMember
    {
        private IFieldDefinition _cciField;

        /// <summary>
        /// Gets a value indicating if the field is declared static.
        /// </summary>
        public override bool IsStatic
        {
            get { return _cciField.IsStatic; }
        }

        /// <summary>
        /// Creates a new instance of the class.
        /// </summary>
        /// <param name="container">The containing type.</param>
        /// <param name="fieldDef">The CCI field definition.</param>
        internal ScriptField(ScriptType container, IFieldDefinition fieldDef)
            : base(container, fieldDef)
        {
            _cciField = fieldDef;
        }
    }

}
