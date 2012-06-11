//----------------------------------------------
// Created from March 2012 HTML5 specification
// See: http://www.w3.org/TR/2012/WD-html5-20120329/
//----------------------------------------------

namespace System.Html
{
    public sealed class HTMLInputElement : HTMLElement
    {
        internal HTMLInputElement() { }

        [ScriptField]
        public string accept { get; set; }

        [ScriptField]
        public string autocomplete { get; set; }

        [ScriptField]
        public bool autofocus { get; set; }

        [ScriptField]
        public bool defaultChecked { get; set; }

        [ScriptField]
        public bool @checked { get; set; }

        [ScriptField]
        public bool disabled { get; set; }

        [ScriptField]
        public long maxLength { get; set; }

        [ScriptField]
        public string name { get; set; }

        [ScriptField]
        public bool readOnly { get; set; }

        [ScriptField]
        public int size { get; set; }

        [ScriptField]
        public string src { get; set; }

        [ScriptField]
        public string type { get; set; }

        [ScriptField]
        public string defaultValue { get; set; }

        [ScriptField]
        public string value { get; set; }

        public void select() { }

        public void setSelectionRange(int start, int end, string direction = "none") { }
    }
}