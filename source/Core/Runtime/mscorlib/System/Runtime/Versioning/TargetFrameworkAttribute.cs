
using System.Reflection;

namespace System.Runtime.Versioning
{
    /// <summary>
    /// For project compatibility.
    /// Not for use within blade.
    /// </summary>
    [EditorBrowsable(EditorBrowsableState.Never)]
    [AttributeUsage(AttributeTargets.Assembly, Inherited = false, AllowMultiple = false)]
    public class TargetFrameworkAttribute : Attribute
    {
        private string _frameworkName;
        private string _frameworkDisplayName;

        public string FrameworkDisplayName
        {
            get { return _frameworkDisplayName; }
            set { _frameworkDisplayName = value; }
        }

        public string FrameworkName
        {
            get { return _frameworkName; }
        }

        public TargetFrameworkAttribute(string frameworkName)
        {
            _frameworkName = frameworkName;
        }
    }
}
