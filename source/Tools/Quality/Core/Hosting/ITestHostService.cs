using System.ServiceModel;
using Blade.Tools.Quality.Shared;

namespace Blade.Tools.Quality.Hosting
{
    /// <summary>
    /// The service contract for the test host service.
    /// </summary>
    [ServiceContract]
    [ServiceKnownType(typeof(RunTestOperation))]
    [ServiceKnownType(typeof(WaitOperation))]
    public interface ITestHostService
    {
        /// <summary>
        /// Requests a new client connection.
        /// </summary>
        /// <returns>The connection data.</returns>
        [OperationContract]
        ConnectionData Connect();

        /// <summary>
        /// Requests the next client operation.
        /// </summary>
        /// <param name="clientId">The client ID.</param>
        /// <returns>The operation data.</returns>
        [OperationContract]
        OperationData GetNextOp(string clientId);

        /// <summary>
        /// Marks the current test as passed.
        /// </summary>
        /// <param name="clientId">The client ID.</param>
        [OperationContract]
        void PassTest(string clientId);

        /// <summary>
        /// Marks the current test as failed.
        /// </summary>
        /// <param name="clientId">The client ID.</param>
        /// <param name="errorMessage">The error message.</param>
        [OperationContract]
        void FailTest(string clientId, string errorMessage);
    }
}
