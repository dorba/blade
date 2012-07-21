using System;
using System.Dom;
using System.Html;

namespace System.Html
{
    public abstract class ArrayBufferView
    {
        [ScriptField]
        public ArrayBuffer buffer { get; internal set; }

        [ScriptField]
        public ulong byteOffset { get; internal set; }

        [ScriptField]
        public ulong byteLength { get; internal set; }
    }
}
