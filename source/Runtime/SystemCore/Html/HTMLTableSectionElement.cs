//----------------------------------------------
// Created from March 2012 HTML5 specification
// See: http://www.w3.org/TR/2012/WD-html5-20120329/
//----------------------------------------------
using System.Dom;

namespace System.Html
{
    public sealed class HTMLTableSectionElement : HTMLElement
    {
        internal HTMLTableSectionElement() { }

        [ScriptField]
        public HTMLCollection rows { get; private set; }

        public HTMLElement insertRow(int index) { return null; }

        public void deleteRow(int index) { }
    }
}