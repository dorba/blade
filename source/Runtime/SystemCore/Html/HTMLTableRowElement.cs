//----------------------------------------------
// Created from March 2012 HTML5 specification
// See: http://www.w3.org/TR/2012/WD-html5-20120329/
//----------------------------------------------
using System.Dom;

namespace System.Html
{
    public sealed class HTMLTableRowElement : HTMLElement
    {
        internal HTMLTableRowElement() { }

        [ScriptField]
        public int rowIndex { get; private set; }

        [ScriptField]
        public int sectionRowIndex { get; private set; }

        [ScriptField]
        public HTMLCollection cells { get; private set; }

        public HTMLElement insertCell(int index) { return null; }

        public void deleteCell(int index) { }
    }
}