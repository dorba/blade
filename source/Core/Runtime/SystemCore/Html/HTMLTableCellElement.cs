//----------------------------------------------
// Created from March 2012 HTML5 specification
// See: http://www.w3.org/TR/2012/WD-html5-20120329/
//----------------------------------------------

namespace System.Html
{
    public abstract class HTMLTableCellElement : HTMLElement
    {
        internal HTMLTableCellElement() { }

        [ScriptField]
        public int cellIndex { get; private set; }

        [ScriptField]
        public int colSpan { get; set; }
        
        [ScriptField]
        public int rowSpan { get; set; }

        [ScriptField]
        public string headers { get; set; }
    }
}