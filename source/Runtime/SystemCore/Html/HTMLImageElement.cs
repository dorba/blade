//----------------------------------------------
// Created from March 2012 HTML5 specification
// See: http://www.w3.org/TR/2012/WD-html5-20120329/
//----------------------------------------------

namespace System.Html
{
    public abstract class HTMLImageElement : HTMLElement
    {
        internal HTMLImageElement() { }

        [ScriptField]
        public string src { get; set; }
        
        [ScriptField]
        public string alt { get; set; }

        [ScriptField]
        public int height { get; set; }

        [ScriptField]
        public int width { get; set; }

        [ScriptField]
        public bool isMap { get; set; }

        [ScriptField]
        public string useMap { get; set; }
    }
}