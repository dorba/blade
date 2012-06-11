
namespace System.Reflection
{
    [AttributeUsage(AttributeTargets.Assembly, Inherited = false)]
    public sealed class AssemblyKeyFileAttribute : Attribute
    {
        private string _keyFile;
        public string KeyFile
        {
            get
            {
                return this._keyFile;
            }
        }
        public AssemblyKeyFileAttribute(string keyFile)
        {
            this._keyFile = keyFile;
        }
    }
}


