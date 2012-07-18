using System;
using Blade.Tools.Quality.Shared;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Blade.Tools.Quality.Host
{
    /// <summary>
    /// Handles the RunTest command.
    /// </summary>
    [ScriptNamespace("Blade")]
    internal class RunTestHandler : IOperationHandler
    {
        /// <summary>
        /// Runs a test for a specific class and method.
        /// </summary>
        /// <param name="op">The operation data.</param>
        /// <param name="done">The completion callback.</param>
        public void HandleOp(OperationData op, Action done)
        {
            var testOp = (RunTestOperation)op;
            var func = GetTestFunc(testOp);
            var err = "";

            ConsoleProxy.log("Running test: " + testOp.ClassName + "." + testOp.MethodName);

            object result = null;
            try { result = func(); }
            catch (Exception ex)
            {
                // exceptions indicate test failure
                var browser = GetBrowserName();
                err = ((browser != null) ? ("[" + browser + "] ") : "") + ex.toString();

                ConsoleProxy.log("Test Failed: " + err);
                ClientHost.Service.FailTest(err, done);
                return;
            }

            // tests returing null or undefined indicate 
            // the test is complete and has passed
            if (result == null || result == window.undefined)
            {
                ConsoleProxy.log("Test Passed");
                ClientHost.Service.PassTest(done);
                return;
            }

            // if a test result type is returned, the 
            // result may be deferred due to async execution
            if (result is TestResult)
            {
                CheckAsyncResult((TestResult)result, done);
                return;
            }

            // the return type was not of any expected
            // value, return as test failure
            ClientHost.Service.FailTest(
                "Unexpected test return value. Synchronous tests should return void. " +
                "Asynchronous tests should return an object of type TestResult.", done);
        }

        private Func<object> GetTestFunc(RunTestOperation op)
        {
            var classParts = op.ClassName.split(".");
            var currentPart = window.self[classParts[0]];

            for (int i = 1; i < classParts.length; i++)
                currentPart = currentPart[classParts[i]];

            Action ctor = (Action)currentPart;
            var instance = ObjBuilder.Create(ctor)();

            return (Func<object>)instance[op.MethodName];
        }

        private string GetBrowserName()
        {
            var agent = navigator.userAgent;

            if (agent.indexOf("MSIE") != -1) return "IE";
            if (agent.indexOf("Firefox") != -1) return "Firefox";
            if (agent.indexOf("Chrome") != -1) return "Chrome";

            return null;
        }

        private void CheckAsyncResult(TestResult result, Action done)
        {
            if (result.IsComplete)
            {
                if ((dynamic)(result.ErrorMessage) && result.ErrorMessage.length > 0)
                {
                    ConsoleProxy.log("Test Failed: " + result.ErrorMessage);
                    ClientHost.Service.FailTest(result.ErrorMessage, done);
                }
                else
                {
                    ConsoleProxy.log("Test Passed");
                    ClientHost.Service.PassTest(done);
                }
            }
            else
            {
                var handler = this;
                window.setTimeout((Action)(() =>
                { handler.CheckAsyncResult(result, done); }), 500);
            }
        }

        /// <summary>
        /// Used by the RunTestHandler to create instances of a class dynamically.
        /// </summary>
        [ScriptExternal]
        [ScriptIgnoreNamespace]
        [ScriptName("")]
        private class ObjBuilder
        {
            /// <summary>
            /// Creats a new instance of class.
            /// </summary>
            /// <param name="ctor">The constructor function.</param>
            /// <returns></returns>
            [ScriptName("new ")]
            public static Func<object> Create(Action ctor) { return null; }
        }
    }
}