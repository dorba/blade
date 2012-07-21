using System;
using System.Dom;
using System.Html;

namespace System.Html
{
    public class Uint8ClampedArray : TypedArray<byte>
    {
        public extern Uint8ClampedArray(ulong length);

        public extern Uint8ClampedArray(Uint8ClampedArray array);

        public extern Uint8ClampedArray(Uint8Array array);

        public extern Uint8ClampedArray(byte[] array);

        public extern Uint8ClampedArray(ArrayBuffer buffer);

        public extern Uint8ClampedArray(ArrayBuffer buffer, Number byteOffset = null, Number length = null);
    }
}
