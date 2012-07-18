using System.Reflection;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Blade.Tools.Quality.Hosting
{
    /// <summary>
    /// The test execution context.
    /// </summary>
    public sealed class TestExecutionContext
    {
        private static volatile TestExecutionContext _instance;
        private static object _lock = new object();

        /// <summary>
        /// Gets the singleton execution context.
        /// </summary>
        public static TestExecutionContext Instance
        {
            get
            {
                if (_instance == null)
                {
                    lock (_lock)
                        _instance = CreateInstance();
                }

                return _instance;
            }
        }

        /// <summary>
        /// Gets the test host provider.
        /// </summary>
        public TestHost TestHost { get; private set; }

        /// <summary>
        /// Gets the mstest TestContext setting.
        /// </summary>
        public TestContext TestContext {get; private set;}

        /// <summary>
        /// Gets the assembly under test.
        /// </summary>
        public Assembly TestingAssembly { get; private set; }

        /// <summary>
        /// No public ctor
        /// </summary>
        private TestExecutionContext()
        {
            TestHost = new TestHost();
        }

        /// <summary>
        /// Signals the beginning of a run.
        /// </summary>
        /// <param name="testContext">The test context.</param>
        /// <param name="webRoot">The physical path of the web root directory.</param>
        public void Begin(TestContext testContext, string webRoot)
        {
            TestContext = testContext;
            TestingAssembly = Assembly.GetCallingAssembly();
            TestHost.Initialize(webRoot);
        }

        /// <summary>
        /// Signals the end of a test run.
        /// </summary>
        public void End()
        {
            TestHost.Cleanup();
        }

        // internal create method
        private static TestExecutionContext CreateInstance()
        {
            if (_instance != null)
                return _instance;

            return new TestExecutionContext();
        }
    }
}
