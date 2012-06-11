//----------------------------------------------
// Created from March 2012 HTML5 specification
// See: http://www.w3.org/TR/2012/WD-html5-20120329/dom.html#documents-in-the-dom
//----------------------------------------------
using System.Html;

namespace System.Dom
{
    /// <summary>
    /// Represents a document node.
    /// </summary>
    public sealed partial class Document
    {
        /// <summary>
        /// Gets or sets the title of the document.
        /// </summary>
        [ScriptField]
        public string title { get; set; }

        /// <summary>
        /// Gets or sets the HTTP cookies string.
        /// </summary>
        [ScriptField]
        public string cookie { get; set; }

        /// <summary>
        /// Gets the address of the Document from which the user navigated to this one,
        /// unless it was blocked or there was no such document, in which case it returns the empty string.
        /// </summary>
        [ScriptField]
        public string referrer { get; private set; }

        /// <summary>
        /// Gets the domain name of the server that provided the document.
        /// </summary>
        [ScriptField]
        public string domain { get; private set; }

        /// <summary>
        /// Gets the currently focused element in the document.
        /// </summary>
        [ScriptField]
        public Element activeElement { get; private set; }

        /// <summary>
        /// Gets or sets the body of the document.
        /// </summary>
        [ScriptField]
        public HTMLBodyElement body { get; set; }

        [ScriptField]
        public HTMLCollection images { get; private set; }

        [ScriptField]
        public HTMLCollection scripts { get; private set; }

        [ScriptField]
        public HTMLCollection links { get; private set; }

        [ScriptField]
        public HTMLCollection forms { get; private set; }

        [ScriptField]
        public HTMLCollection anchors { get; private set; }

        public Document open() { return null; }

        public void close() { }

        public void write(string text) { }

        public void writeln(string text) { }

        public NodeList getElementsByName(string elementName) { return null; }

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
        public IFunction onclick { get; set; }

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
        public IFunction onmousedown { get; set; }

        [ScriptField]
        public IFunction onmousemove { get; set; }

        [ScriptField]
        public IFunction onmouseout { get; set; }

        [ScriptField]
        public IFunction onmouseover { get; set; }

        [ScriptField]
        public IFunction onmouseup { get; set; }

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

        [ScriptField]
        public IFunction onreadystatechange { get; set; }

        #endregion
    }
}