//----------------------------------------------
// Created from March 2012 HTML5 specification
// See: http://www.w3.org/TR/2012/WD-html5-20120329/
//----------------------------------------------

namespace System.Html
{
    public abstract class HTMLOptionElement : HTMLElement
    {
        internal HTMLOptionElement() { }

        [ScriptField]
        public HTMLFormElement form { get; private set; }

        [ScriptField]
        public bool defaultSelected { get; set; }

        [ScriptField]
        public string text { get; private set; }

        [ScriptField]
        public int index { get; private set; }

        [ScriptField]
        public bool disabled { get; set; }

        [ScriptField]
        public string label { get; set; }

        [ScriptField]
        public bool selected { get; set; }

        [ScriptField]
        public string value { get; set; }
    }
}