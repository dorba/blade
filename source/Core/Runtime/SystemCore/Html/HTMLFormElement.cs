//----------------------------------------------
// Created from March 2012 HTML5 specification
// See: http://www.w3.org/TR/2012/WD-html5-20120329/
//----------------------------------------------
using System.Dom;

namespace System.Html
{
    public sealed class HTMLFormElement : HTMLElement
    {
        internal HTMLFormElement() { }

        [ScriptField]
        public HTMLCollection elements { get; private set; }

        [ScriptField]
        public int length { get; private set; }

        [ScriptField]
        public string name { get; set; }

        [ScriptField]
        public string acceptCharset { get; set; }

        [ScriptField]
        public string action { get; set; }

        [ScriptField]
        public string enctype { get; set; }

        [ScriptField]
        public string method { get; set; }

        [ScriptField]
        public string target { get; set; }

        [ScriptField]
        public string autocomplete { get; set; }

        public void submit() { }
        public void reset() { }
    }
}