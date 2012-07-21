using System.Dom;

namespace System.Html
{
    [ScriptExternal]
    public abstract partial class HTMLCanvasElement : Element
    {
        [ScriptField]
        public ulong height { get; set; }

        [ScriptField]
        public ulong width { get; set; }

        public abstract ICanvasRenderingContext getContext(string contextID);

        public abstract string toDataURL();

        public abstract string toDataURL(string type);

        public abstract string toDataURL(string type, params object[] typeArguments);
    }
}
