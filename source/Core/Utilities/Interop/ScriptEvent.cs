using System;
using Microsoft.Cci;

namespace Blade.Utilities.Interop
{
    /// <summary>
    /// Represents an event on a <see cref="ScriptType"/>.
    /// </summary>
    public sealed class ScriptEvent : ScriptMember
    {
        private IEventDefinition _cciEvent;

        /// <summary>
        /// Creates a new instance of the class.
        /// </summary>
        /// <param name="container">The containing type.</param>
        /// <param name="eventDef">The CCI event definition.</param>
        internal ScriptEvent(ScriptType container, IEventDefinition eventDef)
            : base(container, eventDef)
        {
            _cciEvent = eventDef;
        }
    }
}
