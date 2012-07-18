using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Blade.Tools.Quality.Hosting
{
    /// <summary>
    /// Handles execution of a test from a template generated class.
    /// </summary>
    public sealed class TestExecutor
    {
        private const int DefaultTimeout = 300;
        private string _className;
        private string _methodName;

        /// <summary>
        /// Creates a new instance of the class.
        /// </summary>
        /// <param name="className">The full name of the class to test.</param>
        /// <param name="methodName">The method name to test.</param>
        public TestExecutor(string className, string methodName)
        {
            _className = className;
            _methodName = methodName;
        }

        /// <summary>
        /// Executes the test using the specified context.
        /// </summary>
        /// <param name="testContext">The test context.</param>
        public void RunTest()
        {
            var clients = TestExecutionContext.Instance.TestHost.GetClients();

            var count = clients.Count();
            var waitEvent = new ManualResetEvent(false);
            var results = new List<TestExecutionResult>();

            Action<TestExecutionResult> callback = (r) =>
            {
                results.Add(r);

                if (--count == 0)
                    waitEvent.Set();
            };

            // execute the test on each available host
            foreach (var item in clients)
            {
                item.Execute(new TestExecutionRequest
                {
                    ClassName = _className,
                    MethodName = _methodName,
                    Callback = callback
                });
            }

            if (count > 0)
            {
                // wait for tests to complete
                if (!waitEvent.WaitOne(DefaultTimeout * 1000))
                {
                    results.Add(new TestExecutionResult
                    {
                        ErrorMessage = "The test timed out, after " + DefaultTimeout + " seconds."
                    });
                }
            }

            if (results.Any(r => r.HasError))
            {
                throw new AssertFailedException(
                    String.Join(Environment.NewLine,
                    results.Where(r => r.HasError)
                    .Select(r => r.ErrorMessage)));
            }
        }
    }
}