
namespace System.Reflection
{
    [AttributeUsage(AttributeTargets.Assembly, Inherited = false)]
    public class AssemblyCompanyAttribute : Attribute
    {
        private string _company;

        public string Company
        {
            get { return _company; }
        }
		public AssemblyCompanyAttribute(string company)
        {
            _company = company;
        }
    }
}


