//----------------------------------------------
// Created from March 2012 HTML5 specification
// See: http://www.w3.org/TR/2012/WD-html5-20120329/
//----------------------------------------------

namespace System.Html
{
    public sealed class HTMLMetaElement : HTMLElement
    {
        internal HTMLMetaElement() { }

        [ScriptField]
        public string content { get; set; }

        [ScriptField]
        public string httpEquiv { get; set; }

        [ScriptField]
        public string name { get; set; }
    }
}