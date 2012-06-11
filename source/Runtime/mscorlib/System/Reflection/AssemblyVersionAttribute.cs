
namespace System.Reflection
{
    [AttributeUsage(AttributeTargets.Assembly, Inherited = false)]
    public class AssemblyVersionAttribute : Attribute
    {
        private string _version;

        public string Version
        {
            get { return _version; }
        }
        public AssemblyVersionAttribute(string version)
        {
            _version = version;
        }
    }
}


