//----------------------------------------------
// Created from March 2012 HTML5 specification
// See: http://www.w3.org/TR/2012/WD-html5-20120329/
//----------------------------------------------
using System.Dom;

namespace System.Html
{
    public sealed class HTMLTableElement : HTMLElement
    {
        internal HTMLTableElement() { }

        [ScriptField]
        public HTMLTableCaptionElement caption { get; set; }

        [ScriptField]
        public HTMLTableSectionElement tHead { get; set; }

        [ScriptField]
        public HTMLTableSectionElement tFoot { get; set; }

        [ScriptField]
        public HTMLCollection rows { get; private set; }

        [ScriptField]
        public HTMLCollection tBodies { get; private set; }

        [ScriptField]
        public string border { get; set; }

        public HTMLTableSectionElement createTHead() { return null; }

        public void deleteTHead() { }

        public HTMLTableSectionElement createTFoot() { return null; }

        public void deleteTFoot() { }

        public HTMLTableCaptionElement createCaption() { return null; }

        public void deleteCaption() { }

        public HTMLTableRowElement insertRow(int index) { return null; }

        public void deleteRow(int index) { }
    }
}