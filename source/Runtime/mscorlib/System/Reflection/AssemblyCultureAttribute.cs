
namespace System.Reflection
{
    [AttributeUsage(AttributeTargets.Assembly, Inherited = false)]
	public class AssemblyCultureAttribute : Attribute
    {
		private string _culture;

        public string Culture
        {
			get { return _culture; }
        }
		public AssemblyCultureAttribute(string culture)
        {
			_culture = culture;
        }
    }
}


