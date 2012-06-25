//----------------------------------------------
// Commonly supported browser objects.
//----------------------------------------------
using System;
using System.Browser;
using System.Css;
using System.Dom;

/// <summary>
/// Provides access to the methods, properties, and events available through the DOM window object.
/// </summary>
[ScriptName("")]
public sealed class window : Window
{
	internal window() { }

	/// <summary>
	/// Gets a reference to this window.
	/// </summary>
	[ScriptField]
	public static Window self { get; private set; }

	/// <summary>
	/// Gets the document for this window.
	/// </summary>
	[ScriptField]
	public static Document document { get; private set; }

	/// <summary>
	/// Gets or sets the name of the window.
	/// </summary>
	[ScriptField]
	public static string name { get; set; }

	/// <summary>
	/// Gets a reference to this window's location object.
	/// </summary>
	[ScriptField]
	public static Location location { get; private set; }

	/// <summary>
	/// Gets a reference to this window's history object.
	/// </summary>
	[ScriptField]
	public static History history { get; private set; }

	/// <summary>
	/// Gets a reference to this window's navigator object.
	/// </summary>
	[ScriptField]
	public static Navigator navigator { get; private set; }

	/// <summary>
	/// Gets or sets the window status text.
	/// </summary>
	[ScriptField]
	public static string status { get; set; }

	/// <summary>
	/// Gets the subframes of this window.
	/// </summary>
	[ScriptField]
	public static Window[] frames { get; private set; }

	/// <summary>
	/// Gets the number of frames in the window.
	/// </summary>
	[ScriptField]
	public static int length { get { return 0; } }

	/// <summary>
	/// Gets a reference to the topmost window.
	/// </summary>
	[ScriptField]
	public static Window top { get; private set; }

	/// <summary>
	/// Gets a reference to the window that opened this window.
	/// </summary>
	[ScriptField]
	public static Window opener { get; set; }

	/// <summary>
	/// Gets a reference to the parent window.
	/// </summary>
	[ScriptField]
	public static Window parent { get; private set; }

	/// <summary>
	/// Gets the element in which the window is embedded, if any.
	/// </summary>
	[ScriptField]
	public static Element frameElement { get; private set; }

	/// <summary>
	/// Closes the window.
	/// </summary>
	public static void close() { }

	/// <summary>
	/// Stops window loading.
	/// </summary>
	public static void stop() { }

	/// <summary>
	/// Sets focus on the current window.
	/// </summary>
	public static void focus() { }

	/// <summary>
	/// Sets focus away from the window.
	/// </summary>
	public static void blur() { }

	/// <summary>
	/// Opens a new window.
	/// </summary>
	/// <param name="url">The URL to open.</param>
	/// <returns>The new window.</returns>
	public static Window open(string url) { return null; }

	/// <summary>
	/// Opens a new window.
	/// </summary>
	/// <param name="url">The URL to open.</param>
	/// <param name="name">The name to apply to the window.</param>
	/// <returns></returns>
	public static Window open(string url, string name) { return null; }

	/// <summary>
	/// Opens a new window.
	/// </summary>
	/// <param name="url">The URL to open.</param>
	/// <param name="name">The name to apply to the window.</param>
	/// <param name="features">A string representing the features available on the window.</param>
	/// <returns></returns>
	public static Window open(string url, string name, string features) { return null; }

	/// <summary>
	/// Displays an alert message.
	/// </summary>
	/// <param name="message">The message text.</param>
	public static void alert(string message) { }

	/// <summary>
	/// Displays a confirmation message.
	/// </summary>
	/// <param name="message">The message text.</param>
	/// <returns>True if the user selects OK, false otherwise.</returns>
	public static bool confirm(string message) { return false; }

	/// <summary>
	/// Displays a prompt requesting input from the user.
	/// </summary>
	/// <param name="message">The prompt message.</param>
	/// <returns>The user entered text.</returns>
	public static string prompt(string message) { return null; }

	/// <summary>
	/// Displays a prompt requesting input from the user.
	/// </summary>
	/// <param name="message">The prompt message.</param>
	/// <param name="defaultValue">The initial input value.</param>
	/// <returns>The user entered text.</returns>
	public static string prompt(string message, string defaultValue) { return null; }

	/// <summary>
	/// Opens the browser's print dialog.
	/// </summary>
	public static void print() { }

	/// <summary>
	/// Displays a modal dialog containing another document.
	/// </summary>
	/// <param name="url">The URL to show.</param>
	/// <returns>A variant return value from the loaded document.</returns>
	public static object showModalDialog(string url) { return null; }

	/// <summary>
	/// Displays a modal dialog containing another document.
	/// </summary>
	/// <param name="url">The URL to show.</param>
	/// <param name="argument">Parameters that are passed to the document.</param>
	/// <returns>A variant return value from the loaded document.</returns>
	public static object showModalDialog(string url, object argument) { return null; }

	/// <summary>
	/// Sends a message to another window, which may be in a different domain.
	/// </summary>
	/// <param name="message">The message data.</param>
	/// <param name="targetOrigin">The origin for the receiving window.</param>
	public static void postMessage(object message, string targetOrigin) { }

	/// <summary>
	/// Schedules a function to run once.
	/// </summary>
	/// <param name="handler">The function to execute.</param>
	/// <param name="delay">The delay, in milliseconds.</param>
	/// <param name="args">Optional arguments to pass to the handler.</param>
	/// <returns>An ID that can be used to clear the timeout.</returns>
	public static int setTimeout(IFunction handler, int delay, params object[] args) { return 0; }

	/// <summary>
	/// Schedules a code snippet to run once.
	/// </summary>
	/// <param name="code">The code to run.</param>
	/// <param name="delay">The delay, in milliseconds.</param>
	/// <returns>An ID that can be used to clear the timeout.</returns>
	public static int setTimeout(string code, int delay) { return 0; }

	/// <summary>
	/// Prevents execution of a previously created timeout.
	/// </summary>
	/// <param name="timeoutId">The timeout ID.</param>
	public static void clearTimeout(int timeoutId) { }

	/// <summary>
	/// Schedules a function to run at a specific interval.
	/// </summary>
	/// <param name="handler">The function to execute.</param>
	/// <param name="delay">The delay, in milliseconds.</param>
	/// <param name="args">Optional arguments to pass to the handler.</param>
	/// <returns>An ID that can be used to clear the timeout.</returns>
	public static int setInterval(IFunction handler, int delay, params object[] args) { return 0; }

	/// <summary>
	/// Schedules a code snippet to run at a specific interval.
	/// </summary>
	/// <param name="code">The code to run.</param>
	/// <param name="delay">The delay, in milliseconds.</param>
	/// <returns>An ID that can be used to clear the timeout.</returns>
	public static int setInterval(string code, int delay) { return 0; }

	/// <summary>
	/// Prevents further execution of a previously created interval.
	/// </summary>
	/// <param name="intervalId">The interval ID.</param>
	public static void clearInterval(int intervalId) { }

	#region Events

	public static IFunction onabort { get; set; }

	public static IFunction onafterprint { get; set; }

	public static IFunction onbeforeprint { get; set; }

	public static IFunction onbeforeunload { get; set; }

	public static IFunction onblur { get; set; }

	public static IFunction oncancel { get; set; }

	public static IFunction oncanplay { get; set; }

	public static IFunction oncanplaythrough { get; set; }

	public static IFunction onchange { get; set; }

	public static IFunction onclick { get; set; }

	public static IFunction onclose { get; set; }

	public static IFunction oncontextmenu { get; set; }

	public static IFunction oncuechange { get; set; }

	public static IFunction ondblclick { get; set; }

	public static IFunction ondrag { get; set; }

	public static IFunction ondragend { get; set; }

	public static IFunction ondragenter { get; set; }

	public static IFunction ondragleave { get; set; }

	public static IFunction ondragover { get; set; }

	public static IFunction ondragstart { get; set; }

	public static IFunction ondrop { get; set; }

	public static IFunction ondurationchange { get; set; }

	public static IFunction onemptied { get; set; }

	public static IFunction onended { get; set; }

	public static IFunction onerror { get; set; }

	public static IFunction onfocus { get; set; }

	public static IFunction onhashchange { get; set; }

	public static IFunction oninput { get; set; }

	public static IFunction oninvalid { get; set; }

	public static IFunction onkeydown { get; set; }

	public static IFunction onkeypress { get; set; }

	public static IFunction onkeyup { get; set; }

	public static IFunction onload { get; set; }

	public static IFunction onloadeddata { get; set; }

	public static IFunction onloadedmetadata { get; set; }

	public static IFunction onloadstart { get; set; }

	public static IFunction onmessage { get; set; }

	public static IFunction onmousedown { get; set; }

	public static IFunction onmousemove { get; set; }

	public static IFunction onmouseout { get; set; }

	public static IFunction onmouseover { get; set; }

	public static IFunction onmouseup { get; set; }

	public static IFunction onmousewheel { get; set; }

	public static IFunction onoffline { get; set; }

	public static IFunction ononline { get; set; }

	public static IFunction onpause { get; set; }

	public static IFunction onplay { get; set; }

	public static IFunction onplaying { get; set; }

	public static IFunction onpagehide { get; set; }

	public static IFunction onpageshow { get; set; }

	public static IFunction onpopstate { get; set; }

	public static IFunction onprogress { get; set; }

	public static IFunction onratechange { get; set; }

	public static IFunction onreset { get; set; }

	public static IFunction onresize { get; set; }

	public static IFunction onscroll { get; set; }

	public static IFunction onseeked { get; set; }

	public static IFunction onseeking { get; set; }

	public static IFunction onselect { get; set; }

	public static IFunction onshow { get; set; }

	public static IFunction onstalled { get; set; }

	public static IFunction onstorage { get; set; }

	public static IFunction onsubmit { get; set; }

	public static IFunction onsuspend { get; set; }

	public static IFunction ontimeupdate { get; set; }

	public static IFunction onunload { get; set; }

	public static IFunction onvolumechange { get; set; }

	public static IFunction onwaiting { get; set; }

	#endregion

	/// <summary>
	/// Gets the Screen for the window.
	/// </summary>
	[ScriptField]
	public static Screen screen { get; private set; }

	/// <summary>
	/// Gets the width of the content area of the browser window including, if rendered, the vertical scrollbar.
	/// </summary>
	[ScriptField]
	public static int innerWidth { get { return 0; } }

	/// <summary>
	/// Gets the height of the content area of the browser window including, if rendered, the horizontal scrollbar.
	/// </summary>
	[ScriptField]
	public static int innerHeight { get { return 0; } }

	/// <summary>
	/// Gets the number of pixels that the document has already been scrolled horizontally.
	/// </summary>
	[ScriptField]
	public static int scrollX { get { return 0; } }

	/// <summary>
	/// An alias for <see cref="scrollX"/>.
	/// </summary>
	[ScriptField]
	public static int pageXOffset { get { return 0; } }

	/// <summary>
	/// Gets the number of pixels that the document has already been scrolled vertically.
	/// </summary>
	[ScriptField]
	public static int scrollY { get { return 0; } }

	/// <summary>
	/// An alias for <see cref="scrollY"/>.
	/// </summary>
	[ScriptField]
	public static int pageYOffset { get { return 0; } }

	/// <summary>
	/// Gets the horizontal distance of the left border of the user's browser from the left side of the screen.
	/// </summary>
	[ScriptField]
	public static int screenX { get { return 0; } }

	/// <summary>
	/// Gets the vertical distance of the top border of the user's browser from the top side of the screen.
	/// </summary>
	[ScriptField]
	public static int screenY { get { return 0; } }

	/// <summary>
	/// Gets the width of the outside of the browser window.
	/// </summary>
	[ScriptField]
	public static int outerWidth { get { return 0; } }

	/// <summary>
	/// Gets the height of the outside of the browser window.
	/// </summary>
	[ScriptField]
	public static int outerHeight { get { return 0; } }

	/// <summary>
	/// Gets a <see cref="MediaQueryList"/> object representing the specified media query string.
	/// </summary>
	/// <param name="queryString"></param>
	/// <returns>The requested media queries.</returns>
	public static MediaQueryList matchMedia(string queryString) { return null; }

	/// <summary>
	/// Scrolls to a specific place in the document.
	/// </summary>
	/// <param name="x">The X position, in pixels.</param>
	/// <param name="y">The Y position, in pixels.</param>
	public static void scroll(int x, int y) { }

	/// <summary>
	/// Scrolls to a specific place in the document.
	/// </summary>
	/// <param name="x">The X position, in pixels.</param>
	/// <param name="y">The Y position, in pixels.</param>
	public static void scrollTo(int x, int y) { }

	/// <summary>
	/// Scrolls the document relative to its current position.
	/// </summary>
	/// <param name="deltaX">The X position change, in pixels.</param>
	/// <param name="deltaY">The Y position change, in pixels.</param>
	public static void scrollBy(int deltaX, int deltaY) { }

	/// <summary>
	/// Gets the final CSS values resulting from all CSS properties applied to an element.
	/// </summary>
	/// <param name="elt">The target element.</param>
	/// <returns>A CSS style.</returns>
	public static CSSStyleDeclaration getComputedStyle(Element elt) { return null; }

	/// <summary>
	/// Gets the final CSS values resulting from all CSS properties applied to an element.
	/// </summary>
	/// <param name="elt">The target element.</param>
	/// <param name="pseudoElt">The pseudo-element to match.</param>
	/// <returns>A CSS style.</returns>
	public static CSSStyleDeclaration getComputedStyle(Element elt, string pseudoElt) { return null; }

	/// <summary>
	/// Represents the numeric value of infinity.
	/// </summary>
    [ScriptField]
    public static dynamic Infinity { get; private set; }

	/// <summary>
	/// Represents the numeric value of a non-numeric value
	/// </summary>
    [ScriptField]
    public static dynamic NaN { get; private set; }

	/// <summary>
	/// Represents the undefined object.
	/// </summary>
    [ScriptField]
	public static dynamic undefined { get; private set; }

	/// <summary>
	/// Replaces each UTF-8 escape sequence with the character that it represents.
	/// </summary>
	/// <param name="uri">The URI to decode.</param>
	/// <returns>A decoded string.</returns>
	public static string decodeURI(string uri) { return null; }

	/// <summary>
	/// Replaces each UTF-8 escape sequence with the character representation.
	/// </summary>
	/// <param name="uriComponent">The URI component to decode.</param>
	/// <returns>A decoded string.</returns>
	public static string decodeURIComponent(string uriComponent) { return null; }

	/// <summary>
	/// Replaces applicable characters of a URI with their UTF-8 encoded representation.
	/// </summary>
	/// <param name="uri">The URI to encode.</param>
	/// <returns>An encoded string.</returns>
	public static string encodeURI(string uri) { return null; }

	/// <summary>
	/// Replaces applicable characters of a URI component with their UTF-8 encoded representation.
	/// </summary>
	/// <param name="uriComponent">The URI component.</param>
	/// <returns>An encoded string.</returns>
	public static string encodeURIcomponent(string uriComponent) { return null; }

	/// <summary>
	/// Executes a script at runtime.
	/// </summary>
	/// <param name="value">The script text.</param>
    public static object eval(string value) { return null; }

	/// <summary>
	/// Gets a value indicating whether or not the input is a finite number.
	/// </summary>
	/// <param name="value">The input value.</param>
	/// <returns>True is the number is finite, false otherwise.</returns>
	public static bool isFinite(INumber value) { return false; }

	/// <summary>
	/// Gets a value indicating whether or not the input is NaN.
	/// </summary>
	/// <param name="value">The input value.</param>
	/// <returns>True is the number is NaN, false otherwise.</returns>
	public static bool isNaN(INumber value) { return false; }

	/// <summary>
	/// Converts a string to a floating point numeric value.
	/// </summary>
	/// <param name="value">The input string.</param>
	/// <returns>A floating point number.</returns>
	public static double parseFloat(string value) { return 0; }

	/// <summary>
	/// Converts a string to an integer value.
	/// </summary>
	/// <param name="value">The input string.</param>
	/// <returns>An integer.</returns>
	public static int parseInt(string value) { return 0; }

	/// <summary>
	/// Registers an event listener with the target.
	/// </summary>
	/// <param name="type">The event type name.</param>
	/// <param name="listener">The listener to register.</param>
	/// <param name="useCapture">Whether or not to use capture.</param>
	public static void addEventListener(string type, EventListener listener, bool useCapture) { }

    /// <summary>
    /// Registers an event handler with the target.
    /// </summary>
    /// <param name="type">The event type name.</param>
    /// <param name="handler">The event handler function.</param>
    /// <param name="useCapture">Whether or not to use capture.</param>
	public static void addEventListener(string type, EventHandler handler, bool useCapture) { }

	/// <summary>
	/// Removes an event listener from a target.
	/// </summary>
	/// <param name="type">The event type name.</param>
	/// <param name="listener">The listener to remove.</param>
	/// <param name="useCapture">Whether or not capture was used.</param>
	public static void removeEventListener(string type, EventListener listener, bool useCapture) { }

	/// <summary>
	/// Dispatches an event through the taret.
	/// </summary>
	/// <param name="evt">The event object.</param>
	/// <returns>True if the event completes, false otherwise.</returns>
	public static bool dispatchEvent(Event evt) { return false; }

	#region Explicit Interface Implementation

	Window Window.self { get { return null; } }

	Document Window.document { get { return null; } }

	string Window.name { get; set; }

	Location Window.location { get { return null; } }

	History Window.history { get { return null; } }

	Navigator Window.navigator { get { return null; } }

	string Window.status { get; set; }

	Window[] Window.frames { get { return null; } }

	int Window.length { get { return 0; } }

	Window Window.top { get { return null; } }

	Window Window.opener { get; set; }

	Window Window.parent { get { return null; } }

	Element Window.frameElement { get { return null; } }

	void Window.close() { }

	void Window.stop() { }

	void Window.focus() { }

	void Window.blur() { }

	Window Window.open(string url) { return null; }

	Window Window.open(string url, string name) { return null; }

	Window Window.open(string url, string name, string features) { return null; }

	void Window.alert(string message) { }

	bool Window.confirm(string message) { return false; }

	string Window.prompt(string message) { return null; }

	string Window.prompt(string message, string defaultValue) { return null; }

	void Window.print() { }

	object Window.showModalDialog(string url) { return null; }

	object Window.showModalDialog(string url, object argument) { return null; }

	void Window.postMessage(object message, string targetOrigin) { }

	int Window.setTimeout(IFunction handler, int delay, params object[] args) { return 0; }

	int Window.setTimeout(string code, int delay) { return 0; }

	void Window.clearTimeout(int timeoutId) { }

	int Window.setInterval(IFunction handler, int delay, params object[] args) { return 0; }

	int Window.setInterval(string code, int delay) { return 0; }

	void Window.clearInterval(int intervalId) { }

	IFunction Window.onabort { get; set; }

	IFunction Window.onafterprint { get; set; }

	IFunction Window.onbeforeprint { get; set; }

	IFunction Window.onbeforeunload { get; set; }

	IFunction Window.onblur { get; set; }

	IFunction Window.oncancel { get; set; }

	IFunction Window.oncanplay { get; set; }

	IFunction Window.oncanplaythrough { get; set; }

	IFunction Window.onchange { get; set; }

	IFunction Window.onclick { get; set; }

	IFunction Window.onclose { get; set; }

	IFunction Window.oncontextmenu { get; set; }

	IFunction Window.oncuechange { get; set; }

	IFunction Window.ondblclick { get; set; }

	IFunction Window.ondrag { get; set; }

	IFunction Window.ondragend { get; set; }

	IFunction Window.ondragenter { get; set; }

	IFunction Window.ondragleave { get; set; }

	IFunction Window.ondragover { get; set; }

	IFunction Window.ondragstart { get; set; }

	IFunction Window.ondrop { get; set; }

	IFunction Window.ondurationchange { get; set; }

	IFunction Window.onemptied { get; set; }

	IFunction Window.onended { get; set; }

	IFunction Window.onerror { get; set; }

	IFunction Window.onfocus { get; set; }

	IFunction Window.onhashchange { get; set; }

	IFunction Window.oninput { get; set; }

	IFunction Window.oninvalid { get; set; }

	IFunction Window.onkeydown { get; set; }

	IFunction Window.onkeypress { get; set; }

	IFunction Window.onkeyup { get; set; }

	IFunction Window.onload { get; set; }

	IFunction Window.onloadeddata { get; set; }

	IFunction Window.onloadedmetadata { get; set; }

	IFunction Window.onloadstart { get; set; }

	IFunction Window.onmessage { get; set; }

	IFunction Window.onmousedown { get; set; }

	IFunction Window.onmousemove { get; set; }

	IFunction Window.onmouseout { get; set; }

	IFunction Window.onmouseover { get; set; }

	IFunction Window.onmouseup { get; set; }

	IFunction Window.onmousewheel { get; set; }

	IFunction Window.onoffline { get; set; }

	IFunction Window.ononline { get; set; }

	IFunction Window.onpause { get; set; }

	IFunction Window.onplay { get; set; }

	IFunction Window.onplaying { get; set; }

	IFunction Window.onpagehide { get; set; }

	IFunction Window.onpageshow { get; set; }

	IFunction Window.onpopstate { get; set; }

	IFunction Window.onprogress { get; set; }

	IFunction Window.onratechange { get; set; }

	IFunction Window.onreset { get; set; }

	IFunction Window.onresize { get; set; }

	IFunction Window.onscroll { get; set; }

	IFunction Window.onseeked { get; set; }

	IFunction Window.onseeking { get; set; }

	IFunction Window.onselect { get; set; }

	IFunction Window.onshow { get; set; }

	IFunction Window.onstalled { get; set; }

	IFunction Window.onstorage { get; set; }

	IFunction Window.onsubmit { get; set; }

	IFunction Window.onsuspend { get; set; }

	IFunction Window.ontimeupdate { get; set; }

	IFunction Window.onunload { get; set; }

	IFunction Window.onvolumechange { get; set; }

	IFunction Window.onwaiting { get; set; }

	Screen Window.screen { get { return null; } }

	int Window.innerWidth { get { return 0; } }

	int Window.innerHeight { get { return 0; } }

	int Window.scrollX { get { return 0; } }

	int Window.pageXOffset { get { return 0; } }

	int Window.scrollY { get { return 0; } }

	int Window.pageYOffset { get { return 0; } }

	int Window.screenX { get { return 0; } }

	int Window.screenY { get { return 0; } }

	int Window.outerWidth { get { return 0; } }

	int Window.outerHeight { get { return 0; } }

	MediaQueryList Window.matchMedia(string queryString) { return null; }

	void Window.scroll(int x, int y) { }

	void Window.scrollTo(int x, int y) { }

	void Window.scrollBy(int deltaX, int deltaY) { }

	CSSStyleDeclaration Window.getComputedStyle(Element elt) { return null; }

	CSSStyleDeclaration Window.getComputedStyle(Element elt, string pseudoElt) { return null; }

	object Window.Infinity { get { return null; } }

	object Window.NaN { get { return null; } }

	object Window.undefined { get { return null; } }

	string Window.decodeURI(string uri) { return null; }

	string Window.decodeURIComponent(string uriComponent) { return null; }

	string Window.encodeURI(string uri) { return null; }

	string Window.encodeURIcomponent(string uriComponent) { return null; }

    object Window.eval(string value) { return null; }

	bool Window.isFinite(INumber value) { return false; }

	bool Window.isNaN(INumber value) { return false; }

	double Window.parseFloat(string value) { return 0; }

	int Window.parseInt(string value) { return 0; }

	void EventTarget.addEventListener(string type, EventListener listener, bool useCapture) { }

	void EventTarget.removeEventListener(string type, EventListener listener, bool useCapture) { }

	bool EventTarget.dispatchEvent(Event evt) { return false; }

	#endregion
}
