//----------------------------------------------
// Created from March 2012 HTML5 specification
// See: http://www.w3.org/TR/2012/WD-html5-20120329/
//----------------------------------------------
using System.Dom;

namespace System.Html
{
    public sealed class HTMLMapElement : HTMLElement
    {
        internal HTMLMapElement() { }

        [ScriptField]
        public HTMLCollection areas { get; private set; }

        [ScriptField]
        public HTMLCollection images { get; private set; }

        [ScriptField]
        public string name { get; set; }
    }
}