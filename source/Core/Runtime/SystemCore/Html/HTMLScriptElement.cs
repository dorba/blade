//----------------------------------------------
// Created from March 2012 HTML5 specification
// See: http://www.w3.org/TR/2012/WD-html5-20120329/
//----------------------------------------------

namespace System.Html
{
    public sealed class HTMLScriptElement : HTMLElement
    {
        internal HTMLScriptElement() { }

        [ScriptField]
        public string text { get; set; }

        [ScriptField]
        public string charset { get; set; }

        [ScriptField]
        public bool defer { get; set; }

        [ScriptField]
        public string src { get; set; }

        [ScriptField]
        public string type { get; set; }
    }
}