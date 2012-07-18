//----------------------------------------------
// Created from March 2012 HTML5 specification
// See: http://www.w3.org/TR/2012/WD-html5-20120329/elements.html#htmlelement
//----------------------------------------------

using System.Css;
using System.Dom;

namespace System.Html
{
    /// <summary>
    /// Represents an HTML element node.
    /// </summary>
    public abstract partial class HTMLElement : Element
    {
        internal HTMLElement() { }

        [ScriptField]
        public string title { get; set; }

        [ScriptField]
        public string lang { get; set; }

        [ScriptField]
        public string dir { get; set; }

        [ScriptField]
        public string innerHTML { get; set; }

        [ScriptField]
        public int tabIndex { get; set; }

        [ScriptField]
        public CSSStyleDeclaration style { get; private set; }

        public void click() { }
        public void focus() { }
        public void blur() { }

        #region Events

        [ScriptField]
        public IFunction onabort { get; set; }

        [ScriptField]
        public IFunction onblur { get; set; }

        [ScriptField]
        public IFunction oncanplay { get; set; }

        [ScriptField]
        public IFunction oncanplaythrough { get; set; }

        [ScriptField]
        public IFunction onchange { get; set; }

        [ScriptField]
        public MouseEventHandler onclick { get; set; }

        [ScriptField]
        public IFunction oncontextmenu { get; set; }

        [ScriptField]
        public IFunction oncuechange { get; set; }

        [ScriptField]
        public IFunction ondblclick { get; set; }

        [ScriptField]
        public IFunction ondrag { get; set; }

        [ScriptField]
        public IFunction ondragend { get; set; }

        [ScriptField]
        public IFunction ondragenter { get; set; }

        [ScriptField]
        public IFunction ondragleave { get; set; }

        [ScriptField]
        public IFunction ondragover { get; set; }

        [ScriptField]
        public IFunction ondragstart { get; set; }

        [ScriptField]
        public IFunction ondrop { get; set; }

        [ScriptField]
        public IFunction ondurationchange { get; set; }

        [ScriptField]
        public IFunction onemptied { get; set; }

        [ScriptField]
        public IFunction onended { get; set; }

        [ScriptField]
        public IFunction onerror { get; set; }

        [ScriptField]
        public IFunction onfocus { get; set; }

        [ScriptField]
        public IFunction oninput { get; set; }

        [ScriptField]
        public IFunction oninvalid { get; set; }

        [ScriptField]
        public IFunction onkeydown { get; set; }

        [ScriptField]
        public IFunction onkeypress { get; set; }

        [ScriptField]
        public IFunction onkeyup { get; set; }

        [ScriptField]
        public IFunction onload { get; set; }

        [ScriptField]
        public IFunction onloadeddata { get; set; }

        [ScriptField]
        public IFunction onloadedmetadata { get; set; }

        [ScriptField]
        public IFunction onloadstart { get; set; }

        [ScriptField]
        public MouseEventHandler onmousedown { get; set; }

        [ScriptField]
        public MouseEventHandler onmousemove { get; set; }

        [ScriptField]
        public MouseEventHandler onmouseout { get; set; }

        [ScriptField]
        public MouseEventHandler onmouseover { get; set; }

        [ScriptField]
        public MouseEventHandler onmouseup { get; set; }

        [ScriptField]
        public IFunction onmousewheel { get; set; }

        [ScriptField]
        public IFunction onpause { get; set; }

        [ScriptField]
        public IFunction onplay { get; set; }

        [ScriptField]
        public IFunction onplaying { get; set; }

        [ScriptField]
        public IFunction onprogress { get; set; }

        [ScriptField]
        public IFunction onratechange { get; set; }

        [ScriptField]
        public IFunction onreset { get; set; }

        [ScriptField]
        public IFunction onscroll { get; set; }

        [ScriptField]
        public IFunction onseeked { get; set; }

        [ScriptField]
        public IFunction onseeking { get; set; }

        [ScriptField]
        public IFunction onselect { get; set; }

        [ScriptField]
        public IFunction onshow { get; set; }

        [ScriptField]
        public IFunction onstalled { get; set; }

        [ScriptField]
        public IFunction onsubmit { get; set; }

        [ScriptField]
        public IFunction onsuspend { get; set; }

        [ScriptField]
        public IFunction ontimeupdate { get; set; }

        [ScriptField]
        public IFunction onvolumechange { get; set; }

        [ScriptField]
        public IFunction onwaiting { get; set; }

        /// <summary>
        /// Registers an event listener with the target.
        /// </summary>
        /// <param name="type">The event type name.</param>
        /// <param name="listener">The listener to register.</param>
        /// <param name="useCapture">Whether or not to use capture.</param>
        public void addEventListener(string type, EventListener listener, bool useCapture) { }

        /// <summary>
        /// Registers an event handler with the target.
        /// </summary>
        /// <param name="type">The event type name.</param>
        /// <param name="handler">The event handler function.</param>
        /// <param name="useCapture">Whether or not to use capture.</param>
        public void addEventListener(string type, EventHandler handler, bool useCapture) { }

        /// <summary>
        /// Removes an event listener from a target.
        /// </summary>
        /// <param name="type">The event type name.</param>
        /// <param name="listener">The listener to remove.</param>
        /// <param name="useCapture">Whether or not capture was used.</param>
        public void removeEventListener(string type, EventListener listener, bool useCapture) { }

        /// <summary>
        /// Removes an event handler from a target.
        /// </summary>
        /// <param name="type">The event type name.</param>
        /// <param name="handler">The event handler function.</param>
        /// <param name="useCapture">Whether or not capture was used.</param>
        public void removeEventListener(string type, EventHandler handler, bool useCapture) { }

        #endregion
    }
}