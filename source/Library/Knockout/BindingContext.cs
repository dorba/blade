using System;
using System.Html;

namespace Knockout
{
    /// <summary>
    /// An object used for accessing binding data. 
    /// </summary>
    public sealed class BindingContext
    {
        private BindingContext() { }

        /// <summary>
        /// Gets the view model object for the parent context.
        /// </summary>
        [ScriptField]
        [ScriptName("$parent")]
        public dynamic parent { get; private set; }

        /// <summary>
        /// Gets a collection of all parent view models.
        /// </summary>
        [ScriptField]
        [ScriptName("$parents")]
        public dynamic[] parents { get; private set; }

        /// <summary>
        /// Gets the view model object for the topmost parent context.
        /// </summary>
        [ScriptField]
        [ScriptName("$root")]
        public dynamic root { get; private set; }

        /// <summary>
        /// Gets the view model object for the current context.
        /// </summary>
        [ScriptField]
        [ScriptName("$data")]
        public dynamic data { get; private set; }

        /// <summary>
        /// Gets the zero-based index of the current array entry
        /// from within a knockout foreach binding operation.
        /// </summary>
        [ScriptField]
        [ScriptName("$index")]
        public int index { get; private set; }

        /// <summary>
        /// Gets the binding context of the parent.
        /// </summary>
        [ScriptField]
        [ScriptName("$parentContext")]
        public BindingContext parentContext { get; private set; }
    }
}
