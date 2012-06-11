//----------------------------------------------
// Created from March 2012 HTML5 specification
// See: http://www.w3.org/TR/2012/WD-html5-20120329/
//----------------------------------------------

namespace System.Html
{
    public sealed class HTMLButtonElement : HTMLElement
    {
        internal HTMLButtonElement() { }

        [ScriptField]
        public bool autofocus { get; set; }

        [ScriptField]
        public bool disabled { get; set; }

        [ScriptField]
        public string name { get; set; }

        [ScriptField]
        public string type { get; private set; }

        [ScriptField]
        public string value { get; set; }
    }
}