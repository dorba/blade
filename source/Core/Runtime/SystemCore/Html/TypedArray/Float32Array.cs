using System;
using System.Dom;
using System.Html;

namespace System.Html
{
    public class Float32Array : TypedArray<float>
    {        
        public extern Float32Array(ulong length);

        public extern Float32Array(Float32Array array);

        public extern Float32Array(float[] array);

        public extern Float32Array(ArrayBuffer buffer);

        public extern Float32Array(ArrayBuffer buffer, Number byteOffset = null, Number length = null);
    }
}
