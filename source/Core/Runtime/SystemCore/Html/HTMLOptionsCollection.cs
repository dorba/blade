//----------------------------------------------
// Created from March 2012 HTML5 specification
// See: http://www.w3.org/TR/2012/WD-html5-20120329/
//----------------------------------------------
using System.Dom;

namespace System.Html
{
    public sealed class HTMLOptionsCollection
    {
        internal HTMLOptionsCollection() { }

        [ScriptField]
        public int length { get; set; }

        public Node item(int index) { return null; }

        public Node namedItem(string name) { return null; }
    }
}