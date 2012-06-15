using System;
using System.Html;

namespace Knockout
{
    /// <summary>
    /// Represents a custom binding handler.
    /// </summary>
    public abstract class BindingHandler
    {
        /// <summary>
        /// Called once when the binding is first applied to an element.
        /// </summary>
        /// <param name="element">The DOM element involved in this binding</param>
        /// <param name="valueAccessor">A function that can be called to get the current model property that is involved in this binding.</param>
        /// <param name="allBindingsAccessor">A function that can be called to get all the model properties bound to this DOM element.</param>
        /// <param name="viewModel">The view model object that is bound to the element.</param>
        public virtual void init(HTMLElement element, Func<object> valueAccessor, Func<dynamic> allBindingsAccessor, object viewModel)
        {
        }

        /// <summary>
        /// Called when the binding is first applied to an element, and again during any observable value change.
        /// </summary>
        /// <param name="element">The DOM element involved in this binding</param>
        /// <param name="valueAccessor">A function that can be called to get the current model property that is involved in this binding.</param>
        /// <param name="allBindingsAccessor">A function that can be called to get all the model properties bound to this DOM element.</param>
        /// <param name="viewModel">The view model object that is bound to the element.</param>
        public virtual void update(HTMLElement element, Func<object> valueAccessor, Func<dynamic> allBindingsAccessor, object viewModel)
        {
        }
    }
}
