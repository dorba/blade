using System;
using System.Dom;
using System.Html;

namespace System.Html
{
    public class Uint8Array : TypedArray<byte>
    {
        public extern Uint8Array(ulong length);

        public extern Uint8Array(Uint8Array array);

        public extern Uint8Array(byte[] array);

        public extern Uint8Array(ArrayBuffer buffer);

        public extern Uint8Array(ArrayBuffer buffer, Number byteOffset = null, Number length = null);
    }
}
