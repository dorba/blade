
namespace System.Reflection
{
    [AttributeUsage(AttributeTargets.Assembly, Inherited = false)]
    public class AssemblyDescriptionAttribute : Attribute
    {
        private string _description;

        public string Description
        {
            get { return _description; }
        }

        public AssemblyDescriptionAttribute(string description)
        {
            _description = description;
        }
    }
}


