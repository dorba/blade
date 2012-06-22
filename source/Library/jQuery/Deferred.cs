using System;
using System.Browser;
using System.Dom;

#pragma warning disable 0626
namespace jQueryLib
{
	public class Deferred
	{

		///<summary>
		///  Add handlers to be called when the Deferred object generates progress notifications.
		///</summary>
		///<param name="callback">A function, or array of functions, that is called when the Deferred generates progress notifications.</param>
		public extern Deferred progress(Action callback);

		///<summary>
		///  Call the progressCallbacks on a Deferred object with the given context and args. 
		///</summary>
		///<param name="context">Context passed to the progressCallbacks as the this object.</param>
		public extern Deferred notifyWith(Object context);

		///<summary>
		///  Call the progressCallbacks on a Deferred object with the given context and args. 
		///</summary>
		///<param name="context">Context passed to the progressCallbacks as the this object.</param>
		///<param name="args">Optional arguments that are passed to the progressCallbacks.</param>
		public extern Deferred notifyWith(Object context, Object args);

		///<summary>
		///  Call the progressCallbacks on a Deferred object with the given args. 
		///</summary>
		///<param name="args">Optional arguments that are passed to the progressCallbacks.</param>
		public extern Deferred notify(Object args);

		///<summary>
		/// Determine the current state of a Deferred object. 
		///</summary>
		public extern String state();

		///<summary>
		///  Utility method to filter and/or chain Deferreds.  
		///</summary>
		public extern Promise pipe();

		///<summary>
		///  Utility method to filter and/or chain Deferreds.  
		///</summary>
		///<param name="callback">An optional function that is called when the Deferred is resolved.</param>
		public extern Promise pipe(Action callback);

		///<summary>
		///  Utility method to filter and/or chain Deferreds.  
		///</summary>
		///<param name="callback">An optional function that is called when the Deferred is resolved.</param>
		///<param name="callback1">An optional function that is called when the Deferred is rejected.</param>
		public extern Promise pipe(Action callback, Action callback1);

		///<summary>
		///  Utility method to filter and/or chain Deferreds.  
		///</summary>
		///<param name="callback">An optional function that is called when the Deferred is resolved.</param>
		///<param name="callback1">An optional function that is called when the Deferred is rejected.</param>
		///<param name="callback2">An optional function that is called when progress notifications are sent to the Deferred.</param>
		public extern Promise pipe(Action callback, Action callback1, Action callback2);

		///<summary>
		///  Add handlers to be called when the Deferred object is either resolved or rejected. 
		///</summary>
		///<param name="callback">A function, or array of functions, that is called when the Deferred is resolved or rejected.</param>
		public extern Deferred always(Action callback);

		///<summary>
		///  Add handlers to be called when the Deferred object is either resolved or rejected. 
		///</summary>
		///<param name="callback">A function, or array of functions, that is called when the Deferred is resolved or rejected.</param>
		///<param name="callback1">Optional additional functions, or arrays of functions, that are called when the Deferred is resolved or rejected.</param>
		public extern Deferred always(Action callback, Action callback1);

		///<summary>
		///  Return a Deferred's Promise object. 
		///</summary>
		public extern Promise promise();

		///<summary>
		///  Return a Deferred's Promise object. 
		///</summary>
		///<param name="target">Object onto which the promise methods have to be attached</param>
		public extern Promise promise(Object target);

		///<summary>
		///  Resolve a Deferred object and call any doneCallbacks with the given context and args. 
		///</summary>
		///<param name="context">Context passed to the doneCallbacks as the this object.</param>
		public extern Deferred resolveWith(Object context);

		///<summary>
		///  Resolve a Deferred object and call any doneCallbacks with the given context and args. 
		///</summary>
		///<param name="context">Context passed to the doneCallbacks as the this object.</param>
		///<param name="args">An optional array of arguments that are passed to the doneCallbacks.</param>
		public extern Deferred resolveWith(Object context, Array args);

		///<summary>
		///  Reject a Deferred object and call any failCallbacks with the given context and args. 
		///</summary>
		///<param name="context">Context passed to the failCallbacks as the this object.</param>
		public extern Deferred rejectWith(Object context);

		///<summary>
		///  Reject a Deferred object and call any failCallbacks with the given context and args. 
		///</summary>
		///<param name="context">Context passed to the failCallbacks as the this object.</param>
		///<param name="args">An optional array of arguments that are passed to the failCallbacks.</param>
		public extern Deferred rejectWith(Object context, Array args);

		///<summary>
		///  Add handlers to be called when the Deferred object is rejected. 
		///</summary>
		///<param name="callback">A function, or array of functions, that are called when the Deferred is rejected.</param>
		public extern Deferred fail(Action callback);

		///<summary>
		///  Add handlers to be called when the Deferred object is rejected. 
		///</summary>
		///<param name="callback">A function, or array of functions, that are called when the Deferred is rejected.</param>
		///<param name="callback1">Optional additional functions, or arrays of functions, that are called when the Deferred is rejected.</param>
		public extern Deferred fail(Action callback, Action callback1);

		///<summary>
		///  Add handlers to be called when the Deferred object is resolved. 
		///</summary>
		///<param name="callback">A function, or array of functions, that are called when the Deferred is resolved.</param>
		public extern Deferred done(Action callback);

		///<summary>
		///  Add handlers to be called when the Deferred object is resolved. 
		///</summary>
		///<param name="callback">A function, or array of functions, that are called when the Deferred is resolved.</param>
		///<param name="callback1">Optional additional functions, or arrays of functions, that are called when the Deferred is resolved.</param>
		public extern Deferred done(Action callback, Action callback1);

		///<summary>
		///  Add handlers to be called when the Deferred object is resolved or rejected. 
		///</summary>
		///<param name="callback">A function, or array of functions, called when the Deferred is resolved.</param>
		///<param name="callback1">A function, or array of functions, called when the Deferred is rejected.</param>
		public extern Deferred then(Action callback, Action callback1);

		///<summary>
		///  Add handlers to be called when the Deferred object is resolved or rejected. 
		///</summary>
		///<param name="callback">A function, or array of functions, called when the Deferred is resolved.</param>
		///<param name="callback1">A function, or array of functions, called when the Deferred is rejected.</param>
		///<param name="callback2">A function, or array of functions, called when the Deferred notifies progress.</param>
		public extern Deferred then(Action callback, Action callback1, Action callback2);

		///<summary>
		///  Reject a Deferred object and call any failCallbacks with the given args. 
		///</summary>
		///<param name="args">Optional arguments that are passed to the failCallbacks.</param>
		public extern Deferred reject(Object args);

		///<summary>
		///  Determine whether a Deferred object has been rejected. 
		///</summary>
		public extern bool isRejected();

		///<summary>
		///  Determine whether a Deferred object has been resolved. 
		///</summary>
		public extern bool isResolved();

		///<summary>
		///  Resolve a Deferred object and call any doneCallbacks with the given args. 
		///</summary>
		///<param name="args">Optional arguments that are passed to the doneCallbacks.</param>
		public extern Deferred resolve(Object args);
	}
}
#pragma warning restore 0626
