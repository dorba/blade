
namespace System.Reflection
{
    /// <summary>
    /// Allows for the specification of a custom output script name
    /// when extracting an embedded script resource from an assembly.
    /// </summary>
    [AttributeUsage(AttributeTargets.Assembly, Inherited = false, AllowMultiple = false)]
    public class AssemblyScriptNameAttribute : Attribute
    {
        private string _name;

        /// <summary>
        /// The script name, without extension.
        /// </summary>
        public string Name
        {
            get { return _name; }
        }

        /// <summary>
        /// Creates a new instance of the attribute.
        /// </summary>
        /// <param name="name">The script name, without extension.</param>
        public AssemblyScriptNameAttribute(string name)
        {
            _name = name;
        }
    }
}


