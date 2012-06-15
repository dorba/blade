//----------------------------------------------
// Created from March 2012 HTML5 specification
// See: http://www.w3.org/TR/2012/WD-html5-20120329/
//----------------------------------------------

namespace System.Html
{
    public sealed class HTMLAreaElement : HTMLElement
    {
        internal HTMLAreaElement() { }

        [ScriptField]
        public string alt { get; set; }

        [ScriptField]
        public string coords { get; set; }

        [ScriptField]
        public string href { get; set; }
        
        [ScriptField]
        public string hreflang { get; set; }

        [ScriptField]
        public string shape { get; set; }

        [ScriptField]
        public string target { get; set; }

        [ScriptField]
        public string rel { get; set; }

        [ScriptField]
        public string media { get; set; }

        [ScriptField]
        public string type { get; set; }

        [ScriptField]
        public string protocol { get; set; }

        [ScriptField]
        public string host { get; set; }

        [ScriptField]
        public string hostname { get; set; }

        [ScriptField]
        public string port { get; set; }

        [ScriptField]
        public string pathname { get; set; }

        [ScriptField]
        public string search { get; set; }

        [ScriptField]
        public string hash { get; set; }
    }
}