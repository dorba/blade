using System;
using Microsoft.Cci;

namespace Blade.Utilities.Interop
{
    /// <summary>
    /// Represents a method on a <see cref="ScriptType"/>.
    /// </summary>
    public sealed class ScriptMethod : ScriptMember
    {
        private IMethodDefinition _cciMethod;

        /// <summary>
        /// Gets a value indicating if the method is declared static.
        /// </summary>
        public override bool IsStatic
        {
            get { return _cciMethod.IsStatic; }
        }

        /// <summary>
        /// Gets a value indicating 
        /// </summary>
        public bool IsConstructor
        {
            get { return _cciMethod.IsConstructor; }
        }

        /// <summary>
        /// Creates a new instance of the class.
        /// </summary>
        /// <param name="container">The containing type.</param>
        /// <param name="methodDef">The CCI method definition.</param>
        internal ScriptMethod(ScriptType container, IMethodDefinition methodDef)
            : base(container, methodDef)
        {
            _cciMethod = methodDef;
        }
    }
}
