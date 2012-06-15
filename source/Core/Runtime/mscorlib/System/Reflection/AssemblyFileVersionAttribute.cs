
namespace System.Reflection
{
    [AttributeUsage(AttributeTargets.Assembly, Inherited = false)]
	public class AssemblyFileVersionAttribute : Attribute
    {
        private string _fileVersion;

        public string FileVersion
        {
            get { return _fileVersion; }
        }
        public AssemblyFileVersionAttribute(string version)
        {
            _fileVersion = version;
        }
    }
}


