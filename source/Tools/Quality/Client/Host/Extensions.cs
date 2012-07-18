using System;
using System.Browser;
using Blade.Tools.Quality.Shared;

namespace Blade.Tools.Quality.Host
{
    /// <summary>
    /// Internal helper extension methods.
    /// </summary>
    [ScriptNamespace("Blade")]
    internal static class Extensions
    {
        /// <summary>
        /// Gets a value indicating if a response has any text.
        /// </summary>
        /// <param name="response">The response object.</param>
        /// <returns>True if the response was successful and has text.</returns>
        public static bool HasResponse(this XMLHttpRequest response)
        {
            if (response.status != 200)
                return false;

            if (!(dynamic)response.responseText)
                return false;

            return true;
        }

        /// <summary>
        /// Gets the response text as an object.
        /// </summary>
        /// <param name="response">The response object.</param>
        /// <returns>The resulting object.</returns>
        public static object GetResponseObject(this XMLHttpRequest response)
        {
            var type = response.getResponseHeader("Content-Type");

            if (type.indexOf("application/json") != -1)
            {
                var json = (dynamic)window.self["JSON"];
                if (json && json.parse)
                    return json.parse(response.responseText);

                return window.eval(response.responseText);
            }

            return response.responseText;
        }

        /// <summary>
        /// Gets a value indicating if an object has inner data.
        /// </summary>
        /// <param name="obj">The data object to check.</param>
        /// <returns>True if the object has data.</returns>
        public static bool HasData(this DataObject<object> obj)
        {
            return ((dynamic)obj && ((dynamic)obj).Data);
        }
    }
}