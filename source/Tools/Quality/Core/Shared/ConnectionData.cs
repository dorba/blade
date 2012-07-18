using System;

namespace Blade.Tools.Quality.Shared
{
    /// <summary>
    /// The entity provided as a result of a connection request.
    /// </summary>
    [ScriptObjectLiteral]
    public class ConnectionData
    {
        /// <summary>
        /// The client ID.
        /// </summary>
        public string ClientId { get; set; }
    }
}
