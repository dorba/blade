using System;
using System.Dom;
using System.Html;
using Knockout;

namespace Application
{
    /// <summary>
    /// The application view model.
    /// </summary>
    [ScriptIgnoreNamespace]
    public class ViewModel
    {
        /// <summary>
        /// Gets the first name observable.
        /// </summary>
        [ScriptField]
        public Observable<string> FirstName { get; private set; }

        /// <summary>
        /// Gets the last name observable.
        /// </summary>
        [ScriptField]
        public Observable<string> LastName { get; private set; }

        /// <summary>
        /// Gets the full name observable.
        /// </summary>
        [ScriptField]
        public DependentObservable<string> FullName { get; private set; }

        /// <summary>
        /// Creates a new view model.
        /// </summary>
        /// <param name="first">The initial first name.</param>
        /// <param name="last">The initial last name.</param>
        public ViewModel(string first, string last)
        {
            FirstName = ko.observable(first);
            LastName = ko.observable(last);

            FullName = ko.computed(() =>
            {
                return FirstName() + " " + LastName();
            }, this);
        }
    }
}
