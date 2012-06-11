
namespace System.Reflection
{
    [AttributeUsage(AttributeTargets.Assembly, Inherited = false)]
	public class AssemblyTitleAttribute : Attribute
    {
        private string _title;

        public string Title
        {
            get { return _title; }
        }

        public AssemblyTitleAttribute(string title)
        {
            _title = title;
        }
    }
}


