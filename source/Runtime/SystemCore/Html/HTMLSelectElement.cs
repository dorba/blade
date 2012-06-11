//----------------------------------------------
// Created from March 2012 HTML5 specification
// See: http://www.w3.org/TR/2012/WD-html5-20120329/
//----------------------------------------------

namespace System.Html
{
    public sealed class HTMLSelectElement : HTMLElement
    {
        internal HTMLSelectElement() { }

        [ScriptField]
        public string type { get; private set; }

        [ScriptField]
        public bool autofocus { get; set; }

        [ScriptField]
        public int selectedIndex { get; set; }

        [ScriptField]
        public string value { get; set; }

        [ScriptField]
        public int length { get; set; }

        [ScriptField]
        public HTMLOptionsCollection options { get; private set; }

        [ScriptField]
        public bool disabled { get; set; }

        [ScriptField]
        public bool multiple { get; set; }

        [ScriptField]
        public string name { get; set; }

        public void add(HTMLOptionElement element, HTMLElement before = null) { }

        public void add(HTMLOptGroupElement element, HTMLElement before = null) { }

        public void remove(int index) { }
    }
}