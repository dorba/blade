//----------------------------------------------
// Supported browser objects.
//----------------------------------------------
using System.Dom;

namespace System.Browser
{
	/// <summary>
	/// The definition for the browser window object.
	/// </summary>
	public partial interface Window : EventTarget
	{
		/// <summary>
		/// Gets a reference to this window.
		/// </summary>
		[ScriptField]
		Window self { get; }

		/// <summary>
		/// Gets the document for this window.
		/// </summary>
		[ScriptField]
		Document document { get; }

		/// <summary>
		/// Gets or sets the name of the window.
		/// </summary>
		[ScriptField]
		string name { get; set; }

		/// <summary>
		/// Gets a reference to this window's location object.
		/// </summary>
		[ScriptField]
		Location location { get; }

		/// <summary>
		/// Gets a reference to this window's history object.
		/// </summary>
		[ScriptField]
		History history { get; }

		/// <summary>
		/// Gets a reference to this window's navigator object.
		/// </summary>
		[ScriptField]
		Navigator navigator { get; }

		/// <summary>
		/// Gets or sets the window status text.
		/// </summary>
		[ScriptField]
		string status { get; set; }

		/// <summary>
		/// Gets the subframes of this window.
		/// </summary>
		[ScriptField]
		Window[] frames { get; }

		/// <summary>
		/// Gets the number of frames in the window.
		/// </summary>
		[ScriptField]
		int length { get; }

		/// <summary>
		/// Gets a reference to the topmost window.
		/// </summary>
		[ScriptField]
		Window top { get; }

		/// <summary>
		/// Gets a reference to the window that opened this window.
		/// </summary>
		[ScriptField]
		Window opener { get; set; }

		/// <summary>
		/// Gets a reference to the parent window.
		/// </summary>
		[ScriptField]
		Window parent { get; }

		/// <summary>
		/// Gets the element in which the window is embedded, if any.
		/// </summary>
		[ScriptField]
		Element frameElement { get; }

		/// <summary>
		/// Closes the window.
		/// </summary>
		void close();

		/// <summary>
		/// Stops window loading.
		/// </summary>
		void stop();

		/// <summary>
		/// Sets focus on the current window.
		/// </summary>
		void focus();

		/// <summary>
		/// Sets focus away from the window.
		/// </summary>
		void blur();

		/// <summary>
		/// Opens a new window.
		/// </summary>
		/// <param name="url">The URL to open.</param>
		/// <returns>The new window.</returns>
		Window open(string url);

		/// <summary>
		/// Opens a new window.
		/// </summary>
		/// <param name="url">The URL to open.</param>
		/// <param name="name">The name to apply to the window.</param>
		/// <returns></returns>
		Window open(string url, string name);

		/// <summary>
		/// Opens a new window.
		/// </summary>
		/// <param name="url">The URL to open.</param>
		/// <param name="name">The name to apply to the window.</param>
		/// <param name="features">A string representing the features available on the window.</param>
		/// <returns></returns>
		Window open(string url, string name, string features);

		/// <summary>
		/// Displays an alert message.
		/// </summary>
		/// <param name="message">The message text.</param>
		void alert(string message);

		/// <summary>
		/// Displays a confirmation message.
		/// </summary>
		/// <param name="message">The message text.</param>
		/// <returns>True if the user selects OK, false otherwise.</returns>
		bool confirm(string message);

		/// <summary>
		/// Displays a prompt requesting input from the user.
		/// </summary>
		/// <param name="message">The prompt message.</param>
		/// <returns>The user entered text.</returns>
		string prompt(string message);

		/// <summary>
		/// Displays a prompt requesting input from the user.
		/// </summary>
		/// <param name="message">The prompt message.</param>
		/// <param name="defaultValue">The initial input value.</param>
		/// <returns>The user entered text.</returns>
		string prompt(string message, string defaultValue);

		/// <summary>
		/// Opens the browser's print dialog.
		/// </summary>
		void print();

		/// <summary>
		/// Displays a modal dialog containing another document.
		/// </summary>
		/// <param name="url">The URL to show.</param>
		/// <returns>A variant return value from the loaded document.</returns>
		object showModalDialog(string url);

		/// <summary>
		/// Displays a modal dialog containing another document.
		/// </summary>
		/// <param name="url">The URL to show.</param>
		/// <param name="argument">Parameters that are passed to the document.</param>
		/// <returns>A variant return value from the loaded document.</returns>
		object showModalDialog(string url, object argument);

		/// <summary>
		/// Sends a message to another window, which may be in a different domain.
		/// </summary>
		/// <param name="message">The message data.</param>
		/// <param name="targetOrigin">The origin for the receiving window.</param>
		void postMessage(object message, string targetOrigin);

		/// <summary>
		/// Schedules a function to run once.
		/// </summary>
		/// <param name="handler">The function to execute.</param>
		/// <param name="delay">The delay, in milliseconds.</param>
		/// <param name="args">Optional arguments to pass to the handler.</param>
		/// <returns>An ID that can be used to clear the timeout.</returns>
		int setTimeout(IFunction handler, int delay, params object[] args);

		/// <summary>
		/// Schedules a code snippet to run once.
		/// </summary>
		/// <param name="code">The code to run.</param>
		/// <param name="delay">The delay, in milliseconds.</param>
		/// <returns>An ID that can be used to clear the timeout.</returns>
		int setTimeout(string code, int delay);

		/// <summary>
		/// Prevents execution of a previously created timeout.
		/// </summary>
		/// <param name="timeoutId">The timeout ID.</param>
		void clearTimeout(int timeoutId);

		/// <summary>
		/// Schedules a function to run at a specific interval.
		/// </summary>
		/// <param name="handler">The function to execute.</param>
		/// <param name="delay">The delay, in milliseconds.</param>
		/// <param name="args">Optional arguments to pass to the handler.</param>
		/// <returns>An ID that can be used to clear the timeout.</returns>
		int setInterval(IFunction handler, int delay, params object[] args);

		/// <summary>
		/// Schedules a code snippet to run at a specific interval.
		/// </summary>
		/// <param name="code">The code to run.</param>
		/// <param name="delay">The delay, in milliseconds.</param>
		/// <returns>An ID that can be used to clear the timeout.</returns>
		int setInterval(string code, int delay);

		/// <summary>
		/// Prevents further execution of a previously created interval.
		/// </summary>
		/// <param name="intervalId">The interval ID.</param>
		void clearInterval(int intervalId);

		#region Events

		[ScriptField]
		IFunction onabort { get; set; }

		[ScriptField]
		IFunction onafterprint { get; set; }

		[ScriptField]
		IFunction onbeforeprint { get; set; }

		[ScriptField]
		IFunction onbeforeunload { get; set; }

		[ScriptField]
		IFunction onblur { get; set; }

		[ScriptField]
		IFunction oncancel { get; set; }

		[ScriptField]
		IFunction oncanplay { get; set; }

		[ScriptField]
		IFunction oncanplaythrough { get; set; }

		[ScriptField]
		IFunction onchange { get; set; }

		[ScriptField]
		IFunction onclick { get; set; }

		[ScriptField]
		IFunction onclose { get; set; }

		[ScriptField]
		IFunction oncontextmenu { get; set; }

		[ScriptField]
		IFunction oncuechange { get; set; }

		[ScriptField]
		IFunction ondblclick { get; set; }

		[ScriptField]
		IFunction ondrag { get; set; }

		[ScriptField]
		IFunction ondragend { get; set; }

		[ScriptField]
		IFunction ondragenter { get; set; }

		[ScriptField]
		IFunction ondragleave { get; set; }

		[ScriptField]
		IFunction ondragover { get; set; }

		[ScriptField]
		IFunction ondragstart { get; set; }

		[ScriptField]
		IFunction ondrop { get; set; }

		[ScriptField]
		IFunction ondurationchange { get; set; }

		[ScriptField]
		IFunction onemptied { get; set; }

		[ScriptField]
		IFunction onended { get; set; }

		[ScriptField]
		IFunction onerror { get; set; }

		[ScriptField]
		IFunction onfocus { get; set; }

		[ScriptField]
		IFunction onhashchange { get; set; }

		[ScriptField]
		IFunction oninput { get; set; }

		[ScriptField]
		IFunction oninvalid { get; set; }

		[ScriptField]
		IFunction onkeydown { get; set; }

		[ScriptField]
		IFunction onkeypress { get; set; }

		[ScriptField]
		IFunction onkeyup { get; set; }

		[ScriptField]
		IFunction onload { get; set; }

		[ScriptField]
		IFunction onloadeddata { get; set; }

		[ScriptField]
		IFunction onloadedmetadata { get; set; }

		[ScriptField]
		IFunction onloadstart { get; set; }

		[ScriptField]
		IFunction onmessage { get; set; }

		[ScriptField]
		IFunction onmousedown { get; set; }

		[ScriptField]
		IFunction onmousemove { get; set; }

		[ScriptField]
		IFunction onmouseout { get; set; }

		[ScriptField]
		IFunction onmouseover { get; set; }

		[ScriptField]
		IFunction onmouseup { get; set; }

		[ScriptField]
		IFunction onmousewheel { get; set; }

		[ScriptField]
		IFunction onoffline { get; set; }

		[ScriptField]
		IFunction ononline { get; set; }

		[ScriptField]
		IFunction onpause { get; set; }

		[ScriptField]
		IFunction onplay { get; set; }

		[ScriptField]
		IFunction onplaying { get; set; }

		[ScriptField]
		IFunction onpagehide { get; set; }

		[ScriptField]
		IFunction onpageshow { get; set; }

		[ScriptField]
		IFunction onpopstate { get; set; }

		[ScriptField]
		IFunction onprogress { get; set; }

		[ScriptField]
		IFunction onratechange { get; set; }

		[ScriptField]
		IFunction onreset { get; set; }

		[ScriptField]
		IFunction onresize { get; set; }

		[ScriptField]
		IFunction onscroll { get; set; }

		[ScriptField]
		IFunction onseeked { get; set; }

		[ScriptField]
		IFunction onseeking { get; set; }

		[ScriptField]
		IFunction onselect { get; set; }

		[ScriptField]
		IFunction onshow { get; set; }

		[ScriptField]
		IFunction onstalled { get; set; }

		[ScriptField]
		IFunction onstorage { get; set; }

		[ScriptField]
		IFunction onsubmit { get; set; }

		[ScriptField]
		IFunction onsuspend { get; set; }

		[ScriptField]
		IFunction ontimeupdate { get; set; }

		[ScriptField]
		IFunction onunload { get; set; }

		[ScriptField]
		IFunction onvolumechange { get; set; }

		[ScriptField]
		IFunction onwaiting { get; set; }

		#endregion
	}
}