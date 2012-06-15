using System;
using System.Html;

namespace Knockout
{
    /// <summary>
    /// Provides access to knockout core APIs.
    /// </summary>
    public static class ko
    {
        /// <summary>
        /// Provides access to the extenders object, which can be used
        /// to create extensions to augment observables.
        /// </summary>
        [ScriptField]
        public static dynamic extenders { get; private set; }

        /// <summary>
        /// Provides access to the binding handlers object, which can
        /// be used to add custom bindings.
        /// </summary>
        [ScriptField]
        public static dynamic bindingHandlers { get; private set; }

        /// <summary>
        /// Gets the knockout utility instance.
        /// </summary>
        [ScriptField]
        public static Utils utils { get; private set; }

        /// <summary>
        /// Gets the knockout version string.
        /// </summary>
        [ScriptField]
        public static string version { get; private set; }

        /// <summary>
        /// Applies model bindings to the document of a specific element.
        /// </summary>
        /// <param name="viewModel">The model to bind from.</param>
        /// <param name="node">The node to begin binding at, or null to bind to the entire document.</param>
        public static void applyBindings(object viewModel, HTMLElement node = null)
        {
        }

        /// <summary>
        /// Applies bindings to a single node only.
        /// </summary>
        /// <param name="node">The node to apply bindings to.</param>
        /// <param name="bindings">An explicit set of bindings, or null to use the default bindings.</param>
        /// <param name="viewModel">The view model to bind from.</param>
        public static void applyBindingsToNode(HTMLElement node, object bindings = null, object viewModel = null)
        {
        }

        /// <summary>
        /// Applies bindings to all descendants of a specific node.
        /// </summary>
        /// <param name="viewModel">The view model to bind from.</param>
        /// <param name="node">The node to begin binding at.</param>
        public static void applyBindingsToDescendants(object viewModel, HTMLElement node)
        {
        }

        /// <summary>
        /// Creates an observable object.
        /// </summary>
        /// <typeparam name="T">The underlying data type.</typeparam>
        /// <param name="value">The initial value.</param>
        /// <returns>A new observable object.</returns>
        public static Observable<T> observable<T>(T value)
        {
            return null;
        }

        /// <summary>
        /// Creates a computed observable object.
        /// </summary>
        /// <typeparam name="T">The underlying data type.</typeparam>
        /// <param name="func">The computation function.</param>
        /// <param name="context">The calling context.</param>
        /// <returns>A new computed observable object.</returns>
        public static DependentObservable<T> computed<T>(Func<T> func, object context)
        {
            return null;
        }

        /// <summary>
        /// Creates a computed observable object.
        /// </summary>
        /// <typeparam name="T">The underlying data type.</typeparam>
        /// <param name="func">The computation function.</param>
        /// <param name="context">The calling context.</param>
        /// <returns>A new computed observable object.</returns>
        [Obsolete("dependentObservable is obsolute, use computed instead.")]
        public static DependentObservable<T> dependentObservable<T>(Func<T> func, object context)
        {
            return null;
        }

        /// <summary>
        /// Creates an observable array object.
        /// </summary>
        /// <typeparam name="T">The underlying data type.</typeparam>
        /// <param name="value">The initial array value, or null to create an empty array.</param>
        /// <returns>The new observable array object.</returns>
        public static ObservableArray<T> observableArray<T>(T[] value = null)
        {
            return null;
        }

        /// <summary>
        /// Creates a subscribable object.
        /// </summary>
        /// <typeparam name="T">The data type.</typeparam>
        /// <returns>The new object.</returns>
        public static Subscribable<T> subscribable<T>()
        {
            return null;
        }

        /// <summary>
        /// Clears the binding context from a node and all descendants.
        /// </summary>
        /// <param name="node">The node to clear.</param>
        public static void cleanNode(HTMLElement node)
        {
        }

        /// <summary>
        /// Gets the binding context for a specific node.
        /// </summary>
        /// <param name="node">The target node.</param>
        /// <returns>The associated binding context, or undefined if not applicable.</returns>
        public static BindingContext contextFor(HTMLElement node)
        {
            return null;
        }

        /// <summary>
        /// Gets the view model bound to a specific node.
        /// </summary>
        /// <typeparam name="T">The expected data type.</typeparam>
        /// <param name="node">The target node.</param>
        /// <returns>The associated data, or undefined if not applicable.</returns>
        public static T dataFor<T>(HTMLElement node)
        {
            return default(T);
        }

        /// <summary>
        /// Gets a value indicating whether or not an object is a computed observable.
        /// </summary>
        /// <param name="instance">The target instance.</param>
        /// <returns>True if the object is computed, false otherwise.</returns>
        public static bool isComputed(object instance)
        {
            return false;
        }

        /// <summary>
        /// Gets a value indicating whether or not an object is an observable.
        /// </summary>
        /// <param name="instance">The target instance.</param>
        /// <returns>True if the object is observable, false otherwise.</returns>
        public static bool isObservable(object instance)
        {
            return false;
        }

        /// <summary>
        /// Gets a value indicating whether or not an object is a subscribable.
        /// </summary>
        /// <param name="instance">The target instance.</param>
        /// <returns>True if the object is subscribable, false otherwise.</returns>
        public static bool isSubscribable(object instance)
        {
            return false;
        }

        /// <summary>
        /// Gets a value indicating whether or not an object is a writeable observable.
        /// </summary>
        /// <param name="instance">The target instance.</param>
        /// <returns>True if the object is observable and writeable, false otherwise.</returns>
        public static bool isWriteableObservable(object instance)
        {
            return false;
        }

        /// <summary>
        /// Cleans a node and removes it from the DOM.
        /// </summary>
        /// <param name="node">The node to remove.</param>
        public static void removeNode(HTMLElement node)
        {
        }

        /// <summary>
        /// Clones the view model object graph, returning a plain JS object.
        /// </summary>
        /// <typeparam name="T">The underlying data type.</typeparam>
        /// <param name="viewModel">The view model to clone.</param>
        /// <returns>The newly created object.</returns>
        public static T toJS<T>(object viewModel)
        {
            return default(T);
        }

        /// <summary>
        /// Converts a view model into a JSON string representation.
        /// </summary>
        /// <param name="viewModel">The view model to convert.</param>
        /// <returns>The resulting JSON string.</returns>
        public static string toJSON(object viewModel)
        {
            return null;
        }

        // -- candidates for public API --
        // -------------------------------
        // bindingProvider
        // jqueryTmplTemplateEngine
        // jsonExpressionRewriting
        // memoization
        // nativeTemplateEngine
        // renderTemplate
        // selectExtensions
        // templateEngine
        // templateRewriting
        // templateSources
        // virtualElements
        // -------------------------------
    }
}
