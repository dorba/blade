using System;
using System.Browser;
using System.Dom;

#pragma warning disable 0626
namespace jQueryLib
{
	public class Callback
	{

		///<summary>
		/// Determine if the callbacks have already been called at least once.
		///</summary>
		public extern bool fired();

		///<summary>
		/// Determine if the callbacks list has been locked.
		///</summary>
		public extern bool locked();

		///<summary>
		/// Remove all of the callbacks from a list.
		///</summary>
		public extern void empty();

		///<summary>
		/// Lock a callback list in its current state.
		///</summary>
		public extern void @lock();

		///<summary>
		/// Call all of the callbacks with the given arguments
		///</summary>
		///<param name="arguments">The argument or list of arguments to pass back to the callback list.</param>
		public extern void fire(object arguments);

		///<summary>
		/// Remove a callback or a collection of callbacks from a callback list.
		///</summary>
		///<param name="callback">A function, or array of functions, that are to be removed from the callback list.</param>
		public extern void remove(Action callback);

		///<summary>
		/// Add a callback or a collection of callbacks to a callback list.
		///</summary>
		///<param name="callback">A function, or array of functions, that are to be added to the callback list.</param>
		public extern void add(Action callback);

		///<summary>
		/// Disable a callback list from doing anything more.
		///</summary>
		public extern void disable();

		///<summary>
		/// Determine whether a supplied callback is in a list
		///</summary>
		///<param name="callback">The callback to search for.</param>
		public extern bool has(Action callback);

		///<summary>
		/// Call all callbacks in a list with the given context and arguments.
		///</summary>
		public extern void fireWith();

		///<summary>
		/// Call all callbacks in a list with the given context and arguments.
		///</summary>
		///<param name="context">A reference to the context in which the callbacks in the list should be fired.</param>
		public extern void fireWith(object context);

		///<summary>
		/// Call all callbacks in a list with the given context and arguments.
		///</summary>
		///<param name="context">A reference to the context in which the callbacks in the list should be fired.</param>
		///<param name="args">An argument, or array of arguments, to pass to the callbacks in the list.</param>
		public extern void fireWith(object context, object args);
	}
}
#pragma warning restore 0626
