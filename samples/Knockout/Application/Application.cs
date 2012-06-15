using System;
using System.Dom;
using System.Html;
using Knockout;

namespace Application
{
    /// <summary>
    /// Represents the application context.
    /// </summary>
    [ScriptIgnoreNamespace]
    public static class Application
    {
        /// <summary>
        /// Initializes the application.
        /// </summary>
        static Application()
        {
            ko.applyBindings(new ViewModel("Planet", "Earth"));
        }
    }
}
