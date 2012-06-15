//----------------------------------------------
// Created from March 2012 HTML5 specification
// See: http://www.w3.org/TR/2012/WD-html5-20120329/
//----------------------------------------------

namespace System.Html
{
    public sealed class HTMLTextAreaElement : HTMLElement
    {
        internal HTMLTextAreaElement() { }

        [ScriptField]
        public string defaultValue { get; set; }

        [ScriptField]
        public int cols { get; set; }

        [ScriptField]
        public bool disabled { get; set; }

        [ScriptField]
        public string name { get; set; }

        [ScriptField]
        public bool readOnly { get; set; }

        [ScriptField]
        public int rows { get; set; }

        [ScriptField]
        public string type { get; private set; }

        [ScriptField]
        public string value { get; set; }

        public void select() { }
    }
}