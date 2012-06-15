
namespace System.Reflection
{
    [AttributeUsage(AttributeTargets.Assembly, Inherited = false)]
    public class AssemblyConfigurationAttribute : Attribute
    {
		private string _configuration;

        public string Configuration
        {
            get { return _configuration; }
        }
		public AssemblyConfigurationAttribute(string configuration)
        {
			_configuration = configuration;
        }
    }
}


