using System;
using System.Browser;
using System.Dom;

#pragma warning disable 0626
namespace jQueryLib
{
	public class Event
	{

		///<summary>
		///   Returns whether event.stopImmediatePropagation() was ever called on this event object. 
		///</summary>
		public extern bool isImmediatePropagationStopped();

		///<summary>
		///  Keeps the rest of the handlers from being executed and prevents the event from bubbling up the DOM tree.
		///</summary>
		public extern void stopImmediatePropagation();

		///<summary>
		///   Returns whether event.stopPropagation() was ever called on this event object. 
		///</summary>
		public extern bool isPropagationStopped();

		///<summary>
		/// Prevents the event from bubbling up the DOM tree, preventing any parent handlers from being notified of the event.   
		///</summary>
		public extern void stopPropagation();

		///<summary>
		/// Returns whether event.preventDefault() was ever called on this event object. 
		///</summary>
		public extern bool isDefaultPrevented();

		///<summary>
		///  If this method is called, the default action of the event will not be triggered. 
		///</summary>
		public extern void preventDefault();
	}
}
#pragma warning restore 0626
