using System;
using System.Dom;
using System.Html;

namespace System.Html
{
    public class ArrayBuffer
    {
        [ScriptField]
        public ulong byteLength { get; set; }

        public extern ArrayBuffer(ulong length);

        public extern ArrayBuffer slice(long begin); 
        
        public extern ArrayBuffer slice(long begin, long end);
    }
}
