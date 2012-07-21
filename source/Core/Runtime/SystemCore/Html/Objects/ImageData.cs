using System;
using System.Dom;
using System.Html;

namespace System.Html
{
    public sealed class ImageData
    {
        [ScriptField]
        public ulong width { get; private set; }

        [ScriptField]
        public ulong height { get; private set; }

        [ScriptField]
        public Uint8ClampedArray data { get; private set; }
    }
}
