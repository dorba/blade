using System;
using System.Browser;
using System.Dom;

#pragma warning disable 0626
namespace jQueryLib
{
    public class Event
    {

        ///<summary>
        ///   Returns whether event.stopImmediatePropagation() was ever called on this event object. 
        ///</summary>
        public extern bool isImmediatePropagationStopped();

        ///<summary>
        ///  Keeps the rest of the handlers from being executed and prevents the event from bubbling up the DOM tree.
        ///</summary>
        public extern void stopImmediatePropagation();

        ///<summary>
        ///   Returns whether event.stopPropagation() was ever called on this event object. 
        ///</summary>
        public extern bool isPropagationStopped();

        ///<summary>
        /// Prevents the event from bubbling up the DOM tree, preventing any parent handlers from being notified of the event.   
        ///</summary>
        public extern void stopPropagation();

        ///<summary>
        /// Returns whether event.preventDefault() was ever called on this event object. 
        ///</summary>
        public extern bool isDefaultPrevented();

        ///<summary>
        ///  If this method is called, the default action of the event will not be triggered. 
        ///</summary>
        public extern void preventDefault();

        /// <summary>
        /// The current DOM element within the event bubbling phase.
        /// </summary>
        public Element currentTarget;

        /// <summary>
        /// An optional data map passed to an event method when the current executing handler is bound. 
        /// </summary>
        public object data;

        /// <summary>
        /// The element where the currently-called jQuery event handler was attached.
        /// </summary>
        public Element delegateTarget;

        /// <summary>
        /// The namespace specified when the event was triggered.
        /// </summary>
        [ScriptName("namespace")]
        public string @namespace;

        /// <summary>
        /// The mouse position relative to the left edge of the document. 
        /// </summary>
        public int pageX;

        /// <summary>
        /// The mouse position relative to the top edge of the document. 
        /// </summary>
        public int pageY;

        /// <summary>
        /// The other DOM element involved in the event, if any. 
        /// </summary>
        public Element relatedTarget;

        /// <summary>
        /// The last value returned by an event handler that was triggered by this event, unless the value was undefined. 
        /// </summary>
        public object result;

        /// <summary>
        /// The DOM element that initiated the event. 
        /// </summary>
        public Element target;

        /// <summary>
        /// The difference in milliseconds between the time the browser created the event and January 1, 1970.
        /// </summary>
        public int timeStamp;

        /// <summary>
        /// Describes the nature of the event. 
        /// </summary>
        public string type;

        /// <summary>
        /// For key or mouse events, this property indicates the specific key or button that was pressed. 
        /// </summary>
        public int which;
    }
}
#pragma warning restore 0626
