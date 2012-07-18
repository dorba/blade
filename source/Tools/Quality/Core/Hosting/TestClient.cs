using System.Collections.Generic;
using System;

namespace Blade.Tools.Quality.Hosting
{
    /// <summary>
    /// Represents the test set for a single client.
    /// </summary>
    public sealed class TestClient
    {
        /// <summary>
        /// Gets the queued test requests.
        /// </summary>
        public Queue<TestExecutionRequest> QueuedTests { get; private set; }

        /// <summary>
        /// Creates a new instance of the class.
        /// </summary>
        public TestClient()
        {
            QueuedTests = new Queue<TestExecutionRequest>();
        }

        /// <summary>
        /// Requests a test to be executed on the client.
        /// </summary>
        /// <param name="request">The request data.</param>
        public void Execute(TestExecutionRequest request)
        {
            QueuedTests.Enqueue(request);
        }
    }

    /// <summary>
    /// Represents a client porcess.
    /// </summary>
    internal class ClientProcess
    {
        /// <summary>
        /// Gets or sets the arguments to pass to the process.
        /// </summary>
        public string ProcessArgs { get; set; }

        /// <summary>
        /// Gets or sets the executable path resolver.
        /// </summary>
        public Func<string> PathResolver { get; set; }
    }
}
