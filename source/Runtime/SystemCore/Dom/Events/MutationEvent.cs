//----------------------------------------------
// Created from DOM Level 3 Events specification
// See: http://www.w3.org/TR/DOM-Level-3-Events/
//----------------------------------------------

namespace System.Dom
{
    /// <summary>
    /// Represents an event created from a mutation action.
    /// </summary>
    public sealed class MutationEvent : Event
    {
        internal MutationEvent() { }

        /// <summary>
        /// The attribut was modified in place.
        /// </summary>
        public const int MODIFICATION = 1;

        /// <summary>
        /// The attribute was added.
        /// </summary>
        public const int ADDITION = 2;

        /// <summary>
        /// The attribute was removed.
        /// </summary>
        public const int REMOVAL = 3;

        /// <summary>
        /// Gets a secondary node related to the event.
        /// </summary>
        [ScriptField]
        public Node relatedNode { get; private set; }

        /// <summary>
        /// Gets the value prior to the mutation.
        /// </summary>
        [ScriptField]
        public string prevValue { get; private set; }

        /// <summary>
        /// Gets the value after the mutation.
        /// </summary>
        [ScriptField]
        public string newValue { get; private set; }

        /// <summary>
        /// Gets the target attribute name.
        /// </summary>
        [ScriptField]
        public string attrName { get; private set; }

        /// <summary>
        /// Gets the type of mutation.
        /// </summary>
        [ScriptField]
        public int attrChange { get; private set; }

        /// <summary>
        /// Initializes the value of a mutation event.
        /// </summary>
        /// <param name="type">The event type name.</param>
        /// <param name="canBubble">Whether or not the event can bubble.</param>
        /// <param name="canCancel">Whether or not the event can be cancelled.</param>
        /// <param name="relatedNode">The secondary related node.</param>
        /// <param name="prevValue">The previous value.</param>
        /// <param name="newValue">The new value.</param>
        /// <param name="attrName">The attribute name.</param>
        /// <param name="attrChange">The type of mutation.</param>
        public void initMutationEvent(string type, bool canBubble, bool canCancel,
            Node relatedNode, string prevValue, string newValue, string attrName, int attrChange) { }
    }
}