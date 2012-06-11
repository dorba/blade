//----------------------------------------------
// Created from March 2012 HTML5 specification
// See: http://www.w3.org/TR/2012/WD-html5-20120329/
//----------------------------------------------

namespace System.Html
{
    public sealed class HTMLBodyElement : HTMLElement
    {
        internal HTMLBodyElement() { }

        [ScriptField]
        IFunction onafterprint { get; set; }

        [ScriptField]
        IFunction onbeforeprint { get; set; }

        [ScriptField]
        IFunction onbeforeunload { get; set; }

        [ScriptField]
        IFunction onblur { get; set; }

        [ScriptField]
        IFunction onerror { get; set; }

        [ScriptField]
        IFunction onfocus { get; set; }

        [ScriptField]
        IFunction onhashchange { get; set; }

        [ScriptField]
        IFunction onload { get; set; }

        [ScriptField]
        IFunction onmessage { get; set; }

        [ScriptField]
        IFunction onoffline { get; set; }

        [ScriptField]
        IFunction ononline { get; set; }

        [ScriptField]
        IFunction onpopstate { get; set; }

        [ScriptField]
        IFunction onpagehide { get; set; }

        [ScriptField]
        IFunction onpageshow { get; set; }

        [ScriptField]
        IFunction onresize { get; set; }

        [ScriptField]
        IFunction onscroll { get; set; }

        [ScriptField]
        IFunction onstorage { get; set; }

        [ScriptField]
        IFunction onunload { get; set; }
    }
}