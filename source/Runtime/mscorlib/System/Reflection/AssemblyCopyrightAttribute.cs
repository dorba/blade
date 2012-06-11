
namespace System.Reflection
{
    [AttributeUsage(AttributeTargets.Assembly, Inherited = false)]
	public class AssemblyCopyrightAttribute : Attribute
    {
        private string _copyright;

        public string Copyright
        {
            get { return _copyright; }
        }
		public AssemblyCopyrightAttribute(string copyright)
        {
            _copyright = copyright;
        }
    }
}


