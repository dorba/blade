using System;
using System.Browser;
using System.Dom;

#pragma warning disable 0626
namespace jQueryLib
{
    [ScriptIgnoreNamespace]
    [ScriptName("$")]
    public class jQuery
    {
        /// <summary>
        /// Gets the number of items in the jQuery object.
        /// </summary>
        [ScriptField]
        public int length { get; private set; }

        ///<summary>
        /// A multi-purpose callbacks list object that provides a powerful way to manage callback lists.
        ///</summary>
        ///<param name="flags">An optional list of space-separated flags that change how the callback list behaves.</param>
        public extern static void Callbacks(string flags);

        ///<summary>
        /// Remove an event handler.
        ///</summary>
        ///<param name="events">One or more space-separated event types and optional namespaces, or just namespaces, such as "click", "keydown.myPlugin", or ".myPlugin".</param>
        public extern jQuery off(string events);

        ///<summary>
        /// Remove an event handler.
        ///</summary>
        ///<param name="events">One or more space-separated event types and optional namespaces, or just namespaces, such as "click", "keydown.myPlugin", or ".myPlugin".</param>
        ///<param name="selector">A selector which should match the one originally passed to .on() when attaching event handlers.</param>
        public extern jQuery off(string events, string selector);

        ///<summary>
        /// Remove an event handler.
        ///</summary>
        ///<param name="events">One or more space-separated event types and optional namespaces, or just namespaces, such as "click", "keydown.myPlugin", or ".myPlugin".</param>
        ///<param name="selector">A selector which should match the one originally passed to .on() when attaching event handlers.</param>
        ///<param name="callback">A handler function previously attached for the event(s), or the special value false.</param>
        public extern jQuery off(string events, string selector, Action<Event> callback);

        ///<summary>
        /// Remove an event handler.
        ///</summary>
        ///<param name="eventsmap">A map where the string keys represent one or more space-separated event types and optional namespaces, and the values represent handler functions previously attached for the event(s).</param>
        public extern jQuery off(object eventsmap);

        ///<summary>
        /// Remove an event handler.
        ///</summary>
        ///<param name="eventsmap">A map where the string keys represent one or more space-separated event types and optional namespaces, and the values represent handler functions previously attached for the event(s).</param>
        ///<param name="selector">A selector which should match the one originally passed to .on() when attaching event handlers.</param>
        public extern jQuery off(object eventsmap, string selector);

        ///<summary>
        /// Attach an event handler function for one or more events to the selected elements.
        ///</summary>
        ///<param name="events">One or more space-separated event types and optional namespaces, such as "click" or "keydown.myPlugin".</param>
        ///<param name="selector">A selector string to filter the descendants of the selected elements that trigger the event. If the selector is null or omitted, the event is always triggered when it reaches the selected element.</param>
        ///<param name="data">Data to be passed to the handler in event.data when an event is triggered.</param>
        ///<param name="callback">A function to execute when the event is triggered. The value false is also allowed as a shorthand for a function that simply does return false.</param>
        public extern jQuery on(string events, string selector, object data, Action<Event> callback);

        ///<summary>
        /// Attach an event handler function for one or more events to the selected elements.
        ///</summary>
        ///<param name="eventsmap">A map in which the string keys represent one or more space-separated event types and optional namespaces, and the values represent a handler function to be called for the event(s).</param>
        public extern jQuery on(object eventsmap);

        ///<summary>
        /// Attach an event handler function for one or more events to the selected elements.
        ///</summary>
        ///<param name="eventsmap">A map in which the string keys represent one or more space-separated event types and optional namespaces, and the values represent a handler function to be called for the event(s).</param>
        ///<param name="selector">A selector string to filter the descendants of the selected elements that will call the handler. If the selector is null or omitted, the handler is always called when it reaches the selected element.</param>
        public extern jQuery on(object eventsmap, string selector);

        ///<summary>
        /// Attach an event handler function for one or more events to the selected elements.
        ///</summary>
        ///<param name="eventsmap">A map in which the string keys represent one or more space-separated event types and optional namespaces, and the values represent a handler function to be called for the event(s).</param>
        ///<param name="selector">A selector string to filter the descendants of the selected elements that will call the handler. If the selector is null or omitted, the handler is always called when it reaches the selected element.</param>
        ///<param name="data">Data to be passed to the handler in event.data when an event occurs.</param>
        public extern jQuery on(object eventsmap, string selector, object data);

        ///<summary>
        /// Determines whether its argument is a number.
        ///</summary>
        ///<param name="value">The value to be tested.</param>
        public extern static bool isNumeric(Object value);

        ///<summary>
        ///  Return a Promise object to observe when all actions of a certain type bound to the collection, queued or not, have finished. 
        ///</summary>
        public extern Promise promise();

        ///<summary>
        ///  Return a Promise object to observe when all actions of a certain type bound to the collection, queued or not, have finished. 
        ///</summary>
        ///<param name="type">The type of queue that needs to be observed.</param>
        public extern Promise promise(string type);

        ///<summary>
        ///  Return a Promise object to observe when all actions of a certain type bound to the collection, queued or not, have finished. 
        ///</summary>
        ///<param name="type">The type of queue that needs to be observed.</param>
        ///<param name="target">Object onto which the promise methods have to be attached</param>
        public extern Promise promise(string type, Object target);

        ///<summary>
        /// Remove a property for the set of matched elements.
        ///</summary>
        ///<param name="propertyName">The name of the property to set.</param>
        public extern jQuery removeProp(string propertyName);

        ///<summary>
        /// Get the value of a property for the first element in the set of matched elements.
        ///</summary>
        ///<param name="propertyName">The name of the property to get.</param>
        public extern String prop(string propertyName);

        ///<summary>
        /// Set one or more properties for the set of matched elements.
        ///</summary>
        ///<param name="propertyName">The name of the property to set.</param>
        ///<param name="value">A value to set for the property.</param>
        public extern jQuery prop(string propertyName, string value);

        ///<summary>
        /// Set one or more properties for the set of matched elements.
        ///</summary>
        ///<param name="propertyName">The name of the property to set.</param>
        ///<param name="value">A value to set for the property.</param>
        public extern jQuery prop(string propertyName, Number value);

        ///<summary>
        /// Set one or more properties for the set of matched elements.
        ///</summary>
        ///<param name="propertyName">The name of the property to set.</param>
        ///<param name="value">A value to set for the property.</param>
        public extern jQuery prop(string propertyName, bool value);

        ///<summary>
        /// Set one or more properties for the set of matched elements.
        ///</summary>
        ///<param name="map">A map of property-value pairs to set.</param>
        public extern jQuery prop(object map);

        ///<summary>
        /// Set one or more properties for the set of matched elements.
        ///</summary>
        ///<param name="propertyName">The name of the property to set.</param>
        ///<param name="callback">A function returning the value to set. Receives the index position of the element in the set and the old property value as arguments. Within the function, the keyword this refers to the current element.</param>
        public extern jQuery prop(string propertyName, Action<int, object> callback);

        ///<summary>
        /// Handle custom Ajax options or modify existing options before each request is sent and before they are processed by $.ajax().
        ///</summary>
        ///<param name="dataTypes">An optional string containing one or more space-separated dataTypes</param>
        ///<param name="callback">A handler to set default values for future Ajax requests.</param>
        public extern static void ajaxPrefilter(string dataTypes, Action<object, object, jqXHR> callback);

        ///<summary>
        /// Holds or releases the execution of jQuery's ready event.
        ///</summary>
        ///<param name="hold">Indicates whether the ready hold is being requested or released</param>
        public extern static void holdReady(bool hold);

        ///<summary>
        /// Determine whether an element has any jQuery data associated with it.
        ///</summary>
        ///<param name="element">A DOM element to be checked for data.</param>
        public extern static bool hasData(Element element);

        ///<summary>
        /// Return a number representing the current time.
        ///</summary>
        public extern static Number now();

        ///<summary>
        /// Parses a string into an XML document.
        ///</summary>
        ///<param name="data">a well-formed XML string to be parsed</param>
        public extern static Document parseXML(string data);

        ///<summary>
        /// Provides a way to execute callback functions based on one or more objects, usually Deferred objects that represent asynchronous events.
        ///</summary>
        ///<param name="deferreds">One or more Deferred objects, or plain JavaScript objects.</param>
        public extern static Promise when(Deferred deferreds);

        ///<summary>
        /// Creates a new copy of jQuery whose properties and methods can be modified without affecting the original jQuery object.
        ///</summary>
        public extern static jQuery sub();

        ///<summary>
        /// Display or hide the matched elements by animating their opacity.
        ///</summary>
        public extern jQuery fadeToggle();

        ///<summary>
        /// Display or hide the matched elements by animating their opacity.
        ///</summary>
        ///<param name="duration">A string or number determining how long the animation will run.</param>
        public extern jQuery fadeToggle(string duration);

        ///<summary>
        /// Display or hide the matched elements by animating their opacity.
        ///</summary>
        ///<param name="duration">A string or number determining how long the animation will run.</param>
        ///<param name="easing">A string indicating which easing function to use for the transition.</param>
        public extern jQuery fadeToggle(string duration, string easing);

        ///<summary>
        /// Display or hide the matched elements by animating their opacity.
        ///</summary>
        ///<param name="duration">A string or number determining how long the animation will run.</param>
        ///<param name="easing">A string indicating which easing function to use for the transition.</param>
        ///<param name="callback">A function to call once the animation is complete.</param>
        public extern jQuery fadeToggle(string duration, string easing, Action callback);

        ///<summary>
        /// Display or hide the matched elements by animating their opacity.
        ///</summary>
        ///<param name="duration">A string or number determining how long the animation will run.</param>
        public extern jQuery fadeToggle(Number duration);

        ///<summary>
        /// Display or hide the matched elements by animating their opacity.
        ///</summary>
        ///<param name="duration">A string or number determining how long the animation will run.</param>
        ///<param name="easing">A string indicating which easing function to use for the transition.</param>
        public extern jQuery fadeToggle(Number duration, string easing);

        ///<summary>
        /// Display or hide the matched elements by animating their opacity.
        ///</summary>
        ///<param name="duration">A string or number determining how long the animation will run.</param>
        ///<param name="easing">A string indicating which easing function to use for the transition.</param>
        ///<param name="callback">A function to call once the animation is complete.</param>
        public extern jQuery fadeToggle(Number duration, string easing, Action callback);

        ///<summary>
        /// Determine the internal JavaScript [[Class]] of an object.
        ///</summary>
        ///<param name="obj">Object to get the internal JavaScript [[Class]] of.</param>
        public extern static String type(Object obj);

        ///<summary>
        /// Determine whether the argument is a window.
        ///</summary>
        ///<param name="obj">Object to test whether or not it is a window.</param>
        public extern static bool isWindow(Object obj);

        ///<summary>
        /// Bind two or more handlers to the matched elements, to be executed on alternate clicks.
        ///</summary>
        ///<param name="callback">A function to execute every even time the element is clicked.</param>
        ///<param name="callback1">A function to execute every odd time the element is clicked.</param>
        public extern jQuery toggle(Action<Event> callback, Action<Event> callback1);

        ///<summary>
        /// Bind two or more handlers to the matched elements, to be executed on alternate clicks.
        ///</summary>
        ///<param name="callback">A function to execute every even time the element is clicked.</param>
        ///<param name="callback1">A function to execute every odd time the element is clicked.</param>
        ///<param name="callback2">Additional handlers to cycle through after clicks.</param>
        public extern jQuery toggle(Action<Event> callback, Action<Event> callback1, Action<Event> callback2);

        ///<summary>
        /// Remove a handler from the event for all elements which match the current selector, based upon a specific set of root elements.
        ///</summary>
        public extern jQuery undelegate();

        ///<summary>
        /// Remove a handler from the event for all elements which match the current selector, based upon a specific set of root elements.
        ///</summary>
        ///<param name="selector">A selector which will be used to filter the event results.</param>
        ///<param name="eventType">A string containing a JavaScript event type, such as "click" or "keydown"</param>
        public extern jQuery undelegate(string selector, string eventType);

        ///<summary>
        /// Remove a handler from the event for all elements which match the current selector, based upon a specific set of root elements.
        ///</summary>
        ///<param name="selector">A selector which will be used to filter the event results.</param>
        ///<param name="eventType">A string containing a JavaScript event type, such as "click" or "keydown"</param>
        ///<param name="callback">A function to execute at the time the event is triggered.</param>
        public extern jQuery undelegate(string selector, string eventType, Action<Event> callback);

        ///<summary>
        /// Remove a handler from the event for all elements which match the current selector, based upon a specific set of root elements.
        ///</summary>
        ///<param name="selector">A selector which will be used to filter the event results.</param>
        ///<param name="events">A map of one or more event types and previously bound functions to unbind from them.</param>
        public extern jQuery undelegate(string selector, object events);

        ///<summary>
        /// Remove a handler from the event for all elements which match the current selector, based upon a specific set of root elements.
        ///</summary>
        ///<param name="namespace">A string containing a namespace to unbind all events from.</param>
        public extern jQuery undelegate(string @namespace);

        ///<summary>
        /// Attach a handler to one or more events for all elements that match the selector, now or in the future, based on a specific set of root elements.
        ///</summary>
        ///<param name="selector">A selector to filter the elements that trigger the event.</param>
        ///<param name="eventType">A string containing one or more space-separated JavaScript event types, such as "click" or "keydown," or custom event names.</param>
        ///<param name="callback">A function to execute at the time the event is triggered.</param>
        public extern jQuery @delegate(string selector, string eventType, Action<Event> callback);

        ///<summary>
        /// Attach a handler to one or more events for all elements that match the selector, now or in the future, based on a specific set of root elements.
        ///</summary>
        ///<param name="selector">A selector to filter the elements that trigger the event.</param>
        ///<param name="eventType">A string containing one or more space-separated JavaScript event types, such as "click" or "keydown," or custom event names.</param>
        ///<param name="eventData">A map of data that will be passed to the event handler.</param>
        ///<param name="callback">A function to execute at the time the event is triggered.</param>
        public extern jQuery @delegate(string selector, string eventType, Object eventData, Action<Event> callback);

        ///<summary>
        /// Attach a handler to one or more events for all elements that match the selector, now or in the future, based on a specific set of root elements.
        ///</summary>
        ///<param name="selector">A selector to filter the elements that trigger the event.</param>
        ///<param name="events">A map of one or more event types and functions to execute for them.</param>
        public extern jQuery @delegate(string selector, object events);

        ///<summary>
        /// Takes a string and throws an exception containing it.
        ///</summary>
        ///<param name="message">The message to send out.</param>
        public extern static void error(string message);

        ///<summary>
        /// Takes a well-formed JSON string and returns the resulting JavaScript object.
        ///</summary>
        ///<param name="json">The JSON string to parse.</param>
        public extern static Object parseJSON(string json);

        ///<summary>
        /// Takes a function and returns a new one that will always have a particular context.
        ///</summary>
        ///<param name="callback">The function whose context will be changed.</param>
        ///<param name="context">The object to which the context (this) of the function should be set.</param>
        public extern static Function proxy(Action callback, Object context);

        ///<summary>
        /// Takes a function and returns a new one that will always have a particular context.
        ///</summary>
        ///<param name="context">The object to which the context of the function should be set.</param>
        ///<param name="name">The name of the function whose context will be changed (should be a property of the context object).</param>
        public extern static Function proxy(Object context, string name);

        ///<summary>
        /// Bind an event handler to the "focusout" JavaScript event.
        ///</summary>
        ///<param name="callback">A function to execute each time the event is triggered.</param>
        public extern jQuery focusout(Action<Event> callback);

        ///<summary>
        /// Bind an event handler to the "focusout" JavaScript event.
        ///</summary>
        ///<param name="eventData">A map of data that will be passed to the event handler.</param>
        ///<param name="callback">A function to execute each time the event is triggered.</param>
        public extern jQuery focusout(Object eventData, Action<Event> callback);

        ///<summary>
        /// Bind an event handler to the "focusin" event.
        ///</summary>
        ///<param name="callback">A function to execute each time the event is triggered.</param>
        public extern jQuery focusin(Action<Event> callback);

        ///<summary>
        /// Bind an event handler to the "focusin" event.
        ///</summary>
        ///<param name="eventData">A map of data that will be passed to the event handler.</param>
        ///<param name="callback">A function to execute each time the event is triggered.</param>
        public extern jQuery focusin(Object eventData, Action<Event> callback);

        ///<summary>
        /// Reduce the set of matched elements to those that have a descendant that matches the selector or DOM element.
        ///</summary>
        ///<param name="selector">A string containing a selector expression to match elements against.</param>
        public extern jQuery has(string selector);

        ///<summary>
        /// Reduce the set of matched elements to those that have a descendant that matches the selector or DOM element.
        ///</summary>
        ///<param name="contained">A DOM element to match elements against.</param>
        public extern jQuery has(Element contained);

        ///<summary>
        /// Check to see if a DOM element is within another DOM element.
        ///</summary>
        ///<param name="container">The DOM element that may contain the other element.</param>
        ///<param name="contained">The DOM element that may be contained by the other element.</param>
        public extern static bool contains(Element container, Element contained);

        ///<summary>
        /// An empty function.
        ///</summary>
        public extern static Function noop();

        ///<summary>
        /// Set a timer to delay execution of subsequent items in the queue.
        ///</summary>
        ///<param name="duration">An integer indicating the number of milliseconds to delay execution of the next item in the queue.</param>
        public extern jQuery delay(int duration);

        ///<summary>
        /// Set a timer to delay execution of subsequent items in the queue.
        ///</summary>
        ///<param name="duration">An integer indicating the number of milliseconds to delay execution of the next item in the queue.</param>
        ///<param name="queueName">A string containing the name of the queue. Defaults to fx, the standard effects queue.</param>
        public extern jQuery delay(int duration, string queueName);

        ///<summary>
        /// Get the ancestors of each element in the current set of matched elements, up to but not including the element matched by the selector, DOM node, or jQuery object.
        ///</summary>
        public extern jQuery parentsUntil();

        ///<summary>
        /// Get the ancestors of each element in the current set of matched elements, up to but not including the element matched by the selector, DOM node, or jQuery object.
        ///</summary>
        ///<param name="selector">A string containing a selector expression to indicate where to stop matching ancestor elements.</param>
        public extern jQuery parentsUntil(string selector);

        ///<summary>
        /// Get the ancestors of each element in the current set of matched elements, up to but not including the element matched by the selector, DOM node, or jQuery object.
        ///</summary>
        ///<param name="selector">A string containing a selector expression to indicate where to stop matching ancestor elements.</param>
        ///<param name="filter">A string containing a selector expression to match elements against.</param>
        public extern jQuery parentsUntil(string selector, string filter);

        ///<summary>
        /// Get the ancestors of each element in the current set of matched elements, up to but not including the element matched by the selector, DOM node, or jQuery object.
        ///</summary>
        ///<param name="element">A DOM node or jQuery object indicating where to stop matching ancestor elements.</param>
        public extern jQuery parentsUntil(Element element);

        ///<summary>
        /// Get the ancestors of each element in the current set of matched elements, up to but not including the element matched by the selector, DOM node, or jQuery object.
        ///</summary>
        ///<param name="element">A DOM node or jQuery object indicating where to stop matching ancestor elements.</param>
        ///<param name="filter">A string containing a selector expression to match elements against.</param>
        public extern jQuery parentsUntil(Element element, string filter);

        ///<summary>
        /// Get all preceding siblings of each element up to but not including the element matched by the selector, DOM node, or jQuery object.
        ///</summary>
        public extern jQuery prevUntil();

        ///<summary>
        /// Get all preceding siblings of each element up to but not including the element matched by the selector, DOM node, or jQuery object.
        ///</summary>
        ///<param name="selector">A string containing a selector expression to indicate where to stop matching preceding sibling elements.</param>
        public extern jQuery prevUntil(string selector);

        ///<summary>
        /// Get all preceding siblings of each element up to but not including the element matched by the selector, DOM node, or jQuery object.
        ///</summary>
        ///<param name="selector">A string containing a selector expression to indicate where to stop matching preceding sibling elements.</param>
        ///<param name="filter">A string containing a selector expression to match elements against.</param>
        public extern jQuery prevUntil(string selector, string filter);

        ///<summary>
        /// Get all preceding siblings of each element up to but not including the element matched by the selector, DOM node, or jQuery object.
        ///</summary>
        ///<param name="element">A DOM node or jQuery object indicating where to stop matching preceding sibling elements.</param>
        public extern jQuery prevUntil(Element element);

        ///<summary>
        /// Get all preceding siblings of each element up to but not including the element matched by the selector, DOM node, or jQuery object.
        ///</summary>
        ///<param name="element">A DOM node or jQuery object indicating where to stop matching preceding sibling elements.</param>
        ///<param name="filter">A string containing a selector expression to match elements against.</param>
        public extern jQuery prevUntil(Element element, string filter);

        ///<summary>
        /// Get all following siblings of each element up to but not including the element matched by the selector, DOM node, or jQuery object passed.
        ///</summary>
        public extern jQuery nextUntil();

        ///<summary>
        /// Get all following siblings of each element up to but not including the element matched by the selector, DOM node, or jQuery object passed.
        ///</summary>
        ///<param name="selector">A string containing a selector expression to indicate where to stop matching following sibling elements.</param>
        public extern jQuery nextUntil(string selector);

        ///<summary>
        /// Get all following siblings of each element up to but not including the element matched by the selector, DOM node, or jQuery object passed.
        ///</summary>
        ///<param name="selector">A string containing a selector expression to indicate where to stop matching following sibling elements.</param>
        ///<param name="filter">A string containing a selector expression to match elements against.</param>
        public extern jQuery nextUntil(string selector, string filter);

        ///<summary>
        /// Get all following siblings of each element up to but not including the element matched by the selector, DOM node, or jQuery object passed.
        ///</summary>
        ///<param name="element">A DOM node or jQuery object indicating where to stop matching following sibling elements.</param>
        public extern jQuery nextUntil(Element element);

        ///<summary>
        /// Get all following siblings of each element up to but not including the element matched by the selector, DOM node, or jQuery object passed.
        ///</summary>
        ///<param name="element">A DOM node or jQuery object indicating where to stop matching following sibling elements.</param>
        ///<param name="filter">A string containing a selector expression to match elements against.</param>
        public extern jQuery nextUntil(Element element, string filter);

        ///<summary>
        /// Iterate over a jQuery object, executing a function for each matched element. 
        ///</summary>
        ///<param name="callback">A function to execute for each matched element.</param>
        public extern jQuery each(Action<int, Element> callback);

        ///<summary>
        /// Add a collection of DOM elements onto the jQuery stack.
        ///</summary>
        ///<param name="elements">An array of elements to push onto the stack and make into a new jQuery object.</param>
        public extern jQuery pushStack(Array elements);

        ///<summary>
        /// Add a collection of DOM elements onto the jQuery stack.
        ///</summary>
        ///<param name="elements">An array of elements to push onto the stack and make into a new jQuery object.</param>
        ///<param name="name">The name of a jQuery method that generated the array of elements.</param>
        ///<param name="arguments">The arguments that were passed in to the jQuery method (for serialization).</param>
        public extern jQuery pushStack(Array elements, string name, Array arguments);

        ///<summary>
        /// Execute some JavaScript code globally.
        ///</summary>
        ///<param name="code">The JavaScript code to execute.</param>
        public extern static void globalEval(string code);

        ///<summary>
        /// Check to see if a DOM node is within an XML document (or is an XML document).
        ///</summary>
        ///<param name="node">The DOM node that will be checked to see if it's in an XML document.</param>
        public extern static bool isXMLDoc(Element node);

        ///<summary>
        /// Remove a previously-stored piece of data.
        ///</summary>
        ///<param name="element">A DOM element from which to remove data.</param>
        public extern static jQuery removeData(Element element);

        ///<summary>
        /// Remove a previously-stored piece of data.
        ///</summary>
        ///<param name="element">A DOM element from which to remove data.</param>
        ///<param name="name">A string naming the piece of data to remove.</param>
        public extern static jQuery removeData(Element element, string name);

        ///<summary>
        /// Store arbitrary data associated with the specified element. Returns the value that was set.
        ///</summary>
        ///<param name="element">The DOM element to associate with the data.</param>
        ///<param name="key">A string naming the piece of data to set.</param>
        ///<param name="value">The new data value.</param>
        public extern static Object data(Element element, string key, Object value);

        ///<summary>
        /// Returns value at named data store for the element, as set by jQuery.data(element, name, value), or the full data store for the element.
        ///</summary>
        ///<param name="element">The DOM element to query for the data.</param>
        ///<param name="key">Name of the data stored.</param>
        public extern static Object data(Element element, string key);

        ///<summary>
        /// Returns value at named data store for the element, as set by jQuery.data(element, name, value), or the full data store for the element.
        ///</summary>
        ///<param name="element">The DOM element to query for the data.</param>
        public extern static Object data(Element element);

        ///<summary>
        /// Execute the next function on the queue for the matched element.
        ///</summary>
        ///<param name="element">A DOM element from which to remove and execute a queued function.</param>
        public extern static void dequeue(Element element);

        ///<summary>
        /// Execute the next function on the queue for the matched element.
        ///</summary>
        ///<param name="element">A DOM element from which to remove and execute a queued function.</param>
        ///<param name="queueName">A string containing the name of the queue. Defaults to fx, the standard effects queue.</param>
        public extern static void dequeue(Element element, string queueName);

        ///<summary>
        /// Show the queue of functions to be executed on the matched element.
        ///</summary>
        ///<param name="element">A DOM element to inspect for an attached queue.</param>
        public extern static Array queue(Element element);

        ///<summary>
        /// Show the queue of functions to be executed on the matched element.
        ///</summary>
        ///<param name="element">A DOM element to inspect for an attached queue.</param>
        ///<param name="queueName">A string containing the name of the queue. Defaults to fx, the standard effects queue.</param>
        public extern static Array queue(Element element, string queueName);

        ///<summary>
        /// Manipulate the queue of functions to be executed on the matched element.
        ///</summary>
        ///<param name="element">A DOM element where the array of queued functions is attached.</param>
        ///<param name="queueName">A string containing the name of the queue. Defaults to fx, the standard effects queue.</param>
        ///<param name="newQueue">An array of functions to replace the current queue contents.</param>
        public extern static jQuery queue(Element element, string queueName, Array newQueue);

        ///<summary>
        /// Manipulate the queue of functions to be executed on the matched element.
        ///</summary>
        ///<param name="element">A DOM element on which to add a queued function.</param>
        ///<param name="queueName">A string containing the name of the queue. Defaults to fx, the standard effects queue.</param>
        ///<param name="callback">The new function to add to the queue.</param>
        public extern static jQuery queue(Element element, string queueName, Callback callback);

        ///<summary>
        /// Remove from the queue all items that have not yet been run.
        ///</summary>
        public extern jQuery clearQueue();

        ///<summary>
        /// Remove from the queue all items that have not yet been run.
        ///</summary>
        ///<param name="queueName">A string containing the name of the queue. Defaults to fx, the standard effects queue.</param>
        public extern jQuery clearQueue(string queueName);

        ///<summary>
        /// Retrieve all the DOM elements contained in the jQuery set, as an array.
        ///</summary>
        public extern Array toArray();

        ///<summary>
        /// Check to see if an object is empty (contains no properties).
        ///</summary>
        ///<param name="object">The object that will be checked to see if it's empty.</param>
        public extern static bool isEmptyObject(Object @object);

        ///<summary>
        /// Check to see if an object is a plain object (created using "{}" or "new Object").
        ///</summary>
        ///<param name="object">The object that will be checked to see if it's a plain object.</param>
        public extern static bool isPlainObject(Object @object);

        ///<summary>
        /// Bind an event handler to the "keydown" JavaScript event, or trigger that event on an element.
        ///</summary>
        ///<param name="callback">A function to execute each time the event is triggered.</param>
        public extern jQuery keydown(Action<Event> callback);

        ///<summary>
        /// Bind an event handler to the "keydown" JavaScript event, or trigger that event on an element.
        ///</summary>
        ///<param name="eventData">A map of data that will be passed to the event handler.</param>
        ///<param name="callback">A function to execute each time the event is triggered.</param>
        public extern jQuery keydown(Object eventData, Action<Event> callback);

        ///<summary>
        /// Bind an event handler to the "keydown" JavaScript event, or trigger that event on an element.
        ///</summary>
        public extern jQuery keydown();

        ///<summary>
        /// Search for a given element from among the matched elements.
        ///</summary>
        public extern Number index();

        ///<summary>
        /// Search for a given element from among the matched elements.
        ///</summary>
        ///<param name="selector">A selector representing a jQuery collection in which to look for an element.</param>
        public extern Number index(string selector);

        ///<summary>
        /// Search for a given element from among the matched elements.
        ///</summary>
        ///<param name="element">The DOM element or first element within the jQuery object to look for.</param>
        public extern Number index(Element element);

        ///<summary>
        /// Search for a given element from among the matched elements.
        ///</summary>
        ///<param name="element">The DOM element or first element within the jQuery object to look for.</param>
        public extern Number index(jQuery element);

        ///<summary>
        /// Remove a previously-stored piece of data.
        ///</summary>
        public extern jQuery removeData();

        ///<summary>
        /// Remove a previously-stored piece of data.
        ///</summary>
        ///<param name="name">A string naming the piece of data to delete.</param>
        public extern jQuery removeData(string name);

        ///<summary>
        /// Remove a previously-stored piece of data.
        ///</summary>
        ///<param name="list">An array or space-separated string naming the pieces of data to delete.</param>
        public extern jQuery removeData(Array list);

        ///<summary>
        /// Store arbitrary data associated with the matched elements.
        ///</summary>
        ///<param name="key">A string naming the piece of data to set.</param>
        ///<param name="value">The new data value; it can be any Javascript type including Array or Object.</param>
        public extern jQuery data(string key, Object value);

        ///<summary>
        /// Store arbitrary data associated with the matched elements.
        ///</summary>
        ///<param name="obj">An object of key-value pairs of data to update.</param>
        public extern jQuery data(Object obj);

        ///<summary>
        /// Returns value at named data store for the first element in the jQuery collection, as set by data(name, value).
        ///</summary>
        ///<param name="key">Name of the data stored.</param>
        public extern Object data(string key);

        ///<summary>
        /// Returns value at named data store for the first element in the jQuery collection, as set by data(name, value).
        ///</summary>
        public extern Object data();

        ///<summary>
        /// Retrieve the DOM elements matched by the jQuery object.
        ///</summary>
        public extern Element[] get();

        ///<summary>
        /// Retrieve the DOM elements matched by the jQuery object.
        ///</summary>
        ///<param name="index">A zero-based integer indicating which element to retrieve.</param>
        public extern Element[] get(Number index);

        ///<summary>
        /// Return the number of elements in the jQuery object.
        ///</summary>
        public extern Number size();

        ///<summary>
        /// Relinquish jQuery's control of the $ variable.
        ///</summary>
        public extern static Object noConflict();

        ///<summary>
        /// Relinquish jQuery's control of the $ variable.
        ///</summary>
        ///<param name="removeAll">A Boolean indicating whether to remove all jQuery variables from the global scope (including jQuery itself).</param>
        public extern static Object noConflict(bool removeAll);

        ///<summary>
        /// Bind an event handler to the "scroll" JavaScript event, or trigger that event on an element.
        ///</summary>
        ///<param name="callback">A function to execute each time the event is triggered.</param>
        public extern jQuery scroll(Action<Event> callback);

        ///<summary>
        /// Bind an event handler to the "scroll" JavaScript event, or trigger that event on an element.
        ///</summary>
        ///<param name="eventData">A map of data that will be passed to the event handler.</param>
        ///<param name="callback">A function to execute each time the event is triggered.</param>
        public extern jQuery scroll(Object eventData, Action<Event> callback);

        ///<summary>
        /// Bind an event handler to the "scroll" JavaScript event, or trigger that event on an element.
        ///</summary>
        public extern jQuery scroll();

        ///<summary>
        /// Bind an event handler to the "resize" JavaScript event, or trigger that event on an element.
        ///</summary>
        ///<param name="callback">A function to execute each time the event is triggered.</param>
        public extern jQuery resize(Action<Event> callback);

        ///<summary>
        /// Bind an event handler to the "resize" JavaScript event, or trigger that event on an element.
        ///</summary>
        ///<param name="eventData">A map of data that will be passed to the event handler.</param>
        ///<param name="callback">A function to execute each time the event is triggered.</param>
        public extern jQuery resize(Object eventData, Action<Event> callback);

        ///<summary>
        /// Bind an event handler to the "resize" JavaScript event, or trigger that event on an element.
        ///</summary>
        public extern jQuery resize();

        ///<summary>
        /// Execute the next function on the queue for the matched elements.
        ///</summary>
        public extern jQuery dequeue();

        ///<summary>
        /// Execute the next function on the queue for the matched elements.
        ///</summary>
        ///<param name="queueName">A string containing the name of the queue. Defaults to fx, the standard effects queue.</param>
        public extern jQuery dequeue(string queueName);

        ///<summary>
        /// Show the queue of functions to be executed on the matched elements.
        ///</summary>
        public extern Array queue();

        ///<summary>
        /// Show the queue of functions to be executed on the matched elements.
        ///</summary>
        ///<param name="queueName">A string containing the name of the queue. Defaults to fx, the standard effects queue.</param>
        public extern Array queue(string queueName);

        ///<summary>
        /// Manipulate the queue of functions to be executed on the matched elements.
        ///</summary>
        ///<param name="queueName">A string containing the name of the queue. Defaults to fx, the standard effects queue.</param>
        ///<param name="newQueue">An array of functions to replace the current queue contents.</param>
        public extern jQuery queue(string queueName, Array newQueue);

        ///<summary>
        /// Manipulate the queue of functions to be executed on the matched elements.
        ///</summary>
        ///<param name="queueName">A string containing the name of the queue. Defaults to fx, the standard effects queue.</param>
        ///<param name="callback">The new function to add to the queue, with a function to call that will dequeue the next item.</param>
        public extern jQuery queue(string queueName, Action<object> callback);

        ///<summary>
        /// Bind an event handler to the "keyup" JavaScript event, or trigger that event on an element.
        ///</summary>
        ///<param name="callback">A function to execute each time the event is triggered.</param>
        public extern jQuery keyup(Action<Event> callback);

        ///<summary>
        /// Bind an event handler to the "keyup" JavaScript event, or trigger that event on an element.
        ///</summary>
        ///<param name="eventData">A map of data that will be passed to the event handler.</param>
        ///<param name="callback">A function to execute each time the event is triggered.</param>
        public extern jQuery keyup(Object eventData, Action<Event> callback);

        ///<summary>
        /// Bind an event handler to the "keyup" JavaScript event, or trigger that event on an element.
        ///</summary>
        public extern jQuery keyup();

        ///<summary>
        /// Bind an event handler to the "keypress" JavaScript event, or trigger that event on an element.
        ///</summary>
        ///<param name="callback">A function to execute each time the event is triggered.</param>
        public extern jQuery keypress(Action<Event> callback);

        ///<summary>
        /// Bind an event handler to the "keypress" JavaScript event, or trigger that event on an element.
        ///</summary>
        ///<param name="eventData">A map of data that will be passed to the event handler.</param>
        ///<param name="callback">A function to execute each time the event is triggered.</param>
        public extern jQuery keypress(Object eventData, Action<Event> callback);

        ///<summary>
        /// Bind an event handler to the "keypress" JavaScript event, or trigger that event on an element.
        ///</summary>
        public extern jQuery keypress();

        ///<summary>
        /// Bind an event handler to the "submit" JavaScript event, or trigger that event on an element.
        ///</summary>
        ///<param name="callback">A function to execute each time the event is triggered.</param>
        public extern jQuery submit(Action<Event> callback);

        ///<summary>
        /// Bind an event handler to the "submit" JavaScript event, or trigger that event on an element.
        ///</summary>
        ///<param name="eventData">A map of data that will be passed to the event handler.</param>
        ///<param name="callback">A function to execute each time the event is triggered.</param>
        public extern jQuery submit(Object eventData, Action<Event> callback);

        ///<summary>
        /// Bind an event handler to the "submit" JavaScript event, or trigger that event on an element.
        ///</summary>
        public extern jQuery submit();

        ///<summary>
        /// Bind an event handler to the "select" JavaScript event, or trigger that event on an element.
        ///</summary>
        ///<param name="callback">A function to execute each time the event is triggered.</param>
        public extern jQuery select(Action<Event> callback);

        ///<summary>
        /// Bind an event handler to the "select" JavaScript event, or trigger that event on an element.
        ///</summary>
        ///<param name="eventData">A map of data that will be passed to the event handler.</param>
        ///<param name="callback">A function to execute each time the event is triggered.</param>
        public extern jQuery select(Object eventData, Action<Event> callback);

        ///<summary>
        /// Bind an event handler to the "select" JavaScript event, or trigger that event on an element.
        ///</summary>
        public extern jQuery select();

        ///<summary>
        /// Bind an event handler to the "change" JavaScript event, or trigger that event on an element.
        ///</summary>
        ///<param name="callback">A function to execute each time the event is triggered.</param>
        public extern jQuery change(Action<Event> callback);

        ///<summary>
        /// Bind an event handler to the "change" JavaScript event, or trigger that event on an element.
        ///</summary>
        ///<param name="eventData">A map of data that will be passed to the event handler.</param>
        ///<param name="callback">A function to execute each time the event is triggered.</param>
        public extern jQuery change(Object eventData, Action<Event> callback);

        ///<summary>
        /// Bind an event handler to the "change" JavaScript event, or trigger that event on an element.
        ///</summary>
        public extern jQuery change();

        ///<summary>
        /// Bind an event handler to the "blur" JavaScript event, or trigger that event on an element.
        ///</summary>
        ///<param name="callback">A function to execute each time the event is triggered.</param>
        public extern jQuery blur(Action<Event> callback);

        ///<summary>
        /// Bind an event handler to the "blur" JavaScript event, or trigger that event on an element.
        ///</summary>
        ///<param name="eventData">A map of data that will be passed to the event handler.</param>
        ///<param name="callback">A function to execute each time the event is triggered.</param>
        public extern jQuery blur(Object eventData, Action<Event> callback);

        ///<summary>
        /// Bind an event handler to the "blur" JavaScript event, or trigger that event on an element.
        ///</summary>
        public extern jQuery blur();

        ///<summary>
        /// Bind an event handler to the "focus" JavaScript event, or trigger that event on an element.
        ///</summary>
        ///<param name="callback">A function to execute each time the event is triggered.</param>
        public extern jQuery focus(Action<Event> callback);

        ///<summary>
        /// Bind an event handler to the "focus" JavaScript event, or trigger that event on an element.
        ///</summary>
        ///<param name="eventData">A map of data that will be passed to the event handler.</param>
        ///<param name="callback">A function to execute each time the event is triggered.</param>
        public extern jQuery focus(Object eventData, Action<Event> callback);

        ///<summary>
        /// Bind an event handler to the "focus" JavaScript event, or trigger that event on an element.
        ///</summary>
        public extern jQuery focus();

        ///<summary>
        /// Bind an event handler to the "mousemove" JavaScript event, or trigger that event on an element.
        ///</summary>
        ///<param name="callback">A function to execute each time the event is triggered.</param>
        public extern jQuery mousemove(Action<Event> callback);

        ///<summary>
        /// Bind an event handler to the "mousemove" JavaScript event, or trigger that event on an element.
        ///</summary>
        ///<param name="eventData">A map of data that will be passed to the event handler.</param>
        ///<param name="callback">A function to execute each time the event is triggered.</param>
        public extern jQuery mousemove(Object eventData, Action<Event> callback);

        ///<summary>
        /// Bind an event handler to the "mousemove" JavaScript event, or trigger that event on an element.
        ///</summary>
        public extern jQuery mousemove();

        ///<summary>
        /// Bind two handlers to the matched elements, to be executed when the mouse pointer enters and leaves the elements.
        ///</summary>
        ///<param name="callback">A function to execute when the mouse pointer enters the element.</param>
        ///<param name="callback1">A function to execute when the mouse pointer leaves the element.</param>
        public extern jQuery hover(Action<Event> callback, Action<Event> callback1);

        ///<summary>
        /// Bind a single handler to the matched elements, to be executed when the mouse pointer enters or leaves the elements.
        ///</summary>
        ///<param name="callback">A function to execute when the mouse pointer enters or leaves the element.</param>
        public extern jQuery hover(Action<Event> callback);

        ///<summary>
        /// Bind an event handler to be fired when the mouse leaves an element, or trigger that handler on an element.
        ///</summary>
        ///<param name="callback">A function to execute each time the event is triggered.</param>
        public extern jQuery mouseleave(Action<Event> callback);

        ///<summary>
        /// Bind an event handler to be fired when the mouse leaves an element, or trigger that handler on an element.
        ///</summary>
        ///<param name="eventData">A map of data that will be passed to the event handler.</param>
        ///<param name="callback">A function to execute each time the event is triggered.</param>
        public extern jQuery mouseleave(Object eventData, Action<Event> callback);

        ///<summary>
        /// Bind an event handler to be fired when the mouse leaves an element, or trigger that handler on an element.
        ///</summary>
        public extern jQuery mouseleave();

        ///<summary>
        /// Bind an event handler to be fired when the mouse enters an element, or trigger that handler on an element.
        ///</summary>
        ///<param name="callback">A function to execute each time the event is triggered.</param>
        public extern jQuery mouseenter(Action<Event> callback);

        ///<summary>
        /// Bind an event handler to be fired when the mouse enters an element, or trigger that handler on an element.
        ///</summary>
        ///<param name="eventData">A map of data that will be passed to the event handler.</param>
        ///<param name="callback">A function to execute each time the event is triggered.</param>
        public extern jQuery mouseenter(Object eventData, Action<Event> callback);

        ///<summary>
        /// Bind an event handler to be fired when the mouse enters an element, or trigger that handler on an element.
        ///</summary>
        public extern jQuery mouseenter();

        ///<summary>
        /// Bind an event handler to the "mouseout" JavaScript event, or trigger that event on an element.
        ///</summary>
        ///<param name="callback">A function to execute each time the event is triggered.</param>
        public extern jQuery mouseout(Action<Event> callback);

        ///<summary>
        /// Bind an event handler to the "mouseout" JavaScript event, or trigger that event on an element.
        ///</summary>
        ///<param name="eventData">A map of data that will be passed to the event handler.</param>
        ///<param name="callback">A function to execute each time the event is triggered.</param>
        public extern jQuery mouseout(Object eventData, Action<Event> callback);

        ///<summary>
        /// Bind an event handler to the "mouseout" JavaScript event, or trigger that event on an element.
        ///</summary>
        public extern jQuery mouseout();

        ///<summary>
        /// Bind an event handler to the "mouseover" JavaScript event, or trigger that event on an element.
        ///</summary>
        ///<param name="callback">A function to execute each time the event is triggered.</param>
        public extern jQuery mouseover(Action<Event> callback);

        ///<summary>
        /// Bind an event handler to the "mouseover" JavaScript event, or trigger that event on an element.
        ///</summary>
        ///<param name="eventData">A map of data that will be passed to the event handler.</param>
        ///<param name="callback">A function to execute each time the event is triggered.</param>
        public extern jQuery mouseover(Object eventData, Action<Event> callback);

        ///<summary>
        /// Bind an event handler to the "mouseover" JavaScript event, or trigger that event on an element.
        ///</summary>
        public extern jQuery mouseover();

        ///<summary>
        /// Bind an event handler to the "dblclick" JavaScript event, or trigger that event on an element.
        ///</summary>
        ///<param name="callback">A function to execute each time the event is triggered.</param>
        public extern jQuery dblclick(Action<Event> callback);

        ///<summary>
        /// Bind an event handler to the "dblclick" JavaScript event, or trigger that event on an element.
        ///</summary>
        ///<param name="eventData">A map of data that will be passed to the event handler.</param>
        ///<param name="callback">A function to execute each time the event is triggered.</param>
        public extern jQuery dblclick(Object eventData, Action<Event> callback);

        ///<summary>
        /// Bind an event handler to the "dblclick" JavaScript event, or trigger that event on an element.
        ///</summary>
        public extern jQuery dblclick();

        ///<summary>
        /// Bind an event handler to the "click" JavaScript event, or trigger that event on an element.
        ///</summary>
        ///<param name="callback">A function to execute each time the event is triggered.</param>
        public extern jQuery click(Action<Event> callback);

        ///<summary>
        /// Bind an event handler to the "click" JavaScript event, or trigger that event on an element.
        ///</summary>
        ///<param name="eventData">A map of data that will be passed to the event handler.</param>
        ///<param name="callback">A function to execute each time the event is triggered.</param>
        public extern jQuery click(Object eventData, Action<Event> callback);

        ///<summary>
        /// Bind an event handler to the "click" JavaScript event, or trigger that event on an element.
        ///</summary>
        public extern jQuery click();

        ///<summary>
        /// Bind an event handler to the "mouseup" JavaScript event, or trigger that event on an element.
        ///</summary>
        ///<param name="callback">A function to execute each time the event is triggered.</param>
        public extern jQuery mouseup(Action<Event> callback);

        ///<summary>
        /// Bind an event handler to the "mouseup" JavaScript event, or trigger that event on an element.
        ///</summary>
        ///<param name="eventData">A map of data that will be passed to the event handler.</param>
        ///<param name="callback">A function to execute each time the event is triggered.</param>
        public extern jQuery mouseup(Object eventData, Action<Event> callback);

        ///<summary>
        /// Bind an event handler to the "mouseup" JavaScript event, or trigger that event on an element.
        ///</summary>
        public extern jQuery mouseup();

        ///<summary>
        /// Bind an event handler to the "mousedown" JavaScript event, or trigger that event on an element.
        ///</summary>
        ///<param name="callback">A function to execute each time the event is triggered.</param>
        public extern jQuery mousedown(Action<Event> callback);

        ///<summary>
        /// Bind an event handler to the "mousedown" JavaScript event, or trigger that event on an element.
        ///</summary>
        ///<param name="eventData">A map of data that will be passed to the event handler.</param>
        ///<param name="callback">A function to execute each time the event is triggered.</param>
        public extern jQuery mousedown(Object eventData, Action<Event> callback);

        ///<summary>
        /// Bind an event handler to the "mousedown" JavaScript event, or trigger that event on an element.
        ///</summary>
        public extern jQuery mousedown();

        ///<summary>
        /// Bind an event handler to the "error" JavaScript event.
        ///</summary>
        ///<param name="callback">A function to execute when the event is triggered.</param>
        public extern jQuery error(Action<Event> callback);

        ///<summary>
        /// Bind an event handler to the "error" JavaScript event.
        ///</summary>
        ///<param name="eventData">A map of data that will be passed to the event handler.</param>
        ///<param name="callback">A function to execute each time the event is triggered.</param>
        public extern jQuery error(Object eventData, Action<Event> callback);

        ///<summary>
        /// Bind an event handler to the "unload" JavaScript event.
        ///</summary>
        ///<param name="callback">A function to execute when the event is triggered.</param>
        public extern jQuery unload(Action<Event> callback);

        ///<summary>
        /// Bind an event handler to the "unload" JavaScript event.
        ///</summary>
        ///<param name="eventData">A map of data that will be passed to the event handler.</param>
        ///<param name="callback">A function to execute each time the event is triggered.</param>
        public extern jQuery unload(Object eventData, Action<Event> callback);

        ///<summary>
        /// Bind an event handler to the "load" JavaScript event.
        ///</summary>
        ///<param name="callback">A function to execute when the event is triggered.</param>
        public extern jQuery load(Action<Event> callback);

        ///<summary>
        /// Bind an event handler to the "load" JavaScript event.
        ///</summary>
        ///<param name="eventData">A map of data that will be passed to the event handler.</param>
        ///<param name="callback">A function to execute each time the event is triggered.</param>
        public extern jQuery load(Object eventData, Action<Event> callback);

        ///<summary>
        /// Specify a function to execute when the DOM is fully loaded.
        ///</summary>
        ///<param name="callback">A function to execute after the DOM is ready.</param>
        public extern jQuery ready(Action callback);

        ///<summary>
        /// Remove all event handlers previously attached using .live() from the elements.
        ///</summary>
        public extern jQuery die();

        ///<summary>
        /// Remove an event handler previously attached using .live() from the elements.
        ///</summary>
        ///<param name="eventType">A string containing a JavaScript event type, such as click or keydown.</param>
        public extern jQuery die(string eventType);

        ///<summary>
        /// Remove an event handler previously attached using .live() from the elements.
        ///</summary>
        ///<param name="eventType">A string containing a JavaScript event type, such as click or keydown.</param>
        ///<param name="handler">The function that is no longer to be executed.</param>
        public extern jQuery die(string eventType, string handler);

        ///<summary>
        /// Remove an event handler previously attached using .live() from the elements.
        ///</summary>
        ///<param name="eventTypes">A map of one or more event types, such as click or keydown and their corresponding functions that are no longer to be executed.</param>
        public extern jQuery die(object eventTypes);

        ///<summary>
        /// Attach an event handler for all elements which match the current selector, now and in the future.
        ///</summary>
        ///<param name="events">A string containing a JavaScript event type, such as "click" or "keydown." As of jQuery 1.4 the string can contain multiple, space-separated event types or custom event names.</param>
        ///<param name="callback">A function to execute at the time the event is triggered.</param>
        public extern jQuery live(string events, Action<Event> callback);

        ///<summary>
        /// Attach an event handler for all elements which match the current selector, now and in the future.
        ///</summary>
        ///<param name="events">A string containing a JavaScript event type, such as "click" or "keydown." As of jQuery 1.4 the string can contain multiple, space-separated event types or custom event names.</param>
        ///<param name="data">A map of data that will be passed to the event handler.</param>
        ///<param name="callback">A function to execute at the time the event is triggered.</param>
        public extern jQuery live(string events, Object data, Action<Event> callback);

        ///<summary>
        /// Attach an event handler for all elements which match the current selector, now and in the future.
        ///</summary>
        ///<param name="eventsmap">A map of one or more JavaScript event types and functions to execute for them.</param>
        public extern jQuery live(Object eventsmap);

        ///<summary>
        /// Execute all handlers attached to an element for an event.
        ///</summary>
        ///<param name="eventType">A string containing a JavaScript event type, such as click or submit.</param>
        public extern Object triggerHandler(string eventType);

        ///<summary>
        /// Execute all handlers attached to an element for an event.
        ///</summary>
        ///<param name="eventType">A string containing a JavaScript event type, such as click or submit.</param>
        ///<param name="extraParameters">An array of additional parameters to pass along to the event handler.</param>
        public extern Object triggerHandler(string eventType, Array extraParameters);

        ///<summary>
        /// Execute all handlers and behaviors attached to the matched elements for the given event type.
        ///</summary>
        ///<param name="eventType">A string containing a JavaScript event type, such as click or submit.</param>
        public extern jQuery trigger(string eventType);

        ///<summary>
        /// Execute all handlers and behaviors attached to the matched elements for the given event type.
        ///</summary>
        ///<param name="eventType">A string containing a JavaScript event type, such as click or submit.</param>
        ///<param name="extraParameters">Additional parameters to pass along to the event handler.</param>
        public extern jQuery trigger(string eventType, Object extraParameters);

        ///<summary>
        /// Execute all handlers and behaviors attached to the matched elements for the given event type.
        ///</summary>
        ///<param name="event">A jQuery.Event object.</param>
        public extern jQuery trigger(Event @event);

        ///<summary>
        /// Register a handler to be called when Ajax requests complete. This is an Ajax Event.
        ///</summary>
        ///<param name="callback">The function to be invoked.</param>
        public extern jQuery ajaxComplete(Action<Event, XMLHttpRequest, object> callback);

        ///<summary>
        /// Attach a handler to an event for the elements. The handler is executed at most once per element.
        ///</summary>
        ///<param name="events">A string containing one or more JavaScript event types, such as "click" or "submit," or custom event names.</param>
        ///<param name="data">A map of data that will be passed to the event handler.</param>
        ///<param name="callback">A function to execute at the time the event is triggered.</param>
        public extern jQuery one(string events, Object data, Action<Event> callback);

        ///<summary>
        /// Attach a handler to an event for the elements. The handler is executed at most once per element.
        ///</summary>
        ///<param name="events">One or more space-separated event types and optional namespaces, such as "click" or "keydown.myPlugin".</param>
        ///<param name="selector">A selector string to filter the descendants of the selected elements that trigger the event. If the selector is null or omitted, the event is always triggered when it reaches the selected element.</param>
        ///<param name="data">Data to be passed to the handler in event.data when an event is triggered.</param>
        ///<param name="callback">A function to execute when the event is triggered. The value false is also allowed as a shorthand for a function that simply does return false.</param>
        public extern jQuery one(string events, string selector, object data, Action<Event> callback);

        ///<summary>
        /// Attach a handler to an event for the elements. The handler is executed at most once per element.
        ///</summary>
        ///<param name="eventsmap">A map in which the string keys represent one or more space-separated event types and optional namespaces, and the values represent a handler function to be called for the event(s).</param>
        public extern jQuery one(object eventsmap);

        ///<summary>
        /// Attach a handler to an event for the elements. The handler is executed at most once per element.
        ///</summary>
        ///<param name="eventsmap">A map in which the string keys represent one or more space-separated event types and optional namespaces, and the values represent a handler function to be called for the event(s).</param>
        ///<param name="selector">A selector string to filter the descendants of the selected elements that will call the handler. If the selector is null or omitted, the handler is always called when it reaches the selected element.</param>
        public extern jQuery one(object eventsmap, string selector);

        ///<summary>
        /// Attach a handler to an event for the elements. The handler is executed at most once per element.
        ///</summary>
        ///<param name="eventsmap">A map in which the string keys represent one or more space-separated event types and optional namespaces, and the values represent a handler function to be called for the event(s).</param>
        ///<param name="selector">A selector string to filter the descendants of the selected elements that will call the handler. If the selector is null or omitted, the handler is always called when it reaches the selected element.</param>
        ///<param name="data">Data to be passed to the handler in event.data when an event occurs.</param>
        public extern jQuery one(object eventsmap, string selector, object data);

        ///<summary>
        /// Encode a set of form elements as an array of names and values.
        ///</summary>
        public extern Array serializeArray();

        ///<summary>
        /// Encode a set of form elements as a string for submission.
        ///</summary>
        public extern String serialize();

        ///<summary>
        /// Set default values for future Ajax requests.
        ///</summary>
        ///<param name="options">A set of key/value pairs that configure the default Ajax request. All options are optional.</param>
        public extern static void ajaxSetup(object options);

        ///<summary>
        /// Attach a function to be executed whenever an Ajax request completes successfully. This is an Ajax Event.
        ///</summary>
        ///<param name="callback">The function to be invoked.</param>
        public extern jQuery ajaxSuccess(Action<Event, XMLHttpRequest, object> callback);

        ///<summary>
        /// Register a handler to be called when all Ajax requests have completed. This is an Ajax Event.
        ///</summary>
        ///<param name="callback">The function to be invoked.</param>
        public extern jQuery ajaxStop(Action callback);

        ///<summary>
        /// Register a handler to be called when the first Ajax request begins. This is an Ajax Event.
        ///</summary>
        ///<param name="callback">The function to be invoked.</param>
        public extern jQuery ajaxStart(Action callback);

        ///<summary>
        /// Attach a function to be executed before an Ajax request is sent. This is an Ajax Event.
        ///</summary>
        ///<param name="callback">The function to be invoked.</param>
        public extern jQuery ajaxSend(Action<Event, jqXHR, object> callback);

        ///<summary>
        /// Register a handler to be called when Ajax requests complete with an error. This is an Ajax Event.
        ///</summary>
        ///<param name="callback">The function to be invoked.</param>
        public extern jQuery ajaxError(Action<Event, jqXHR, object, object> callback);

        ///<summary>
        /// Remove a previously-attached event handler from the elements.
        ///</summary>
        public extern jQuery unbind();

        ///<summary>
        /// Remove a previously-attached event handler from the elements.
        ///</summary>
        ///<param name="eventType">A string containing a JavaScript event type, such as click or submit.</param>
        public extern jQuery unbind(string eventType);

        ///<summary>
        /// Remove a previously-attached event handler from the elements.
        ///</summary>
        ///<param name="eventType">A string containing a JavaScript event type, such as click or submit.</param>
        ///<param name="callback">The function that is to be no longer executed.</param>
        public extern jQuery unbind(string eventType, Action<Event> callback);

        ///<summary>
        /// Remove a previously-attached event handler from the elements.
        ///</summary>
        ///<param name="eventType">A string containing a JavaScript event type, such as click or submit.</param>
        ///<param name="false">Unbinds the corresponding 'return false' function that was bound using .bind( eventType, false ).</param>
        public extern jQuery unbind(string eventType, bool @false);

        ///<summary>
        /// Remove a previously-attached event handler from the elements.
        ///</summary>
        ///<param name="event">A JavaScript event object as passed to an event handler.</param>
        public extern jQuery unbind(Object @event);

        ///<summary>
        /// Attach a handler to an event for the elements.
        ///</summary>
        ///<param name="eventType">A string containing one or more DOM event types, such as "click" or "submit," or custom event names.</param>
        ///<param name="eventData">A map of data that will be passed to the event handler.</param>
        ///<param name="callback">A function to execute each time the event is triggered.</param>
        public extern jQuery bind(string eventType, Object eventData, Action<Event> callback);

        ///<summary>
        /// Attach a handler to an event for the elements.
        ///</summary>
        ///<param name="eventType">A string containing one or more DOM event types, such as "click" or "submit," or custom event names.</param>
        ///<param name="eventData">A map of data that will be passed to the event handler.</param>
        ///<param name="preventBubble">Setting the third argument to false will attach a function that prevents the default action from occurring and stops the event from bubbling. The default is true.</param>
        public extern jQuery bind(string eventType, Object eventData, bool preventBubble);

        ///<summary>
        /// Attach a handler to an event for the elements.
        ///</summary>
        ///<param name="events">A map of one or more DOM event types and functions to execute for them.</param>
        public extern jQuery bind(Object events);

        ///<summary>
        /// Reduce the set of matched elements to the first in the set.
        ///</summary>
        public extern jQuery first();

        ///<summary>
        /// Reduce the set of matched elements to the final one in the set.
        ///</summary>
        public extern jQuery last();

        ///<summary>
        /// Reduce the set of matched elements to a subset specified by a range of indices.
        ///</summary>
        ///<param name="start">An integer indicating the 0-based position at which the elements begin to be selected. If negative, it indicates an offset from the end of the set.</param>
        public extern jQuery slice(int start);

        ///<summary>
        /// Reduce the set of matched elements to a subset specified by a range of indices.
        ///</summary>
        ///<param name="start">An integer indicating the 0-based position at which the elements begin to be selected. If negative, it indicates an offset from the end of the set.</param>
        ///<param name="end">An integer indicating the 0-based position at which the elements stop being selected. If negative, it indicates an offset from the end of the set. If omitted, the range continues until the end of the set.</param>
        public extern jQuery slice(int start, int end);

        ///<summary>
        /// Accepts a string containing a CSS selector which is then used to match a set of elements.
        ///</summary>
        ///<param name="selector">A string containing a selector expression</param>
        [ScriptName("")]
        public extern static jQuery Select(string selector);

        ///<summary>
        /// Accepts a string containing a CSS selector which is then used to match a set of elements.
        ///</summary>
        ///<param name="selector">A string containing a selector expression</param>
        ///<param name="context">A DOM Element, Document, or jQuery to use as context</param>
        [ScriptName("")]
        public extern static jQuery Select(string selector, Element context);

        ///<summary>
        /// Accepts a string containing a CSS selector which is then used to match a set of elements.
        ///</summary>
        ///<param name="selector">A string containing a selector expression</param>
        ///<param name="context">A DOM Element, Document, or jQuery to use as context</param>
        [ScriptName("")]
        public extern static jQuery Select(string selector, jQuery context);

        ///<summary>
        /// Accepts a string containing a CSS selector which is then used to match a set of elements.
        ///</summary>
        ///<param name="element">A DOM element to wrap in a jQuery object.</param>
        [ScriptName("")]
        public extern static jQuery Select(Element element);

        ///<summary>
        /// Accepts a string containing a CSS selector which is then used to match a set of elements.
        ///</summary>
        ///<param name="object">A plain object to wrap in a jQuery object.</param>
        [ScriptName("")]
        public extern static jQuery Select(Object @object);

        ///<summary>
        /// Accepts a string containing a CSS selector which is then used to match a set of elements.
        ///</summary>
        ///<param name="elementArray">An array containing a set of DOM elements to wrap in a jQuery object.</param>
        [ScriptName("")]
        public extern static jQuery Select(Array elementArray);

        ///<summary>
        /// Accepts a string containing a CSS selector which is then used to match a set of elements.
        ///</summary>
        ///<param name="object">An existing jQuery object to clone.</param>
        [ScriptName("")]
        public extern static jQuery Select(jQuery @object);

        ///<summary>
        /// Accepts a string containing a CSS selector which is then used to match a set of elements.
        ///</summary>
        [ScriptName("")]
        public extern static jQuery Select();

        ///<summary>
        /// Creates DOM elements on the fly from the provided string of raw HTML.
        ///</summary>
        ///<param name="html">A string of HTML to create on the fly. Note that this parses HTML, not XML.</param>
        ///<param name="ownerDocument">A document in which the new elements will be created</param>
        [ScriptName("")]
        public extern static jQuery Select(string html, Document ownerDocument);

        ///<summary>
        /// Creates DOM elements on the fly from the provided string of raw HTML.
        ///</summary>
        ///<param name="html">A string defining a single, standalone, HTML element (e.g. <div/> or <div></div>).</param>
        ///<param name="props">An map of attributes, events, and methods to call on the newly-created element.</param>
        [ScriptName("")]
        public extern static jQuery Select(string html, Object props);

        ///<summary>
        /// Binds a function to be executed when the DOM has finished loading.
        ///</summary>
        ///<param name="callback">The function to execute when the DOM is ready.</param>
        [ScriptName("")]
        public extern static jQuery Select(Action callback);

        ///<summary>
        /// Stop the currently-running animation on the matched elements.
        ///</summary>
        public extern jQuery stop();

        ///<summary>
        /// Stop the currently-running animation on the matched elements.
        ///</summary>
        ///<param name="clearQueue">A Boolean indicating whether to remove queued animation as well. Defaults to false.</param>
        public extern jQuery stop(bool clearQueue);

        ///<summary>
        /// Stop the currently-running animation on the matched elements.
        ///</summary>
        ///<param name="clearQueue">A Boolean indicating whether to remove queued animation as well. Defaults to false.</param>
        ///<param name="jumpToEnd">A Boolean indicating whether to complete the current animation immediately. Defaults to false.</param>
        public extern jQuery stop(bool clearQueue, bool jumpToEnd);

        ///<summary>
        /// Stop the currently-running animation on the matched elements.
        ///</summary>
        ///<param name="queue">The name of the queue in which to stop animations.</param>
        public extern jQuery stop(string queue);

        ///<summary>
        /// Stop the currently-running animation on the matched elements.
        ///</summary>
        ///<param name="queue">The name of the queue in which to stop animations.</param>
        ///<param name="clearQueue">A Boolean indicating whether to remove queued animation as well. Defaults to false.</param>
        public extern jQuery stop(string queue, bool clearQueue);

        ///<summary>
        /// Stop the currently-running animation on the matched elements.
        ///</summary>
        ///<param name="queue">The name of the queue in which to stop animations.</param>
        ///<param name="clearQueue">A Boolean indicating whether to remove queued animation as well. Defaults to false.</param>
        ///<param name="jumpToEnd">A Boolean indicating whether to complete the current animation immediately. Defaults to false.</param>
        public extern jQuery stop(string queue, bool clearQueue, bool jumpToEnd);

        ///<summary>
        /// End the most recent filtering operation in the current chain and return the set of matched elements to its previous state.
        ///</summary>
        public extern jQuery end();

        ///<summary>
        /// Add the previous set of elements on the stack to the current set.
        ///</summary>
        public extern jQuery andSelf();

        ///<summary>
        /// Get the siblings of each element in the set of matched elements, optionally filtered by a selector.
        ///</summary>
        public extern jQuery siblings();

        ///<summary>
        /// Get the siblings of each element in the set of matched elements, optionally filtered by a selector.
        ///</summary>
        ///<param name="selector">A string containing a selector expression to match elements against.</param>
        public extern jQuery siblings(string selector);

        ///<summary>
        /// Perform a custom animation of a set of CSS properties.
        ///</summary>
        ///<param name="properties">A map of CSS properties that the animation will move toward.</param>
        public extern jQuery animate(object properties);

        ///<summary>
        /// Perform a custom animation of a set of CSS properties.
        ///</summary>
        ///<param name="properties">A map of CSS properties that the animation will move toward.</param>
        ///<param name="duration">A string or number determining how long the animation will run.</param>
        public extern jQuery animate(object properties, string duration);

        ///<summary>
        /// Perform a custom animation of a set of CSS properties.
        ///</summary>
        ///<param name="properties">A map of CSS properties that the animation will move toward.</param>
        ///<param name="duration">A string or number determining how long the animation will run.</param>
        ///<param name="easing">A string indicating which easing function to use for the transition.</param>
        public extern jQuery animate(object properties, string duration, string easing);

        ///<summary>
        /// Perform a custom animation of a set of CSS properties.
        ///</summary>
        ///<param name="properties">A map of CSS properties that the animation will move toward.</param>
        ///<param name="duration">A string or number determining how long the animation will run.</param>
        ///<param name="easing">A string indicating which easing function to use for the transition.</param>
        ///<param name="callback">A function to call once the animation is complete.</param>
        public extern jQuery animate(object properties, string duration, string easing, Action callback);

        ///<summary>
        /// Perform a custom animation of a set of CSS properties.
        ///</summary>
        ///<param name="properties">A map of CSS properties that the animation will move toward.</param>
        ///<param name="duration">A string or number determining how long the animation will run.</param>
        public extern jQuery animate(object properties, Number duration);

        ///<summary>
        /// Perform a custom animation of a set of CSS properties.
        ///</summary>
        ///<param name="properties">A map of CSS properties that the animation will move toward.</param>
        ///<param name="duration">A string or number determining how long the animation will run.</param>
        ///<param name="easing">A string indicating which easing function to use for the transition.</param>
        public extern jQuery animate(object properties, Number duration, string easing);

        ///<summary>
        /// Perform a custom animation of a set of CSS properties.
        ///</summary>
        ///<param name="properties">A map of CSS properties that the animation will move toward.</param>
        ///<param name="duration">A string or number determining how long the animation will run.</param>
        ///<param name="easing">A string indicating which easing function to use for the transition.</param>
        ///<param name="callback">A function to call once the animation is complete.</param>
        public extern jQuery animate(object properties, Number duration, string easing, Action callback);

        ///<summary>
        /// Perform a custom animation of a set of CSS properties.
        ///</summary>
        ///<param name="properties">A map of CSS properties that the animation will move toward.</param>
        ///<param name="options">A map of additional options to pass to the method. Supported keys:
        ///        duration: A string or number determining how long the animation will run.easing: A string indicating which easing function to use for the transition.complete: A function to call once the animation is complete.step: A function to be called after each step of the animation.queue: A Boolean indicating whether to place the animation in the effects queue. If false, the animation will begin immediately. As of jQuery 1.7, the queue option can also accept a string, in which case the animation is added to the queue represented by that string.specialEasing: A map of one or more of the CSS properties defined by the properties argument and their corresponding easing functions (added 1.4).</param>
        public extern jQuery animate(object properties, object options);

        ///<summary>
        /// Get all preceding siblings of each element in the set of matched elements, optionally filtered by a selector.
        ///</summary>
        public extern jQuery prevAll();

        ///<summary>
        /// Get all preceding siblings of each element in the set of matched elements, optionally filtered by a selector.
        ///</summary>
        ///<param name="selector">A string containing a selector expression to match elements against.</param>
        public extern jQuery prevAll(string selector);

        ///<summary>
        /// Get the immediately preceding sibling of each element in the set of matched elements, optionally filtered by a selector.
        ///</summary>
        public extern jQuery prev();

        ///<summary>
        /// Get the immediately preceding sibling of each element in the set of matched elements, optionally filtered by a selector.
        ///</summary>
        ///<param name="selector">A string containing a selector expression to match elements against.</param>
        public extern jQuery prev(string selector);

        ///<summary>
        /// Adjust the opacity of the matched elements.
        ///</summary>
        ///<param name="duration">A string or number determining how long the animation will run.</param>
        ///<param name="opacity">A number between 0 and 1 denoting the target opacity.</param>
        public extern jQuery fadeTo(string duration, Number opacity);

        ///<summary>
        /// Adjust the opacity of the matched elements.
        ///</summary>
        ///<param name="duration">A string or number determining how long the animation will run.</param>
        ///<param name="opacity">A number between 0 and 1 denoting the target opacity.</param>
        ///<param name="callback">A function to call once the animation is complete.</param>
        public extern jQuery fadeTo(string duration, Number opacity, Action callback);

        ///<summary>
        /// Adjust the opacity of the matched elements.
        ///</summary>
        ///<param name="duration">A string or number determining how long the animation will run.</param>
        ///<param name="opacity">A number between 0 and 1 denoting the target opacity.</param>
        public extern jQuery fadeTo(Number duration, Number opacity);

        ///<summary>
        /// Adjust the opacity of the matched elements.
        ///</summary>
        ///<param name="duration">A string or number determining how long the animation will run.</param>
        ///<param name="opacity">A number between 0 and 1 denoting the target opacity.</param>
        ///<param name="callback">A function to call once the animation is complete.</param>
        public extern jQuery fadeTo(Number duration, Number opacity, Action callback);

        ///<summary>
        /// Adjust the opacity of the matched elements.
        ///</summary>
        ///<param name="duration">A string or number determining how long the animation will run.</param>
        ///<param name="opacity">A number between 0 and 1 denoting the target opacity.</param>
        ///<param name="easing">A string indicating which easing function to use for the transition.</param>
        public extern jQuery fadeTo(string duration, Number opacity, string easing);

        ///<summary>
        /// Adjust the opacity of the matched elements.
        ///</summary>
        ///<param name="duration">A string or number determining how long the animation will run.</param>
        ///<param name="opacity">A number between 0 and 1 denoting the target opacity.</param>
        ///<param name="easing">A string indicating which easing function to use for the transition.</param>
        ///<param name="callback">A function to call once the animation is complete.</param>
        public extern jQuery fadeTo(string duration, Number opacity, string easing, Action callback);

        ///<summary>
        /// Adjust the opacity of the matched elements.
        ///</summary>
        ///<param name="duration">A string or number determining how long the animation will run.</param>
        ///<param name="opacity">A number between 0 and 1 denoting the target opacity.</param>
        ///<param name="easing">A string indicating which easing function to use for the transition.</param>
        public extern jQuery fadeTo(Number duration, Number opacity, string easing);

        ///<summary>
        /// Adjust the opacity of the matched elements.
        ///</summary>
        ///<param name="duration">A string or number determining how long the animation will run.</param>
        ///<param name="opacity">A number between 0 and 1 denoting the target opacity.</param>
        ///<param name="easing">A string indicating which easing function to use for the transition.</param>
        ///<param name="callback">A function to call once the animation is complete.</param>
        public extern jQuery fadeTo(Number duration, Number opacity, string easing, Action callback);

        ///<summary>
        /// Hide the matched elements by fading them to transparent.
        ///</summary>
        public extern jQuery fadeOut();

        ///<summary>
        /// Hide the matched elements by fading them to transparent.
        ///</summary>
        ///<param name="duration">A string or number determining how long the animation will run.</param>
        public extern jQuery fadeOut(string duration);

        ///<summary>
        /// Hide the matched elements by fading them to transparent.
        ///</summary>
        ///<param name="duration">A string or number determining how long the animation will run.</param>
        ///<param name="callback">A function to call once the animation is complete.</param>
        public extern jQuery fadeOut(string duration, Action callback);

        ///<summary>
        /// Hide the matched elements by fading them to transparent.
        ///</summary>
        ///<param name="duration">A string or number determining how long the animation will run.</param>
        public extern jQuery fadeOut(Number duration);

        ///<summary>
        /// Hide the matched elements by fading them to transparent.
        ///</summary>
        ///<param name="duration">A string or number determining how long the animation will run.</param>
        ///<param name="callback">A function to call once the animation is complete.</param>
        public extern jQuery fadeOut(Number duration, Action callback);

        ///<summary>
        /// Hide the matched elements by fading them to transparent.
        ///</summary>
        ///<param name="duration">A string or number determining how long the animation will run.</param>
        ///<param name="easing">A string indicating which easing function to use for the transition.</param>
        public extern jQuery fadeOut(string duration, string easing);

        ///<summary>
        /// Hide the matched elements by fading them to transparent.
        ///</summary>
        ///<param name="duration">A string or number determining how long the animation will run.</param>
        ///<param name="easing">A string indicating which easing function to use for the transition.</param>
        ///<param name="callback">A function to call once the animation is complete.</param>
        public extern jQuery fadeOut(string duration, string easing, Action callback);

        ///<summary>
        /// Hide the matched elements by fading them to transparent.
        ///</summary>
        ///<param name="duration">A string or number determining how long the animation will run.</param>
        ///<param name="easing">A string indicating which easing function to use for the transition.</param>
        public extern jQuery fadeOut(Number duration, string easing);

        ///<summary>
        /// Hide the matched elements by fading them to transparent.
        ///</summary>
        ///<param name="duration">A string or number determining how long the animation will run.</param>
        ///<param name="easing">A string indicating which easing function to use for the transition.</param>
        ///<param name="callback">A function to call once the animation is complete.</param>
        public extern jQuery fadeOut(Number duration, string easing, Action callback);

        ///<summary>
        /// Get the ancestors of each element in the current set of matched elements, optionally filtered by a selector.
        ///</summary>
        public extern jQuery parents();

        ///<summary>
        /// Get the ancestors of each element in the current set of matched elements, optionally filtered by a selector.
        ///</summary>
        ///<param name="selector">A string containing a selector expression to match elements against.</param>
        public extern jQuery parents(string selector);

        ///<summary>
        /// Display the matched elements by fading them to opaque.
        ///</summary>
        public extern jQuery fadeIn();

        ///<summary>
        /// Display the matched elements by fading them to opaque.
        ///</summary>
        ///<param name="duration">A string or number determining how long the animation will run.</param>
        public extern jQuery fadeIn(string duration);

        ///<summary>
        /// Display the matched elements by fading them to opaque.
        ///</summary>
        ///<param name="duration">A string or number determining how long the animation will run.</param>
        ///<param name="callback">A function to call once the animation is complete.</param>
        public extern jQuery fadeIn(string duration, Action callback);

        ///<summary>
        /// Display the matched elements by fading them to opaque.
        ///</summary>
        ///<param name="duration">A string or number determining how long the animation will run.</param>
        public extern jQuery fadeIn(Number duration);

        ///<summary>
        /// Display the matched elements by fading them to opaque.
        ///</summary>
        ///<param name="duration">A string or number determining how long the animation will run.</param>
        ///<param name="callback">A function to call once the animation is complete.</param>
        public extern jQuery fadeIn(Number duration, Action callback);

        ///<summary>
        /// Display the matched elements by fading them to opaque.
        ///</summary>
        ///<param name="duration">A string or number determining how long the animation will run.</param>
        ///<param name="easing">A string indicating which easing function to use for the transition.</param>
        public extern jQuery fadeIn(string duration, string easing);

        ///<summary>
        /// Display the matched elements by fading them to opaque.
        ///</summary>
        ///<param name="duration">A string or number determining how long the animation will run.</param>
        ///<param name="easing">A string indicating which easing function to use for the transition.</param>
        ///<param name="callback">A function to call once the animation is complete.</param>
        public extern jQuery fadeIn(string duration, string easing, Action callback);

        ///<summary>
        /// Display the matched elements by fading them to opaque.
        ///</summary>
        ///<param name="duration">A string or number determining how long the animation will run.</param>
        ///<param name="easing">A string indicating which easing function to use for the transition.</param>
        public extern jQuery fadeIn(Number duration, string easing);

        ///<summary>
        /// Display the matched elements by fading them to opaque.
        ///</summary>
        ///<param name="duration">A string or number determining how long the animation will run.</param>
        ///<param name="easing">A string indicating which easing function to use for the transition.</param>
        ///<param name="callback">A function to call once the animation is complete.</param>
        public extern jQuery fadeIn(Number duration, string easing, Action callback);

        ///<summary>
        /// Get the parent of each element in the current set of matched elements, optionally filtered by a selector.
        ///</summary>
        public extern jQuery parent();

        ///<summary>
        /// Get the parent of each element in the current set of matched elements, optionally filtered by a selector.
        ///</summary>
        ///<param name="selector">A string containing a selector expression to match elements against.</param>
        public extern jQuery parent(string selector);

        ///<summary>
        /// Get the closest ancestor element that is positioned.
        ///</summary>
        public extern jQuery offsetParent();

        ///<summary>
        /// Display or hide the matched elements with a sliding motion.
        ///</summary>
        public extern jQuery slideToggle();

        ///<summary>
        /// Display or hide the matched elements with a sliding motion.
        ///</summary>
        ///<param name="duration">A string or number determining how long the animation will run.</param>
        public extern jQuery slideToggle(string duration);

        ///<summary>
        /// Display or hide the matched elements with a sliding motion.
        ///</summary>
        ///<param name="duration">A string or number determining how long the animation will run.</param>
        ///<param name="callback">A function to call once the animation is complete.</param>
        public extern jQuery slideToggle(string duration, Action callback);

        ///<summary>
        /// Display or hide the matched elements with a sliding motion.
        ///</summary>
        ///<param name="duration">A string or number determining how long the animation will run.</param>
        public extern jQuery slideToggle(Number duration);

        ///<summary>
        /// Display or hide the matched elements with a sliding motion.
        ///</summary>
        ///<param name="duration">A string or number determining how long the animation will run.</param>
        ///<param name="callback">A function to call once the animation is complete.</param>
        public extern jQuery slideToggle(Number duration, Action callback);

        ///<summary>
        /// Display or hide the matched elements with a sliding motion.
        ///</summary>
        ///<param name="duration">A string or number determining how long the animation will run.</param>
        ///<param name="easing">A string indicating which easing function to use for the transition.</param>
        public extern jQuery slideToggle(string duration, string easing);

        ///<summary>
        /// Display or hide the matched elements with a sliding motion.
        ///</summary>
        ///<param name="duration">A string or number determining how long the animation will run.</param>
        ///<param name="easing">A string indicating which easing function to use for the transition.</param>
        ///<param name="callback">A function to call once the animation is complete.</param>
        public extern jQuery slideToggle(string duration, string easing, Action callback);

        ///<summary>
        /// Display or hide the matched elements with a sliding motion.
        ///</summary>
        ///<param name="duration">A string or number determining how long the animation will run.</param>
        ///<param name="easing">A string indicating which easing function to use for the transition.</param>
        public extern jQuery slideToggle(Number duration, string easing);

        ///<summary>
        /// Display or hide the matched elements with a sliding motion.
        ///</summary>
        ///<param name="duration">A string or number determining how long the animation will run.</param>
        ///<param name="easing">A string indicating which easing function to use for the transition.</param>
        ///<param name="callback">A function to call once the animation is complete.</param>
        public extern jQuery slideToggle(Number duration, string easing, Action callback);

        ///<summary>
        /// Load data from the server using a HTTP POST request.
        ///</summary>
        ///<param name="url">A string containing the URL to which the request is sent.</param>
        public extern static jqXHR post(string url);

        ///<summary>
        /// Load data from the server using a HTTP POST request.
        ///</summary>
        ///<param name="url">A string containing the URL to which the request is sent.</param>
        ///<param name="data">A map or string that is sent to the server with the request.</param>
        public extern static jqXHR post(string url, object data);

        ///<summary>
        /// Load data from the server using a HTTP POST request.
        ///</summary>
        ///<param name="url">A string containing the URL to which the request is sent.</param>
        ///<param name="data">A map or string that is sent to the server with the request.</param>
        ///<param name="callback">A callback function that is executed if the request succeeds.</param>
        public extern static jqXHR post(string url, object data, Action<object, string, jqXHR> callback);

        ///<summary>
        /// Load data from the server using a HTTP POST request.
        ///</summary>
        ///<param name="url">A string containing the URL to which the request is sent.</param>
        ///<param name="data">A map or string that is sent to the server with the request.</param>
        ///<param name="callback">A callback function that is executed if the request succeeds.</param>
        ///<param name="dataType">The type of data expected from the server. Default: Intelligent Guess (xml, json, script, text, html).</param>
        public extern static jqXHR post(string url, object data, Action<object, string, jqXHR> callback, string dataType);

        ///<summary>
        /// Load data from the server using a HTTP POST request.
        ///</summary>
        ///<param name="url">A string containing the URL to which the request is sent.</param>
        ///<param name="data">A map or string that is sent to the server with the request.</param>
        public extern static jqXHR post(string url, string data);

        ///<summary>
        /// Load data from the server using a HTTP POST request.
        ///</summary>
        ///<param name="url">A string containing the URL to which the request is sent.</param>
        ///<param name="data">A map or string that is sent to the server with the request.</param>
        ///<param name="callback">A callback function that is executed if the request succeeds.</param>
        public extern static jqXHR post(string url, string data, Action<object, string, jqXHR> callback);

        ///<summary>
        /// Load data from the server using a HTTP POST request.
        ///</summary>
        ///<param name="url">A string containing the URL to which the request is sent.</param>
        ///<param name="data">A map or string that is sent to the server with the request.</param>
        ///<param name="callback">A callback function that is executed if the request succeeds.</param>
        ///<param name="dataType">The type of data expected from the server. Default: Intelligent Guess (xml, json, script, text, html).</param>
        public extern static jqXHR post(string url, string data, Action<object, string, jqXHR> callback, string dataType);

        ///<summary>
        /// Hide the matched elements with a sliding motion.
        ///</summary>
        public extern jQuery slideUp();

        ///<summary>
        /// Hide the matched elements with a sliding motion.
        ///</summary>
        ///<param name="duration">A string or number determining how long the animation will run.</param>
        public extern jQuery slideUp(string duration);

        ///<summary>
        /// Hide the matched elements with a sliding motion.
        ///</summary>
        ///<param name="duration">A string or number determining how long the animation will run.</param>
        ///<param name="callback">A function to call once the animation is complete.</param>
        public extern jQuery slideUp(string duration, Action callback);

        ///<summary>
        /// Hide the matched elements with a sliding motion.
        ///</summary>
        ///<param name="duration">A string or number determining how long the animation will run.</param>
        public extern jQuery slideUp(Number duration);

        ///<summary>
        /// Hide the matched elements with a sliding motion.
        ///</summary>
        ///<param name="duration">A string or number determining how long the animation will run.</param>
        ///<param name="callback">A function to call once the animation is complete.</param>
        public extern jQuery slideUp(Number duration, Action callback);

        ///<summary>
        /// Hide the matched elements with a sliding motion.
        ///</summary>
        ///<param name="duration">A string or number determining how long the animation will run.</param>
        ///<param name="easing">A string indicating which easing function to use for the transition.</param>
        public extern jQuery slideUp(string duration, string easing);

        ///<summary>
        /// Hide the matched elements with a sliding motion.
        ///</summary>
        ///<param name="duration">A string or number determining how long the animation will run.</param>
        ///<param name="easing">A string indicating which easing function to use for the transition.</param>
        ///<param name="callback">A function to call once the animation is complete.</param>
        public extern jQuery slideUp(string duration, string easing, Action callback);

        ///<summary>
        /// Hide the matched elements with a sliding motion.
        ///</summary>
        ///<param name="duration">A string or number determining how long the animation will run.</param>
        ///<param name="easing">A string indicating which easing function to use for the transition.</param>
        public extern jQuery slideUp(Number duration, string easing);

        ///<summary>
        /// Hide the matched elements with a sliding motion.
        ///</summary>
        ///<param name="duration">A string or number determining how long the animation will run.</param>
        ///<param name="easing">A string indicating which easing function to use for the transition.</param>
        ///<param name="callback">A function to call once the animation is complete.</param>
        public extern jQuery slideUp(Number duration, string easing, Action callback);

        ///<summary>
        /// Get all following siblings of each element in the set of matched elements, optionally filtered by a selector.
        ///</summary>
        public extern jQuery nextAll();

        ///<summary>
        /// Get all following siblings of each element in the set of matched elements, optionally filtered by a selector.
        ///</summary>
        ///<param name="selector">A string containing a selector expression to match elements against.</param>
        public extern jQuery nextAll(string selector);

        ///<summary>
        /// Get the immediately following sibling of each element in the set of matched elements. If a selector is provided, it retrieves the next sibling only if it matches that selector.
        ///</summary>
        public extern jQuery next();

        ///<summary>
        /// Get the immediately following sibling of each element in the set of matched elements. If a selector is provided, it retrieves the next sibling only if it matches that selector.
        ///</summary>
        ///<param name="selector">A string containing a selector expression to match elements against.</param>
        public extern jQuery next(string selector);

        ///<summary>
        /// Display the matched elements with a sliding motion.
        ///</summary>
        public extern jQuery slideDown();

        ///<summary>
        /// Display the matched elements with a sliding motion.
        ///</summary>
        ///<param name="duration">A string or number determining how long the animation will run.</param>
        public extern jQuery slideDown(string duration);

        ///<summary>
        /// Display the matched elements with a sliding motion.
        ///</summary>
        ///<param name="duration">A string or number determining how long the animation will run.</param>
        ///<param name="callback">A function to call once the animation is complete.</param>
        public extern jQuery slideDown(string duration, Action callback);

        ///<summary>
        /// Display the matched elements with a sliding motion.
        ///</summary>
        ///<param name="duration">A string or number determining how long the animation will run.</param>
        public extern jQuery slideDown(Number duration);

        ///<summary>
        /// Display the matched elements with a sliding motion.
        ///</summary>
        ///<param name="duration">A string or number determining how long the animation will run.</param>
        ///<param name="callback">A function to call once the animation is complete.</param>
        public extern jQuery slideDown(Number duration, Action callback);

        ///<summary>
        /// Display the matched elements with a sliding motion.
        ///</summary>
        ///<param name="duration">A string or number determining how long the animation will run.</param>
        ///<param name="easing">A string indicating which easing function to use for the transition.</param>
        public extern jQuery slideDown(string duration, string easing);

        ///<summary>
        /// Display the matched elements with a sliding motion.
        ///</summary>
        ///<param name="duration">A string or number determining how long the animation will run.</param>
        ///<param name="easing">A string indicating which easing function to use for the transition.</param>
        ///<param name="callback">A function to call once the animation is complete.</param>
        public extern jQuery slideDown(string duration, string easing, Action callback);

        ///<summary>
        /// Display the matched elements with a sliding motion.
        ///</summary>
        ///<param name="duration">A string or number determining how long the animation will run.</param>
        ///<param name="easing">A string indicating which easing function to use for the transition.</param>
        public extern jQuery slideDown(Number duration, string easing);

        ///<summary>
        /// Display the matched elements with a sliding motion.
        ///</summary>
        ///<param name="duration">A string or number determining how long the animation will run.</param>
        ///<param name="easing">A string indicating which easing function to use for the transition.</param>
        ///<param name="callback">A function to call once the animation is complete.</param>
        public extern jQuery slideDown(Number duration, string easing, Action callback);

        ///<summary>
        /// Get the descendants of each element in the current set of matched elements, filtered by a selector, jQuery object, or element.
        ///</summary>
        ///<param name="selector">A string containing a selector expression to match elements against.</param>
        public extern jQuery find(string selector);

        ///<summary>
        /// Get the descendants of each element in the current set of matched elements, filtered by a selector, jQuery object, or element.
        ///</summary>
        ///<param name="object">A jQuery object to match elements against.</param>
        public extern jQuery find(jQuery @object);

        ///<summary>
        /// Get the descendants of each element in the current set of matched elements, filtered by a selector, jQuery object, or element.
        ///</summary>
        ///<param name="element">An element to match elements against.</param>
        public extern jQuery find(Element element);

        ///<summary>
        /// Load a JavaScript file from the server using a GET HTTP request, then execute it.
        ///</summary>
        ///<param name="url">A string containing the URL to which the request is sent.</param>
        public extern static jqXHR getScript(string url);

        ///<summary>
        /// Load a JavaScript file from the server using a GET HTTP request, then execute it.
        ///</summary>
        ///<param name="url">A string containing the URL to which the request is sent.</param>
        ///<param name="callback">A callback function that is executed if the request succeeds.</param>
        public extern static jqXHR getScript(string url, Action<object, string, jqXHR> callback);

        ///<summary>
        /// Get the children of each element in the set of matched elements, including text and comment nodes.
        ///</summary>
        public extern jQuery contents();

        ///<summary>
        /// Get the first element that matches the selector, beginning at the current element and progressing up through the DOM tree.
        ///</summary>
        ///<param name="selector">A string containing a selector expression to match elements against.</param>
        public extern jQuery closest(string selector);

        ///<summary>
        /// Get the first element that matches the selector, beginning at the current element and progressing up through the DOM tree.
        ///</summary>
        ///<param name="selector">A string containing a selector expression to match elements against.</param>
        ///<param name="context">A DOM element within which a matching element may be found. If no context is passed in then the context of the jQuery set will be used instead.</param>
        public extern jQuery closest(string selector, Element context);

        ///<summary>
        /// Get the first element that matches the selector, beginning at the current element and progressing up through the DOM tree.
        ///</summary>
        ///<param name="object">A jQuery object to match elements against.</param>
        public extern jQuery closest(jQuery @object);

        ///<summary>
        /// Get the first element that matches the selector, beginning at the current element and progressing up through the DOM tree.
        ///</summary>
        ///<param name="element">An element to match elements against.</param>
        public extern jQuery closest(Element element);

        ///<summary>
        /// Gets an array of all the elements and selectors matched against the current element up through the DOM tree.
        ///</summary>
        ///<param name="selectors">An array or string containing a selector expression to match elements against (can also be a jQuery object).</param>
        public extern Array closest(Array selectors);

        ///<summary>
        /// Gets an array of all the elements and selectors matched against the current element up through the DOM tree.
        ///</summary>
        ///<param name="selectors">An array or string containing a selector expression to match elements against (can also be a jQuery object).</param>
        ///<param name="context">A DOM element within which a matching element may be found. If no context is passed in then the context of the jQuery set will be used instead.</param>
        public extern Array closest(Array selectors, Element context);

        ///<summary>
        /// Load JSON-encoded data from the server using a GET HTTP request.
        ///</summary>
        ///<param name="url">A string containing the URL to which the request is sent.</param>
        public extern static jqXHR getJSON(string url);

        ///<summary>
        /// Load JSON-encoded data from the server using a GET HTTP request.
        ///</summary>
        ///<param name="url">A string containing the URL to which the request is sent.</param>
        ///<param name="data">A map or string that is sent to the server with the request.</param>
        public extern static jqXHR getJSON(string url, object data);

        ///<summary>
        /// Load JSON-encoded data from the server using a GET HTTP request.
        ///</summary>
        ///<param name="url">A string containing the URL to which the request is sent.</param>
        ///<param name="data">A map or string that is sent to the server with the request.</param>
        ///<param name="callback">A callback function that is executed if the request succeeds.</param>
        public extern static jqXHR getJSON(string url, object data, Action<object, string, jqXHR> callback);

        ///<summary>
        /// Load data from the server using a HTTP GET request.
        ///</summary>
        ///<param name="url">A string containing the URL to which the request is sent.</param>
        public extern static jqXHR get(string url);

        ///<summary>
        /// Load data from the server using a HTTP GET request.
        ///</summary>
        ///<param name="url">A string containing the URL to which the request is sent.</param>
        ///<param name="data">A map or string that is sent to the server with the request.</param>
        public extern static jqXHR get(string url, object data);

        ///<summary>
        /// Load data from the server using a HTTP GET request.
        ///</summary>
        ///<param name="url">A string containing the URL to which the request is sent.</param>
        ///<param name="data">A map or string that is sent to the server with the request.</param>
        ///<param name="callback">A callback function that is executed if the request succeeds.</param>
        public extern static jqXHR get(string url, object data, Action<object, string, jqXHR> callback);

        ///<summary>
        /// Load data from the server using a HTTP GET request.
        ///</summary>
        ///<param name="url">A string containing the URL to which the request is sent.</param>
        ///<param name="data">A map or string that is sent to the server with the request.</param>
        ///<param name="callback">A callback function that is executed if the request succeeds.</param>
        ///<param name="dataType">The type of data expected from the server. Default: Intelligent Guess (xml, json, script, or html).</param>
        public extern static jqXHR get(string url, object data, Action<object, string, jqXHR> callback, string dataType);

        ///<summary>
        /// Load data from the server using a HTTP GET request.
        ///</summary>
        ///<param name="url">A string containing the URL to which the request is sent.</param>
        ///<param name="data">A map or string that is sent to the server with the request.</param>
        public extern static jqXHR get(string url, string data);

        ///<summary>
        /// Load data from the server using a HTTP GET request.
        ///</summary>
        ///<param name="url">A string containing the URL to which the request is sent.</param>
        ///<param name="data">A map or string that is sent to the server with the request.</param>
        ///<param name="callback">A callback function that is executed if the request succeeds.</param>
        public extern static jqXHR get(string url, string data, Action<object, string, jqXHR> callback);

        ///<summary>
        /// Load data from the server using a HTTP GET request.
        ///</summary>
        ///<param name="url">A string containing the URL to which the request is sent.</param>
        ///<param name="data">A map or string that is sent to the server with the request.</param>
        ///<param name="callback">A callback function that is executed if the request succeeds.</param>
        ///<param name="dataType">The type of data expected from the server. Default: Intelligent Guess (xml, json, script, or html).</param>
        public extern static jqXHR get(string url, string data, Action<object, string, jqXHR> callback, string dataType);

        ///<summary>
        /// Load data from the server and place the returned HTML into the matched element.
        ///</summary>
        ///<param name="url">A string containing the URL to which the request is sent.</param>
        public extern jQuery load(string url);

        ///<summary>
        /// Load data from the server and place the returned HTML into the matched element.
        ///</summary>
        ///<param name="url">A string containing the URL to which the request is sent.</param>
        ///<param name="data">A map or string that is sent to the server with the request.</param>
        public extern jQuery load(string url, object data);

        ///<summary>
        /// Load data from the server and place the returned HTML into the matched element.
        ///</summary>
        ///<param name="url">A string containing the URL to which the request is sent.</param>
        ///<param name="data">A map or string that is sent to the server with the request.</param>
        ///<param name="callback">A callback function that is executed when the request completes.</param>
        public extern jQuery load(string url, object data, Action<string, string, XMLHttpRequest> callback);

        ///<summary>
        /// Load data from the server and place the returned HTML into the matched element.
        ///</summary>
        ///<param name="url">A string containing the URL to which the request is sent.</param>
        ///<param name="data">A map or string that is sent to the server with the request.</param>
        public extern jQuery load(string url, string data);

        ///<summary>
        /// Load data from the server and place the returned HTML into the matched element.
        ///</summary>
        ///<param name="url">A string containing the URL to which the request is sent.</param>
        ///<param name="data">A map or string that is sent to the server with the request.</param>
        ///<param name="callback">A callback function that is executed when the request completes.</param>
        public extern jQuery load(string url, string data, Action<string, string, XMLHttpRequest> callback);

        ///<summary>
        /// Perform an asynchronous HTTP (Ajax) request.
        ///</summary>
        ///<param name="url">A string containing the URL to which the request is sent.</param>
        public extern static jqXHR ajax(string url);

        ///<summary>
        /// Perform an asynchronous HTTP (Ajax) request.
        ///</summary>
        ///<param name="url">A string containing the URL to which the request is sent.</param>
        ///<param name="settings">A set of key/value pairs that configure the Ajax request. All settings are optional. A default can be set for any option with $.ajaxSetup(). See jQuery.ajax( settings ) below for a complete list of all settings.</param>
        public extern static jqXHR ajax(string url, object settings);

        ///<summary>
        /// Perform an asynchronous HTTP (Ajax) request.
        ///</summary>
        ///<param name="settings">A set of key/value pairs that configure the Ajax request. All settings are optional. A default can be set for any option with $.ajaxSetup().</param>
        public extern static jqXHR ajax(object settings);

        ///<summary>
        /// Get the children of each element in the set of matched elements, optionally filtered by a selector.
        ///</summary>
        public extern jQuery children();

        ///<summary>
        /// Get the children of each element in the set of matched elements, optionally filtered by a selector.
        ///</summary>
        ///<param name="selector">A string containing a selector expression to match elements against.</param>
        public extern jQuery children(string selector);

        ///<summary>
        /// Add elements to the set of matched elements.
        ///</summary>
        ///<param name="selector">A string representing a selector expression to find additional elements to add to the set of matched elements.</param>
        public extern jQuery add(string selector);

        ///<summary>
        /// Add elements to the set of matched elements.
        ///</summary>
        ///<param name="elements">One or more elements to add to the set of matched elements.</param>
        public extern jQuery add(Element[] elements);

        ///<summary>
        /// Add elements to the set of matched elements.
        ///</summary>
        ///<param name="object">An existing jQuery object to add to the set of matched elements.</param>
        public extern jQuery add(jQuery @object);

        ///<summary>
        /// Add elements to the set of matched elements.
        ///</summary>
        ///<param name="selector">A string representing a selector expression to find additional elements to add to the set of matched elements.</param>
        ///<param name="context">The point in the document at which the selector should begin matching; similar to the context argument of the $(selector, context) method.</param>
        public extern jQuery add(string selector, Element context);

        ///<summary>
        /// Remove elements from the set of matched elements.
        ///</summary>
        ///<param name="selector">A string containing a selector expression to match elements against.</param>
        public extern jQuery not(string selector);

        ///<summary>
        /// Remove elements from the set of matched elements.
        ///</summary>
        ///<param name="elements">One or more DOM elements to remove from the matched set.</param>
        public extern jQuery not(Element[] elements);

        ///<summary>
        /// Remove elements from the set of matched elements.
        ///</summary>
        ///<param name="callback">A function used as a test for each element in the set. this is the current DOM element.</param>
        public extern jQuery not(Action<int> callback);

        ///<summary>
        /// Remove elements from the set of matched elements.
        ///</summary>
        ///<param name="object">An existing jQuery object to match the current set of elements against.</param>
        public extern jQuery not(jQuery @object);

        ///<summary>
        /// Get the current computed width for the first element in the set of matched elements, including padding and border.
        ///</summary>
        public extern int outerWidth();

        ///<summary>
        /// Get the current computed width for the first element in the set of matched elements, including padding and border.
        ///</summary>
        ///<param name="includeMargin">A Boolean indicating whether to include the element's margin in the calculation.</param>
        public extern int outerWidth(bool includeMargin);

        ///<summary>
        /// Get the current computed height for the first element in the set of matched elements, including padding, border, and optionally margin. Returns an integer (without "px") representation of the value or null if called on an empty set of elements.
        ///</summary>
        public extern int outerHeight();

        ///<summary>
        /// Get the current computed height for the first element in the set of matched elements, including padding, border, and optionally margin. Returns an integer (without "px") representation of the value or null if called on an empty set of elements.
        ///</summary>
        ///<param name="includeMargin">A Boolean indicating whether to include the element's margin in the calculation.</param>
        public extern int outerHeight(bool includeMargin);

        ///<summary>
        /// Display or hide the matched elements.
        ///</summary>
        public extern jQuery toggle();

        ///<summary>
        /// Display or hide the matched elements.
        ///</summary>
        ///<param name="duration">A string or number determining how long the animation will run.</param>
        public extern jQuery toggle(string duration);

        ///<summary>
        /// Display or hide the matched elements.
        ///</summary>
        ///<param name="duration">A string or number determining how long the animation will run.</param>
        ///<param name="callback">A function to call once the animation is complete.</param>
        public extern jQuery toggle(string duration, Action callback);

        ///<summary>
        /// Display or hide the matched elements.
        ///</summary>
        ///<param name="duration">A string or number determining how long the animation will run.</param>
        public extern jQuery toggle(Number duration);

        ///<summary>
        /// Display or hide the matched elements.
        ///</summary>
        ///<param name="duration">A string or number determining how long the animation will run.</param>
        ///<param name="callback">A function to call once the animation is complete.</param>
        public extern jQuery toggle(Number duration, Action callback);

        ///<summary>
        /// Display or hide the matched elements.
        ///</summary>
        ///<param name="duration">A string or number determining how long the animation will run.</param>
        ///<param name="easing">A string indicating which easing function to use for the transition.</param>
        public extern jQuery toggle(string duration, string easing);

        ///<summary>
        /// Display or hide the matched elements.
        ///</summary>
        ///<param name="duration">A string or number determining how long the animation will run.</param>
        ///<param name="easing">A string indicating which easing function to use for the transition.</param>
        ///<param name="callback">A function to call once the animation is complete.</param>
        public extern jQuery toggle(string duration, string easing, Action callback);

        ///<summary>
        /// Display or hide the matched elements.
        ///</summary>
        ///<param name="duration">A string or number determining how long the animation will run.</param>
        ///<param name="easing">A string indicating which easing function to use for the transition.</param>
        public extern jQuery toggle(Number duration, string easing);

        ///<summary>
        /// Display or hide the matched elements.
        ///</summary>
        ///<param name="duration">A string or number determining how long the animation will run.</param>
        ///<param name="easing">A string indicating which easing function to use for the transition.</param>
        ///<param name="callback">A function to call once the animation is complete.</param>
        public extern jQuery toggle(Number duration, string easing, Action callback);

        ///<summary>
        /// Display or hide the matched elements.
        ///</summary>
        ///<param name="showOrHide">A Boolean indicating whether to show or hide the elements.</param>
        public extern jQuery toggle(bool showOrHide);

        ///<summary>
        /// Get the current computed width for the first element in the set of matched elements, including padding but not border.
        ///</summary>
        public extern int innerWidth();

        ///<summary>
        /// Get the current computed height for the first element in the set of matched elements, including padding but not border.
        ///</summary>
        public extern int innerHeight();

        ///<summary>
        /// Create a serialized representation of an array or object, suitable for use in a URL query string or Ajax request. 
        ///</summary>
        ///<param name="obj">An array or object to serialize.</param>
        public extern static String param(Array obj);

        ///<summary>
        /// Create a serialized representation of an array or object, suitable for use in a URL query string or Ajax request. 
        ///</summary>
        ///<param name="obj">An array or object to serialize.</param>
        public extern static String param(Object obj);

        ///<summary>
        /// Create a serialized representation of an array or object, suitable for use in a URL query string or Ajax request. 
        ///</summary>
        ///<param name="obj">An array or object to serialize.</param>
        ///<param name="traditional">A Boolean indicating whether to perform a traditional "shallow" serialization.</param>
        public extern static String param(Array obj, bool traditional);

        ///<summary>
        /// Create a serialized representation of an array or object, suitable for use in a URL query string or Ajax request. 
        ///</summary>
        ///<param name="obj">An array or object to serialize.</param>
        ///<param name="traditional">A Boolean indicating whether to perform a traditional "shallow" serialization.</param>
        public extern static String param(Object obj, bool traditional);

        ///<summary>
        /// Hide the matched elements.
        ///</summary>
        public extern jQuery hide();

        ///<summary>
        /// Hide the matched elements.
        ///</summary>
        ///<param name="duration">A string or number determining how long the animation will run.</param>
        public extern jQuery hide(string duration);

        ///<summary>
        /// Hide the matched elements.
        ///</summary>
        ///<param name="duration">A string or number determining how long the animation will run.</param>
        ///<param name="callback">A function to call once the animation is complete.</param>
        public extern jQuery hide(string duration, Action callback);

        ///<summary>
        /// Hide the matched elements.
        ///</summary>
        ///<param name="duration">A string or number determining how long the animation will run.</param>
        public extern jQuery hide(Number duration);

        ///<summary>
        /// Hide the matched elements.
        ///</summary>
        ///<param name="duration">A string or number determining how long the animation will run.</param>
        ///<param name="callback">A function to call once the animation is complete.</param>
        public extern jQuery hide(Number duration, Action callback);

        ///<summary>
        /// Hide the matched elements.
        ///</summary>
        ///<param name="duration">A string or number determining how long the animation will run.</param>
        ///<param name="easing">A string indicating which easing function to use for the transition.</param>
        public extern jQuery hide(string duration, string easing);

        ///<summary>
        /// Hide the matched elements.
        ///</summary>
        ///<param name="duration">A string or number determining how long the animation will run.</param>
        ///<param name="easing">A string indicating which easing function to use for the transition.</param>
        ///<param name="callback">A function to call once the animation is complete.</param>
        public extern jQuery hide(string duration, string easing, Action callback);

        ///<summary>
        /// Hide the matched elements.
        ///</summary>
        ///<param name="duration">A string or number determining how long the animation will run.</param>
        ///<param name="easing">A string indicating which easing function to use for the transition.</param>
        public extern jQuery hide(Number duration, string easing);

        ///<summary>
        /// Hide the matched elements.
        ///</summary>
        ///<param name="duration">A string or number determining how long the animation will run.</param>
        ///<param name="easing">A string indicating which easing function to use for the transition.</param>
        ///<param name="callback">A function to call once the animation is complete.</param>
        public extern jQuery hide(Number duration, string easing, Action callback);

        ///<summary>
        /// Get the current computed width for the first element in the set of matched elements.
        ///</summary>
        public extern int width();

        ///<summary>
        /// Set the CSS width of each element in the set of matched elements.
        ///</summary>
        ///<param name="value">An integer representing the number of pixels, or an integer along with an optional unit of measure appended (as a string).</param>
        public extern jQuery width(string value);

        ///<summary>
        /// Set the CSS width of each element in the set of matched elements.
        ///</summary>
        ///<param name="value">An integer representing the number of pixels, or an integer along with an optional unit of measure appended (as a string).</param>
        public extern jQuery width(Number value);

        ///<summary>
        /// Set the CSS width of each element in the set of matched elements.
        ///</summary>
        ///<param name="callback">A function returning the width to set. Receives the index position of the element in the set and the old width as arguments. Within the function, this refers to the current element in the set.</param>
        public extern jQuery width(Action<int, object> callback);

        ///<summary>
        /// Get the current computed height for the first element in the set of matched elements.
        ///</summary>
        public extern int height();

        ///<summary>
        /// Set the CSS height of every matched element.
        ///</summary>
        ///<param name="value">An integer representing the number of pixels, or an integer with an optional unit of measure appended (as a string).</param>
        public extern jQuery height(string value);

        ///<summary>
        /// Set the CSS height of every matched element.
        ///</summary>
        ///<param name="value">An integer representing the number of pixels, or an integer with an optional unit of measure appended (as a string).</param>
        public extern jQuery height(Number value);

        ///<summary>
        /// Set the CSS height of every matched element.
        ///</summary>
        ///<param name="callback">A function returning the height to set. Receives the index position of the element in the set and the old height as arguments. Within the function, this refers to the current element in the set.</param>
        public extern jQuery height(Action<int, object> callback);

        ///<summary>
        /// Display the matched elements.
        ///</summary>
        public extern jQuery show();

        ///<summary>
        /// Display the matched elements.
        ///</summary>
        ///<param name="duration">A string or number determining how long the animation will run.</param>
        public extern jQuery show(string duration);

        ///<summary>
        /// Display the matched elements.
        ///</summary>
        ///<param name="duration">A string or number determining how long the animation will run.</param>
        ///<param name="callback">A function to call once the animation is complete.</param>
        public extern jQuery show(string duration, Action callback);

        ///<summary>
        /// Display the matched elements.
        ///</summary>
        ///<param name="duration">A string or number determining how long the animation will run.</param>
        public extern jQuery show(Number duration);

        ///<summary>
        /// Display the matched elements.
        ///</summary>
        ///<param name="duration">A string or number determining how long the animation will run.</param>
        ///<param name="callback">A function to call once the animation is complete.</param>
        public extern jQuery show(Number duration, Action callback);

        ///<summary>
        /// Display the matched elements.
        ///</summary>
        ///<param name="duration">A string or number determining how long the animation will run.</param>
        ///<param name="easing">A string indicating which easing function to use for the transition.</param>
        public extern jQuery show(string duration, string easing);

        ///<summary>
        /// Display the matched elements.
        ///</summary>
        ///<param name="duration">A string or number determining how long the animation will run.</param>
        ///<param name="easing">A string indicating which easing function to use for the transition.</param>
        ///<param name="callback">A function to call once the animation is complete.</param>
        public extern jQuery show(string duration, string easing, Action callback);

        ///<summary>
        /// Display the matched elements.
        ///</summary>
        ///<param name="duration">A string or number determining how long the animation will run.</param>
        ///<param name="easing">A string indicating which easing function to use for the transition.</param>
        public extern jQuery show(Number duration, string easing);

        ///<summary>
        /// Display the matched elements.
        ///</summary>
        ///<param name="duration">A string or number determining how long the animation will run.</param>
        ///<param name="easing">A string indicating which easing function to use for the transition.</param>
        ///<param name="callback">A function to call once the animation is complete.</param>
        public extern jQuery show(Number duration, string easing, Action callback);

        ///<summary>
        /// Get the current horizontal position of the scroll bar for the first element in the set of matched elements.
        ///</summary>
        public extern int scrollLeft();

        ///<summary>
        /// Set the current horizontal position of the scroll bar for each of the set of matched elements.
        ///</summary>
        ///<param name="value">An integer indicating the new position to set the scroll bar to.</param>
        public extern jQuery scrollLeft(Number value);

        ///<summary>
        /// Remove the whitespace from the beginning and end of a string.
        ///</summary>
        ///<param name="str">The string to trim.</param>
        public extern static String trim(string str);

        ///<summary>
        /// Determine if the argument passed is a Javascript function object. 
        ///</summary>
        ///<param name="obj">Object to test whether or not it is a function.</param>
        public extern static bool isFunction(Object obj);

        ///<summary>
        /// Determine whether the argument is an array.
        ///</summary>
        ///<param name="obj">Object to test whether or not it is an array.</param>
        public extern static bool isArray(Object obj);

        ///<summary>
        /// Sorts an array of DOM elements, in place, with the duplicates removed. Note that this only works on arrays of DOM elements, not strings or numbers.
        ///</summary>
        ///<param name="array">The Array of DOM elements.</param>
        public extern static Array unique(Array array);

        ///<summary>
        /// Merge the contents of two arrays together into the first array. 
        ///</summary>
        ///<param name="first">The first array to merge, the elements of second added.</param>
        ///<param name="second">The second array to merge into the first, unaltered.</param>
        public extern static Array merge(Array first, Array second);

        ///<summary>
        /// Search for a specified value within an array and return its index (or -1 if not found).
        ///</summary>
        ///<param name="value">The value to search for.</param>
        ///<param name="array">An array through which to search.</param>
        public extern static Number inArray(object value, Array array);

        ///<summary>
        /// Search for a specified value within an array and return its index (or -1 if not found).
        ///</summary>
        ///<param name="value">The value to search for.</param>
        ///<param name="array">An array through which to search.</param>
        ///<param name="fromIndex">The index of the array at which to begin the search. The default is 0, which will search the whole array.</param>
        public extern static Number inArray(object value, Array array, Number fromIndex);

        ///<summary>
        /// Translate all items in an array or object to new array of items.
        ///</summary>
        ///<param name="array">The Array to translate.</param>
        ///<param name="callback">The function to process each item against.  The first argument to the function is the array item, the second argument is the index in array The function can return any value. Within the function, this refers to the global (window) object.</param>
        public extern static Array map(Array array, Action<object, int> callback);

        ///<summary>
        /// Translate all items in an array or object to new array of items.
        ///</summary>
        ///<param name="arrayOrObject">The Array or Object to translate.</param>
        ///<param name="callback">The function to process each item against.  The first argument to the function is the value; the second argument is the index or key of the array or object property. The function can return any value to add to the array. A returned array will be flattened into the resulting array. Within the function, this refers to the global (window) object.</param>
        public extern static Array map(Array arrayOrObject, Action<object, object> callback);

        ///<summary>
        /// Translate all items in an array or object to new array of items.
        ///</summary>
        ///<param name="arrayOrObject">The Array or Object to translate.</param>
        ///<param name="callback">The function to process each item against.  The first argument to the function is the value; the second argument is the index or key of the array or object property. The function can return any value to add to the array. A returned array will be flattened into the resulting array. Within the function, this refers to the global (window) object.</param>
        public extern static Array map(Object arrayOrObject, Action<object, object> callback);

        ///<summary>
        /// Convert an array-like object into a true JavaScript array.
        ///</summary>
        ///<param name="obj">Any object to turn into a native Array.</param>
        public extern static Array makeArray(Object obj);

        ///<summary>
        /// Finds the elements of an array which satisfy a filter function. The original array is not affected.
        ///</summary>
        ///<param name="array">The array to search through.</param>
        ///<param name="callback">The function to process each item against.  The first argument to the function is the item, and the second argument is the index.  The function should return a Boolean value.  this will be the global window object.</param>
        public extern static Array grep(Array array, Action<object, int> callback);

        ///<summary>
        /// Finds the elements of an array which satisfy a filter function. The original array is not affected.
        ///</summary>
        ///<param name="array">The array to search through.</param>
        ///<param name="callback">The function to process each item against.  The first argument to the function is the item, and the second argument is the index.  The function should return a Boolean value.  this will be the global window object.</param>
        ///<param name="invert">If "invert" is false, or not provided, then the function returns an array consisting of all elements for which "callback" returns true.  If "invert" is true, then the function returns an array consisting of all elements for which "callback" returns false.</param>
        public extern static Array grep(Array array, Action<object, int> callback, bool invert);

        ///<summary>
        /// Merge the contents of two or more objects together into the first object.
        ///</summary>
        ///<param name="target">An object that will receive the new properties if additional objects are passed in or that will extend the jQuery namespace if it is the sole argument.</param>
        public extern static Object extend(Object target);

        ///<summary>
        /// Merge the contents of two or more objects together into the first object.
        ///</summary>
        ///<param name="target">An object that will receive the new properties if additional objects are passed in or that will extend the jQuery namespace if it is the sole argument.</param>
        ///<param name="object1">An object containing additional properties to merge in.</param>
        public extern static Object extend(Object target, Object object1);

        ///<summary>
        /// Merge the contents of two or more objects together into the first object.
        ///</summary>
        ///<param name="target">An object that will receive the new properties if additional objects are passed in or that will extend the jQuery namespace if it is the sole argument.</param>
        ///<param name="object1">An object containing additional properties to merge in.</param>
        ///<param name="objectN">Additional objects containing properties to merge in.</param>
        public extern static Object extend(Object target, Object object1, Object objectN);

        ///<summary>
        /// Merge the contents of two or more objects together into the first object.
        ///</summary>
        ///<param name="deep">If true, the merge becomes recursive (aka. deep copy).</param>
        ///<param name="target">The object to extend. It will receive the new properties.</param>
        ///<param name="object1">An object containing additional properties to merge in.</param>
        public extern static Object extend(bool deep, Object target, Object object1);

        ///<summary>
        /// Merge the contents of two or more objects together into the first object.
        ///</summary>
        ///<param name="deep">If true, the merge becomes recursive (aka. deep copy).</param>
        ///<param name="target">The object to extend. It will receive the new properties.</param>
        ///<param name="object1">An object containing additional properties to merge in.</param>
        ///<param name="objectN">Additional objects containing properties to merge in.</param>
        public extern static Object extend(bool deep, Object target, Object object1, Object objectN);

        ///<summary>
        /// A generic iterator function, which can be used to seamlessly iterate over both objects and arrays. Arrays and array-like objects with a length property (such as a function's arguments object) are iterated by numeric index, from 0 to length-1. Other objects are iterated via their named properties.
        ///</summary>
        ///<param name="collection">The object or array to iterate over.</param>
        ///<param name="callback">The function that will be executed on every object.</param>
        public extern static Object each(Object collection, Action<int, object> callback);

        ///<summary>
        /// Get the current vertical position of the scroll bar for the first element in the set of matched elements.
        ///</summary>
        public extern int scrollTop();

        ///<summary>
        /// Set the current vertical position of the scroll bar for each of the set of matched elements.
        ///</summary>
        ///<param name="value">An integer indicating the new position to set the scroll bar to.</param>
        public extern jQuery scrollTop(Number value);

        ///<summary>
        /// Get the current coordinates of the first element in the set of matched elements, relative to the offset parent.
        ///</summary>
        public extern Object position();

        ///<summary>
        /// Get the current coordinates of the first element in the set of matched elements, relative to the document.
        ///</summary>
        public extern Object offset();

        ///<summary>
        /// Set the current coordinates of every element in the set of matched elements, relative to the document.
        ///</summary>
        ///<param name="coordinates">An object containing the properties top and left, which are integers indicating the new top and left coordinates for the elements.</param>
        public extern jQuery offset(Object coordinates);

        ///<summary>
        /// Set the current coordinates of every element in the set of matched elements, relative to the document.
        ///</summary>
        ///<param name="callback">A function to return the coordinates to set. Receives the index of the element in the collection as the first argument and the current coordinates as the second argument. The function should return an object with the new top and left properties.</param>
        public extern jQuery offset(Action<int, object> callback);

        ///<summary>
        /// Get the value of a style property for the first element in the set of matched elements.
        ///</summary>
        ///<param name="propertyName">A CSS property.</param>
        public extern String css(string propertyName);

        ///<summary>
        /// Set one or more CSS properties for the  set of matched elements.
        ///</summary>
        ///<param name="propertyName">A CSS property name.</param>
        ///<param name="value">A value to set for the property.</param>
        public extern jQuery css(string propertyName, string value);

        ///<summary>
        /// Set one or more CSS properties for the  set of matched elements.
        ///</summary>
        ///<param name="propertyName">A CSS property name.</param>
        ///<param name="value">A value to set for the property.</param>
        public extern jQuery css(string propertyName, Number value);

        ///<summary>
        /// Set one or more CSS properties for the  set of matched elements.
        ///</summary>
        ///<param name="propertyName">A CSS property name.</param>
        ///<param name="callback">A function returning the value to set. this is the current element. Receives the index position of the element in the set and the old value as arguments.</param>
        public extern jQuery css(string propertyName, Action<int, object> callback);

        ///<summary>
        /// Set one or more CSS properties for the  set of matched elements.
        ///</summary>
        ///<param name="map">A map of property-value pairs to set.</param>
        public extern jQuery css(object map);

        ///<summary>
        /// Remove the parents of the set of matched elements from the DOM, leaving the matched elements in their place.
        ///</summary>
        public extern jQuery unwrap();

        ///<summary>
        /// Remove the set of matched elements from the DOM.
        ///</summary>
        public extern jQuery detach();

        ///<summary>
        /// Remove the set of matched elements from the DOM.
        ///</summary>
        ///<param name="selector">A selector expression that filters the set of matched elements to be removed.</param>
        public extern jQuery detach(string selector);

        ///<summary>
        /// Create a deep copy of the set of matched elements.
        ///</summary>
        public extern jQuery clone();

        ///<summary>
        /// Create a deep copy of the set of matched elements.
        ///</summary>
        ///<param name="withDataAndEvents">A Boolean indicating whether event handlers should be copied along with the elements. As of jQuery 1.4, element data will be copied as well.</param>
        public extern jQuery clone(bool withDataAndEvents);

        ///<summary>
        /// Create a deep copy of the set of matched elements.
        ///</summary>
        ///<param name="withDataAndEvents">A Boolean indicating whether event handlers and data should be copied along with the elements. The default value is false. *In jQuery 1.5.0 the default value was incorrectly true; it was changed back to false in 1.5.1 and up.</param>
        ///<param name="deepWithDataAndEvents">A Boolean indicating whether event handlers and data for all children of the cloned element should be copied. By default its value matches the first argument's value (which defaults to false).</param>
        public extern jQuery clone(bool withDataAndEvents, bool deepWithDataAndEvents);

        ///<summary>
        /// Remove the set of matched elements from the DOM.
        ///</summary>
        public extern jQuery remove();

        ///<summary>
        /// Remove the set of matched elements from the DOM.
        ///</summary>
        ///<param name="selector">A selector expression that filters the set of matched elements to be removed.</param>
        public extern jQuery remove(string selector);

        ///<summary>
        /// Remove all child nodes of the set of matched elements from the DOM.
        ///</summary>
        public extern jQuery empty();

        ///<summary>
        /// Replace each target element with the set of matched elements.
        ///</summary>
        ///<param name="target">A selector expression indicating which element(s) to replace.</param>
        public extern jQuery replaceAll(string target);

        ///<summary>
        /// Replace each element in the set of matched elements with the provided new content.
        ///</summary>
        ///<param name="newContent">The content to insert. May be an HTML string, DOM element, or jQuery object.</param>
        public extern jQuery replaceWith(string newContent);

        ///<summary>
        /// Replace each element in the set of matched elements with the provided new content.
        ///</summary>
        ///<param name="newContent">The content to insert. May be an HTML string, DOM element, or jQuery object.</param>
        public extern jQuery replaceWith(Element newContent);

        ///<summary>
        /// Replace each element in the set of matched elements with the provided new content.
        ///</summary>
        ///<param name="newContent">The content to insert. May be an HTML string, DOM element, or jQuery object.</param>
        public extern jQuery replaceWith(jQuery newContent);

        ///<summary>
        /// Replace each element in the set of matched elements with the provided new content.
        ///</summary>
        ///<param name="callback">A function that returns content with which to replace the set of matched elements.</param>
        public extern jQuery replaceWith(Action callback);

        ///<summary>
        /// Wrap an HTML structure around the content of each element in the set of matched elements.
        ///</summary>
        ///<param name="wrappingElement">An HTML snippet, selector expression, jQuery object, or DOM element specifying the structure to wrap around the content of the matched elements.</param>
        public extern jQuery wrapInner(string wrappingElement);

        ///<summary>
        /// Wrap an HTML structure around the content of each element in the set of matched elements.
        ///</summary>
        ///<param name="callback">A callback function which generates a structure to wrap around the content of the matched elements. Receives the index position of the element in the set as an argument. Within the function, this refers to the current element in the set.</param>
        public extern jQuery wrapInner(Action<int> callback);

        ///<summary>
        /// Wrap an HTML structure around all elements in the set of matched elements.
        ///</summary>
        ///<param name="wrappingElement">An HTML snippet, selector expression, jQuery object, or DOM element specifying the structure to wrap around the matched elements.</param>
        public extern jQuery wrapAll(string wrappingElement);

        ///<summary>
        /// Wrap an HTML structure around all elements in the set of matched elements.
        ///</summary>
        ///<param name="wrappingElement">An HTML snippet, selector expression, jQuery object, or DOM element specifying the structure to wrap around the matched elements.</param>
        public extern jQuery wrapAll(Element wrappingElement);

        ///<summary>
        /// Wrap an HTML structure around all elements in the set of matched elements.
        ///</summary>
        ///<param name="wrappingElement">An HTML snippet, selector expression, jQuery object, or DOM element specifying the structure to wrap around the matched elements.</param>
        public extern jQuery wrapAll(jQuery wrappingElement);

        ///<summary>
        /// Wrap an HTML structure around each element in the set of matched elements.
        ///</summary>
        ///<param name="wrappingElement">An HTML snippet, selector expression, jQuery object, or DOM element specifying the structure to wrap around the matched elements.</param>
        public extern jQuery wrap(string wrappingElement);

        ///<summary>
        /// Wrap an HTML structure around each element in the set of matched elements.
        ///</summary>
        ///<param name="wrappingElement">An HTML snippet, selector expression, jQuery object, or DOM element specifying the structure to wrap around the matched elements.</param>
        public extern jQuery wrap(Element wrappingElement);

        ///<summary>
        /// Wrap an HTML structure around each element in the set of matched elements.
        ///</summary>
        ///<param name="wrappingElement">An HTML snippet, selector expression, jQuery object, or DOM element specifying the structure to wrap around the matched elements.</param>
        public extern jQuery wrap(jQuery wrappingElement);

        ///<summary>
        /// Wrap an HTML structure around each element in the set of matched elements.
        ///</summary>
        ///<param name="callback">A callback function returning the HTML content or jQuery object to wrap around the matched elements. Receives the index position of the element in the set as an argument. Within the function, this refers to the current element in the set.</param>
        public extern jQuery wrap(Action<int> callback);

        ///<summary>
        /// Insert every element in the set of matched elements before the target.
        ///</summary>
        ///<param name="target">A selector, element, HTML string, or jQuery object; the matched set of elements will be inserted before the element(s) specified by this parameter.</param>
        public extern jQuery insertBefore(string target);

        ///<summary>
        /// Insert every element in the set of matched elements before the target.
        ///</summary>
        ///<param name="target">A selector, element, HTML string, or jQuery object; the matched set of elements will be inserted before the element(s) specified by this parameter.</param>
        public extern jQuery insertBefore(Element target);

        ///<summary>
        /// Insert every element in the set of matched elements before the target.
        ///</summary>
        ///<param name="target">A selector, element, HTML string, or jQuery object; the matched set of elements will be inserted before the element(s) specified by this parameter.</param>
        public extern jQuery insertBefore(jQuery target);

        ///<summary>
        /// Insert content, specified by the parameter, before each element in the set of matched elements.
        ///</summary>
        ///<param name="content">HTML string, DOM element, or jQuery object to insert before each element in the set of matched elements.</param>
        public extern jQuery before(string content);

        ///<summary>
        /// Insert content, specified by the parameter, before each element in the set of matched elements.
        ///</summary>
        ///<param name="content">HTML string, DOM element, or jQuery object to insert before each element in the set of matched elements.</param>
        ///<param name="content1">One or more additional DOM elements, arrays of elements, HTML strings, or jQuery objects to insert before each element in the set of matched elements.</param>
        public extern jQuery before(string content, string content1);

        ///<summary>
        /// Insert content, specified by the parameter, before each element in the set of matched elements.
        ///</summary>
        ///<param name="content">HTML string, DOM element, or jQuery object to insert before each element in the set of matched elements.</param>
        ///<param name="content1">One or more additional DOM elements, arrays of elements, HTML strings, or jQuery objects to insert before each element in the set of matched elements.</param>
        public extern jQuery before(string content, Element content1);

        ///<summary>
        /// Insert content, specified by the parameter, before each element in the set of matched elements.
        ///</summary>
        ///<param name="content">HTML string, DOM element, or jQuery object to insert before each element in the set of matched elements.</param>
        ///<param name="content1">One or more additional DOM elements, arrays of elements, HTML strings, or jQuery objects to insert before each element in the set of matched elements.</param>
        public extern jQuery before(string content, Array content1);

        ///<summary>
        /// Insert content, specified by the parameter, before each element in the set of matched elements.
        ///</summary>
        ///<param name="content">HTML string, DOM element, or jQuery object to insert before each element in the set of matched elements.</param>
        ///<param name="content1">One or more additional DOM elements, arrays of elements, HTML strings, or jQuery objects to insert before each element in the set of matched elements.</param>
        public extern jQuery before(string content, jQuery content1);

        ///<summary>
        /// Insert content, specified by the parameter, before each element in the set of matched elements.
        ///</summary>
        ///<param name="content">HTML string, DOM element, or jQuery object to insert before each element in the set of matched elements.</param>
        public extern jQuery before(Element content);

        ///<summary>
        /// Insert content, specified by the parameter, before each element in the set of matched elements.
        ///</summary>
        ///<param name="content">HTML string, DOM element, or jQuery object to insert before each element in the set of matched elements.</param>
        ///<param name="content1">One or more additional DOM elements, arrays of elements, HTML strings, or jQuery objects to insert before each element in the set of matched elements.</param>
        public extern jQuery before(Element content, string content1);

        ///<summary>
        /// Insert content, specified by the parameter, before each element in the set of matched elements.
        ///</summary>
        ///<param name="content">HTML string, DOM element, or jQuery object to insert before each element in the set of matched elements.</param>
        ///<param name="content1">One or more additional DOM elements, arrays of elements, HTML strings, or jQuery objects to insert before each element in the set of matched elements.</param>
        public extern jQuery before(Element content, Element content1);

        ///<summary>
        /// Insert content, specified by the parameter, before each element in the set of matched elements.
        ///</summary>
        ///<param name="content">HTML string, DOM element, or jQuery object to insert before each element in the set of matched elements.</param>
        ///<param name="content1">One or more additional DOM elements, arrays of elements, HTML strings, or jQuery objects to insert before each element in the set of matched elements.</param>
        public extern jQuery before(Element content, Array content1);

        ///<summary>
        /// Insert content, specified by the parameter, before each element in the set of matched elements.
        ///</summary>
        ///<param name="content">HTML string, DOM element, or jQuery object to insert before each element in the set of matched elements.</param>
        ///<param name="content1">One or more additional DOM elements, arrays of elements, HTML strings, or jQuery objects to insert before each element in the set of matched elements.</param>
        public extern jQuery before(Element content, jQuery content1);

        ///<summary>
        /// Insert content, specified by the parameter, before each element in the set of matched elements.
        ///</summary>
        ///<param name="content">HTML string, DOM element, or jQuery object to insert before each element in the set of matched elements.</param>
        public extern jQuery before(jQuery content);

        ///<summary>
        /// Insert content, specified by the parameter, before each element in the set of matched elements.
        ///</summary>
        ///<param name="content">HTML string, DOM element, or jQuery object to insert before each element in the set of matched elements.</param>
        ///<param name="content1">One or more additional DOM elements, arrays of elements, HTML strings, or jQuery objects to insert before each element in the set of matched elements.</param>
        public extern jQuery before(jQuery content, string content1);

        ///<summary>
        /// Insert content, specified by the parameter, before each element in the set of matched elements.
        ///</summary>
        ///<param name="content">HTML string, DOM element, or jQuery object to insert before each element in the set of matched elements.</param>
        ///<param name="content1">One or more additional DOM elements, arrays of elements, HTML strings, or jQuery objects to insert before each element in the set of matched elements.</param>
        public extern jQuery before(jQuery content, Element content1);

        ///<summary>
        /// Insert content, specified by the parameter, before each element in the set of matched elements.
        ///</summary>
        ///<param name="content">HTML string, DOM element, or jQuery object to insert before each element in the set of matched elements.</param>
        ///<param name="content1">One or more additional DOM elements, arrays of elements, HTML strings, or jQuery objects to insert before each element in the set of matched elements.</param>
        public extern jQuery before(jQuery content, Array content1);

        ///<summary>
        /// Insert content, specified by the parameter, before each element in the set of matched elements.
        ///</summary>
        ///<param name="content">HTML string, DOM element, or jQuery object to insert before each element in the set of matched elements.</param>
        ///<param name="content1">One or more additional DOM elements, arrays of elements, HTML strings, or jQuery objects to insert before each element in the set of matched elements.</param>
        public extern jQuery before(jQuery content, jQuery content1);

        ///<summary>
        /// Insert content, specified by the parameter, before each element in the set of matched elements.
        ///</summary>
        ///<param name="callback">A function that returns an HTML string, DOM element(s), or jQuery object to insert before each element in the set of matched elements. Receives the index position of the element in the set as an argument. Within the function, this refers to the current element in the set.</param>
        public extern jQuery before(Action callback);

        ///<summary>
        /// Insert every element in the set of matched elements after the target.
        ///</summary>
        ///<param name="target">A selector, element, HTML string, or jQuery object; the matched set of elements will be inserted after the element(s) specified by this parameter.</param>
        public extern jQuery insertAfter(string target);

        ///<summary>
        /// Insert every element in the set of matched elements after the target.
        ///</summary>
        ///<param name="target">A selector, element, HTML string, or jQuery object; the matched set of elements will be inserted after the element(s) specified by this parameter.</param>
        public extern jQuery insertAfter(Element target);

        ///<summary>
        /// Insert every element in the set of matched elements after the target.
        ///</summary>
        ///<param name="target">A selector, element, HTML string, or jQuery object; the matched set of elements will be inserted after the element(s) specified by this parameter.</param>
        public extern jQuery insertAfter(jQuery target);

        ///<summary>
        /// Insert content, specified by the parameter, after each element in the set of matched elements.
        ///</summary>
        ///<param name="content">HTML string, DOM element, or jQuery object to insert after each element in the set of matched elements.</param>
        public extern jQuery after(string content);

        ///<summary>
        /// Insert content, specified by the parameter, after each element in the set of matched elements.
        ///</summary>
        ///<param name="content">HTML string, DOM element, or jQuery object to insert after each element in the set of matched elements.</param>
        ///<param name="content1">One or more additional DOM elements, arrays of elements, HTML strings, or jQuery objects to insert after each element in the set of matched elements.</param>
        public extern jQuery after(string content, string content1);

        ///<summary>
        /// Insert content, specified by the parameter, after each element in the set of matched elements.
        ///</summary>
        ///<param name="content">HTML string, DOM element, or jQuery object to insert after each element in the set of matched elements.</param>
        ///<param name="content1">One or more additional DOM elements, arrays of elements, HTML strings, or jQuery objects to insert after each element in the set of matched elements.</param>
        public extern jQuery after(string content, Element content1);

        ///<summary>
        /// Insert content, specified by the parameter, after each element in the set of matched elements.
        ///</summary>
        ///<param name="content">HTML string, DOM element, or jQuery object to insert after each element in the set of matched elements.</param>
        ///<param name="content1">One or more additional DOM elements, arrays of elements, HTML strings, or jQuery objects to insert after each element in the set of matched elements.</param>
        public extern jQuery after(string content, Array content1);

        ///<summary>
        /// Insert content, specified by the parameter, after each element in the set of matched elements.
        ///</summary>
        ///<param name="content">HTML string, DOM element, or jQuery object to insert after each element in the set of matched elements.</param>
        ///<param name="content1">One or more additional DOM elements, arrays of elements, HTML strings, or jQuery objects to insert after each element in the set of matched elements.</param>
        public extern jQuery after(string content, jQuery content1);

        ///<summary>
        /// Insert content, specified by the parameter, after each element in the set of matched elements.
        ///</summary>
        ///<param name="content">HTML string, DOM element, or jQuery object to insert after each element in the set of matched elements.</param>
        public extern jQuery after(Element content);

        ///<summary>
        /// Insert content, specified by the parameter, after each element in the set of matched elements.
        ///</summary>
        ///<param name="content">HTML string, DOM element, or jQuery object to insert after each element in the set of matched elements.</param>
        ///<param name="content1">One or more additional DOM elements, arrays of elements, HTML strings, or jQuery objects to insert after each element in the set of matched elements.</param>
        public extern jQuery after(Element content, string content1);

        ///<summary>
        /// Insert content, specified by the parameter, after each element in the set of matched elements.
        ///</summary>
        ///<param name="content">HTML string, DOM element, or jQuery object to insert after each element in the set of matched elements.</param>
        ///<param name="content1">One or more additional DOM elements, arrays of elements, HTML strings, or jQuery objects to insert after each element in the set of matched elements.</param>
        public extern jQuery after(Element content, Element content1);

        ///<summary>
        /// Insert content, specified by the parameter, after each element in the set of matched elements.
        ///</summary>
        ///<param name="content">HTML string, DOM element, or jQuery object to insert after each element in the set of matched elements.</param>
        ///<param name="content1">One or more additional DOM elements, arrays of elements, HTML strings, or jQuery objects to insert after each element in the set of matched elements.</param>
        public extern jQuery after(Element content, Array content1);

        ///<summary>
        /// Insert content, specified by the parameter, after each element in the set of matched elements.
        ///</summary>
        ///<param name="content">HTML string, DOM element, or jQuery object to insert after each element in the set of matched elements.</param>
        ///<param name="content1">One or more additional DOM elements, arrays of elements, HTML strings, or jQuery objects to insert after each element in the set of matched elements.</param>
        public extern jQuery after(Element content, jQuery content1);

        ///<summary>
        /// Insert content, specified by the parameter, after each element in the set of matched elements.
        ///</summary>
        ///<param name="content">HTML string, DOM element, or jQuery object to insert after each element in the set of matched elements.</param>
        public extern jQuery after(jQuery content);

        ///<summary>
        /// Insert content, specified by the parameter, after each element in the set of matched elements.
        ///</summary>
        ///<param name="content">HTML string, DOM element, or jQuery object to insert after each element in the set of matched elements.</param>
        ///<param name="content1">One or more additional DOM elements, arrays of elements, HTML strings, or jQuery objects to insert after each element in the set of matched elements.</param>
        public extern jQuery after(jQuery content, string content1);

        ///<summary>
        /// Insert content, specified by the parameter, after each element in the set of matched elements.
        ///</summary>
        ///<param name="content">HTML string, DOM element, or jQuery object to insert after each element in the set of matched elements.</param>
        ///<param name="content1">One or more additional DOM elements, arrays of elements, HTML strings, or jQuery objects to insert after each element in the set of matched elements.</param>
        public extern jQuery after(jQuery content, Element content1);

        ///<summary>
        /// Insert content, specified by the parameter, after each element in the set of matched elements.
        ///</summary>
        ///<param name="content">HTML string, DOM element, or jQuery object to insert after each element in the set of matched elements.</param>
        ///<param name="content1">One or more additional DOM elements, arrays of elements, HTML strings, or jQuery objects to insert after each element in the set of matched elements.</param>
        public extern jQuery after(jQuery content, Array content1);

        ///<summary>
        /// Insert content, specified by the parameter, after each element in the set of matched elements.
        ///</summary>
        ///<param name="content">HTML string, DOM element, or jQuery object to insert after each element in the set of matched elements.</param>
        ///<param name="content1">One or more additional DOM elements, arrays of elements, HTML strings, or jQuery objects to insert after each element in the set of matched elements.</param>
        public extern jQuery after(jQuery content, jQuery content1);

        ///<summary>
        /// Insert content, specified by the parameter, after each element in the set of matched elements.
        ///</summary>
        ///<param name="callback">A function that returns an HTML string, DOM element(s), or jQuery object to insert after each element in the set of matched elements. Receives the index position of the element in the set as an argument. Within the function, this refers to the current element in the set.</param>
        public extern jQuery after(Action<int> callback);

        ///<summary>
        /// Insert every element in the set of matched elements to the beginning of the target.
        ///</summary>
        ///<param name="target">A selector, element, HTML string, or jQuery object; the matched set of elements will be inserted at the beginning of the element(s) specified by this parameter.</param>
        public extern jQuery prependTo(string target);

        ///<summary>
        /// Insert every element in the set of matched elements to the beginning of the target.
        ///</summary>
        ///<param name="target">A selector, element, HTML string, or jQuery object; the matched set of elements will be inserted at the beginning of the element(s) specified by this parameter.</param>
        public extern jQuery prependTo(Element target);

        ///<summary>
        /// Insert every element in the set of matched elements to the beginning of the target.
        ///</summary>
        ///<param name="target">A selector, element, HTML string, or jQuery object; the matched set of elements will be inserted at the beginning of the element(s) specified by this parameter.</param>
        public extern jQuery prependTo(jQuery target);

        ///<summary>
        /// Insert content, specified by the parameter, to the beginning of each element in the set of matched elements.
        ///</summary>
        ///<param name="content">DOM element, array of elements, HTML string, or jQuery object to insert at the beginning of each element in the set of matched elements.</param>
        public extern jQuery prepend(string content);

        ///<summary>
        /// Insert content, specified by the parameter, to the beginning of each element in the set of matched elements.
        ///</summary>
        ///<param name="content">DOM element, array of elements, HTML string, or jQuery object to insert at the beginning of each element in the set of matched elements.</param>
        ///<param name="content1">One or more additional DOM elements, arrays of elements, HTML strings, or jQuery objects to insert at the beginning of each element in the set of matched elements.</param>
        public extern jQuery prepend(string content, string content1);

        ///<summary>
        /// Insert content, specified by the parameter, to the beginning of each element in the set of matched elements.
        ///</summary>
        ///<param name="content">DOM element, array of elements, HTML string, or jQuery object to insert at the beginning of each element in the set of matched elements.</param>
        ///<param name="content1">One or more additional DOM elements, arrays of elements, HTML strings, or jQuery objects to insert at the beginning of each element in the set of matched elements.</param>
        public extern jQuery prepend(string content, Element content1);

        ///<summary>
        /// Insert content, specified by the parameter, to the beginning of each element in the set of matched elements.
        ///</summary>
        ///<param name="content">DOM element, array of elements, HTML string, or jQuery object to insert at the beginning of each element in the set of matched elements.</param>
        ///<param name="content1">One or more additional DOM elements, arrays of elements, HTML strings, or jQuery objects to insert at the beginning of each element in the set of matched elements.</param>
        public extern jQuery prepend(string content, jQuery content1);

        ///<summary>
        /// Insert content, specified by the parameter, to the beginning of each element in the set of matched elements.
        ///</summary>
        ///<param name="content">DOM element, array of elements, HTML string, or jQuery object to insert at the beginning of each element in the set of matched elements.</param>
        public extern jQuery prepend(Element content);

        ///<summary>
        /// Insert content, specified by the parameter, to the beginning of each element in the set of matched elements.
        ///</summary>
        ///<param name="content">DOM element, array of elements, HTML string, or jQuery object to insert at the beginning of each element in the set of matched elements.</param>
        ///<param name="content1">One or more additional DOM elements, arrays of elements, HTML strings, or jQuery objects to insert at the beginning of each element in the set of matched elements.</param>
        public extern jQuery prepend(Element content, string content1);

        ///<summary>
        /// Insert content, specified by the parameter, to the beginning of each element in the set of matched elements.
        ///</summary>
        ///<param name="content">DOM element, array of elements, HTML string, or jQuery object to insert at the beginning of each element in the set of matched elements.</param>
        ///<param name="content1">One or more additional DOM elements, arrays of elements, HTML strings, or jQuery objects to insert at the beginning of each element in the set of matched elements.</param>
        public extern jQuery prepend(Element content, Element content1);

        ///<summary>
        /// Insert content, specified by the parameter, to the beginning of each element in the set of matched elements.
        ///</summary>
        ///<param name="content">DOM element, array of elements, HTML string, or jQuery object to insert at the beginning of each element in the set of matched elements.</param>
        ///<param name="content1">One or more additional DOM elements, arrays of elements, HTML strings, or jQuery objects to insert at the beginning of each element in the set of matched elements.</param>
        public extern jQuery prepend(Element content, jQuery content1);

        ///<summary>
        /// Insert content, specified by the parameter, to the beginning of each element in the set of matched elements.
        ///</summary>
        ///<param name="content">DOM element, array of elements, HTML string, or jQuery object to insert at the beginning of each element in the set of matched elements.</param>
        public extern jQuery prepend(jQuery content);

        ///<summary>
        /// Insert content, specified by the parameter, to the beginning of each element in the set of matched elements.
        ///</summary>
        ///<param name="content">DOM element, array of elements, HTML string, or jQuery object to insert at the beginning of each element in the set of matched elements.</param>
        ///<param name="content1">One or more additional DOM elements, arrays of elements, HTML strings, or jQuery objects to insert at the beginning of each element in the set of matched elements.</param>
        public extern jQuery prepend(jQuery content, string content1);

        ///<summary>
        /// Insert content, specified by the parameter, to the beginning of each element in the set of matched elements.
        ///</summary>
        ///<param name="content">DOM element, array of elements, HTML string, or jQuery object to insert at the beginning of each element in the set of matched elements.</param>
        ///<param name="content1">One or more additional DOM elements, arrays of elements, HTML strings, or jQuery objects to insert at the beginning of each element in the set of matched elements.</param>
        public extern jQuery prepend(jQuery content, Element content1);

        ///<summary>
        /// Insert content, specified by the parameter, to the beginning of each element in the set of matched elements.
        ///</summary>
        ///<param name="content">DOM element, array of elements, HTML string, or jQuery object to insert at the beginning of each element in the set of matched elements.</param>
        ///<param name="content1">One or more additional DOM elements, arrays of elements, HTML strings, or jQuery objects to insert at the beginning of each element in the set of matched elements.</param>
        public extern jQuery prepend(jQuery content, jQuery content1);

        ///<summary>
        /// Insert content, specified by the parameter, to the beginning of each element in the set of matched elements.
        ///</summary>
        ///<param name="callback">A function that returns an HTML string, DOM element(s), or jQuery object to insert at the beginning of each element in the set of matched elements. Receives the index position of the element in the set and the old HTML value of the element as arguments. Within the function, this refers to the current element in the set.</param>
        public extern jQuery prepend(Action<int, string> callback);

        ///<summary>
        /// Insert every element in the set of matched elements to the end of the target.
        ///</summary>
        ///<param name="target">A selector, element, HTML string, or jQuery object; the matched set of elements will be inserted at the end of the element(s) specified by this parameter.</param>
        public extern jQuery appendTo(string target);

        ///<summary>
        /// Insert every element in the set of matched elements to the end of the target.
        ///</summary>
        ///<param name="target">A selector, element, HTML string, or jQuery object; the matched set of elements will be inserted at the end of the element(s) specified by this parameter.</param>
        public extern jQuery appendTo(Element target);

        ///<summary>
        /// Insert every element in the set of matched elements to the end of the target.
        ///</summary>
        ///<param name="target">A selector, element, HTML string, or jQuery object; the matched set of elements will be inserted at the end of the element(s) specified by this parameter.</param>
        public extern jQuery appendTo(jQuery target);

        ///<summary>
        /// Insert content, specified by the parameter, to the end of each element in the set of matched elements.
        ///</summary>
        ///<param name="content">DOM element, HTML string, or jQuery object to insert at the end of each element in the set of matched elements.</param>
        public extern jQuery append(string content);

        ///<summary>
        /// Insert content, specified by the parameter, to the end of each element in the set of matched elements.
        ///</summary>
        ///<param name="content">DOM element, HTML string, or jQuery object to insert at the end of each element in the set of matched elements.</param>
        ///<param name="content1">One or more additional DOM elements, arrays of elements, HTML strings, or jQuery objects to insert at the end of each element in the set of matched elements.</param>
        public extern jQuery append(string content, string content1);

        ///<summary>
        /// Insert content, specified by the parameter, to the end of each element in the set of matched elements.
        ///</summary>
        ///<param name="content">DOM element, HTML string, or jQuery object to insert at the end of each element in the set of matched elements.</param>
        ///<param name="content1">One or more additional DOM elements, arrays of elements, HTML strings, or jQuery objects to insert at the end of each element in the set of matched elements.</param>
        public extern jQuery append(string content, Element content1);

        ///<summary>
        /// Insert content, specified by the parameter, to the end of each element in the set of matched elements.
        ///</summary>
        ///<param name="content">DOM element, HTML string, or jQuery object to insert at the end of each element in the set of matched elements.</param>
        ///<param name="content1">One or more additional DOM elements, arrays of elements, HTML strings, or jQuery objects to insert at the end of each element in the set of matched elements.</param>
        public extern jQuery append(string content, Array content1);

        ///<summary>
        /// Insert content, specified by the parameter, to the end of each element in the set of matched elements.
        ///</summary>
        ///<param name="content">DOM element, HTML string, or jQuery object to insert at the end of each element in the set of matched elements.</param>
        ///<param name="content1">One or more additional DOM elements, arrays of elements, HTML strings, or jQuery objects to insert at the end of each element in the set of matched elements.</param>
        public extern jQuery append(string content, jQuery content1);

        ///<summary>
        /// Insert content, specified by the parameter, to the end of each element in the set of matched elements.
        ///</summary>
        ///<param name="content">DOM element, HTML string, or jQuery object to insert at the end of each element in the set of matched elements.</param>
        public extern jQuery append(Element content);

        ///<summary>
        /// Insert content, specified by the parameter, to the end of each element in the set of matched elements.
        ///</summary>
        ///<param name="content">DOM element, HTML string, or jQuery object to insert at the end of each element in the set of matched elements.</param>
        ///<param name="content1">One or more additional DOM elements, arrays of elements, HTML strings, or jQuery objects to insert at the end of each element in the set of matched elements.</param>
        public extern jQuery append(Element content, string content1);

        ///<summary>
        /// Insert content, specified by the parameter, to the end of each element in the set of matched elements.
        ///</summary>
        ///<param name="content">DOM element, HTML string, or jQuery object to insert at the end of each element in the set of matched elements.</param>
        ///<param name="content1">One or more additional DOM elements, arrays of elements, HTML strings, or jQuery objects to insert at the end of each element in the set of matched elements.</param>
        public extern jQuery append(Element content, Element content1);

        ///<summary>
        /// Insert content, specified by the parameter, to the end of each element in the set of matched elements.
        ///</summary>
        ///<param name="content">DOM element, HTML string, or jQuery object to insert at the end of each element in the set of matched elements.</param>
        ///<param name="content1">One or more additional DOM elements, arrays of elements, HTML strings, or jQuery objects to insert at the end of each element in the set of matched elements.</param>
        public extern jQuery append(Element content, Array content1);

        ///<summary>
        /// Insert content, specified by the parameter, to the end of each element in the set of matched elements.
        ///</summary>
        ///<param name="content">DOM element, HTML string, or jQuery object to insert at the end of each element in the set of matched elements.</param>
        ///<param name="content1">One or more additional DOM elements, arrays of elements, HTML strings, or jQuery objects to insert at the end of each element in the set of matched elements.</param>
        public extern jQuery append(Element content, jQuery content1);

        ///<summary>
        /// Insert content, specified by the parameter, to the end of each element in the set of matched elements.
        ///</summary>
        ///<param name="content">DOM element, HTML string, or jQuery object to insert at the end of each element in the set of matched elements.</param>
        public extern jQuery append(jQuery content);

        ///<summary>
        /// Insert content, specified by the parameter, to the end of each element in the set of matched elements.
        ///</summary>
        ///<param name="content">DOM element, HTML string, or jQuery object to insert at the end of each element in the set of matched elements.</param>
        ///<param name="content1">One or more additional DOM elements, arrays of elements, HTML strings, or jQuery objects to insert at the end of each element in the set of matched elements.</param>
        public extern jQuery append(jQuery content, string content1);

        ///<summary>
        /// Insert content, specified by the parameter, to the end of each element in the set of matched elements.
        ///</summary>
        ///<param name="content">DOM element, HTML string, or jQuery object to insert at the end of each element in the set of matched elements.</param>
        ///<param name="content1">One or more additional DOM elements, arrays of elements, HTML strings, or jQuery objects to insert at the end of each element in the set of matched elements.</param>
        public extern jQuery append(jQuery content, Element content1);

        ///<summary>
        /// Insert content, specified by the parameter, to the end of each element in the set of matched elements.
        ///</summary>
        ///<param name="content">DOM element, HTML string, or jQuery object to insert at the end of each element in the set of matched elements.</param>
        ///<param name="content1">One or more additional DOM elements, arrays of elements, HTML strings, or jQuery objects to insert at the end of each element in the set of matched elements.</param>
        public extern jQuery append(jQuery content, Array content1);

        ///<summary>
        /// Insert content, specified by the parameter, to the end of each element in the set of matched elements.
        ///</summary>
        ///<param name="content">DOM element, HTML string, or jQuery object to insert at the end of each element in the set of matched elements.</param>
        ///<param name="content1">One or more additional DOM elements, arrays of elements, HTML strings, or jQuery objects to insert at the end of each element in the set of matched elements.</param>
        public extern jQuery append(jQuery content, jQuery content1);

        ///<summary>
        /// Insert content, specified by the parameter, to the end of each element in the set of matched elements.
        ///</summary>
        ///<param name="callback">A function that returns an HTML string, DOM element(s), or jQuery object to insert at the end of each element in the set of matched elements. Receives the index position of the element in the set and the old HTML value of the element as arguments. Within the function, this refers to the current element in the set.</param>
        public extern jQuery append(Action<int, string> callback);

        ///<summary>
        /// Get the current value of the first element in the set of matched elements.
        ///</summary>
        public extern object val();

        ///<summary>
        /// Set the value of each element in the set of matched elements.
        ///</summary>
        ///<param name="value">A string of text or an array of strings corresponding to the value of each matched element to set as selected/checked.</param>
        public extern jQuery val(string value);

        ///<summary>
        /// Set the value of each element in the set of matched elements.
        ///</summary>
        ///<param name="callback">A function returning the value to set. this is the current element. Receives the index position of the element in the set and the old value as arguments.</param>
        public extern jQuery val(Action<int, object> callback);

        ///<summary>
        /// Get the combined text contents of each element in the set of matched elements, including their descendants.
        ///</summary>
        public extern String text();

        ///<summary>
        /// Set the content of each element in the set of matched elements to the specified text.
        ///</summary>
        ///<param name="textString">A string of text to set as the content of each matched element.</param>
        public extern jQuery text(string textString);

        ///<summary>
        /// Set the content of each element in the set of matched elements to the specified text.
        ///</summary>
        ///<param name="callback">A function returning the text content to set. Receives the index position of the element in the set and the old text value as arguments.</param>
        public extern jQuery text(Action<int, string> callback);

        ///<summary>
        /// Get the HTML contents of the first element in the set of matched elements.
        ///</summary>
        public extern String html();

        ///<summary>
        /// Set the HTML contents of each element in the set of matched elements.
        ///</summary>
        ///<param name="htmlString">A string of HTML to set as the content of each matched element.</param>
        public extern jQuery html(string htmlString);

        ///<summary>
        /// Set the HTML contents of each element in the set of matched elements.
        ///</summary>
        ///<param name="callback">A function returning the HTML content to set. Receives the index position of the element in the set and the old HTML value as arguments. jQuery empties the element before calling the function; use the oldhtml argument to reference the previous content. Within the function, this refers to the current element in the set.</param>
        public extern jQuery html(Action<int, string> callback);

        ///<summary>
        /// Pass each element in the current matched set through a function, producing a new jQuery object containing the return values.
        ///</summary>
        ///<param name="callback">A function object that will be invoked for each element in the current set.</param>
        public extern jQuery map(Action<int, Element> callback);

        ///<summary>
        /// Check the current matched set of elements against a selector, element, or jQuery object and return true if at least one of these elements matches the given arguments.
        ///</summary>
        ///<param name="selector">A string containing a selector expression to match elements against.</param>
        public extern bool @is(string selector);

        ///<summary>
        /// Check the current matched set of elements against a selector, element, or jQuery object and return true if at least one of these elements matches the given arguments.
        ///</summary>
        ///<param name="callback">A function used as a test for the set of elements. It accepts one argument, index, which is the element's index in the jQuery collection.Within the function, this refers to the current DOM element.</param>
        public extern bool @is(Action<int> callback);

        ///<summary>
        /// Check the current matched set of elements against a selector, element, or jQuery object and return true if at least one of these elements matches the given arguments.
        ///</summary>
        ///<param name="object">An existing jQuery object to match the current set of elements against.</param>
        public extern bool @is(jQuery @object);

        ///<summary>
        /// Check the current matched set of elements against a selector, element, or jQuery object and return true if at least one of these elements matches the given arguments.
        ///</summary>
        ///<param name="element">An element to match the current set of elements against.</param>
        public extern bool @is(Element element);

        ///<summary>
        /// Reduce the set of matched elements to the one at the specified index.
        ///</summary>
        ///<param name="index">An integer indicating the 0-based position of the element.</param>
        public extern jQuery eq(int index);

        ///<summary>
        /// Reduce the set of matched elements to those that match the selector or pass the function's test. 
        ///</summary>
        ///<param name="selector">A string containing a selector expression to match the current set of elements against.</param>
        public extern jQuery filter(string selector);

        ///<summary>
        /// Reduce the set of matched elements to those that match the selector or pass the function's test. 
        ///</summary>
        ///<param name="callback">A function used as a test for each element in the set. this is the current DOM element.</param>
        public extern jQuery filter(Action<int> callback);

        ///<summary>
        /// Reduce the set of matched elements to those that match the selector or pass the function's test. 
        ///</summary>
        ///<param name="element">An element to match the current set of elements against.</param>
        public extern jQuery filter(Element element);

        ///<summary>
        /// Reduce the set of matched elements to those that match the selector or pass the function's test. 
        ///</summary>
        ///<param name="object">An existing jQuery object to match the current set of elements against.</param>
        public extern jQuery filter(jQuery @object);

        ///<summary>
        /// Add or remove one or more classes from each element in the set of matched elements, depending on either the class's presence or the value of the switch argument.
        ///</summary>
        ///<param name="className">One or more class names (separated by spaces) to be toggled for each element in the matched set.</param>
        public extern jQuery toggleClass(string className);

        ///<summary>
        /// Add or remove one or more classes from each element in the set of matched elements, depending on either the class's presence or the value of the switch argument.
        ///</summary>
        ///<param name="className">One or more class names (separated by spaces) to be toggled for each element in the matched set.</param>
        ///<param name="switch">A Boolean (not just truthy/falsy) value to determine whether the class should be added or removed.</param>
        public extern jQuery toggleClass(string className, bool @switch);

        ///<summary>
        /// Add or remove one or more classes from each element in the set of matched elements, depending on either the class's presence or the value of the switch argument.
        ///</summary>
        public extern jQuery toggleClass();

        ///<summary>
        /// Add or remove one or more classes from each element in the set of matched elements, depending on either the class's presence or the value of the switch argument.
        ///</summary>
        ///<param name="switch">A boolean value to determine whether the class should be added or removed.</param>
        public extern jQuery toggleClass(bool @switch);

        ///<summary>
        /// Add or remove one or more classes from each element in the set of matched elements, depending on either the class's presence or the value of the switch argument.
        ///</summary>
        ///<param name="callback">A function that returns class names to be toggled in the class attribute of each element in the matched set. Receives the index position of the element in the set, the old class value, and the switch as arguments.</param>
        public extern jQuery toggleClass(Action<int, object, object> callback);

        ///<summary>
        /// Add or remove one or more classes from each element in the set of matched elements, depending on either the class's presence or the value of the switch argument.
        ///</summary>
        ///<param name="callback">A function that returns class names to be toggled in the class attribute of each element in the matched set. Receives the index position of the element in the set, the old class value, and the switch as arguments.</param>
        ///<param name="switch">A boolean value to determine whether the class should be added or removed.</param>
        public extern jQuery toggleClass(Action<int, object, object> callback, bool @switch);

        ///<summary>
        /// Remove a single class, multiple classes, or all classes from each element in the set of matched elements.
        ///</summary>
        public extern jQuery removeClass();

        ///<summary>
        /// Remove a single class, multiple classes, or all classes from each element in the set of matched elements.
        ///</summary>
        ///<param name="className">One or more space-separated classes to be removed from the class attribute of each matched element.</param>
        public extern jQuery removeClass(string className);

        ///<summary>
        /// Remove a single class, multiple classes, or all classes from each element in the set of matched elements.
        ///</summary>
        ///<param name="callback">A function returning one or more space-separated class names to be removed. Receives the index position of the element in the set and the old class value as arguments.</param>
        public extern jQuery removeClass(Action<int, object> callback);

        ///<summary>
        /// Determine whether any of the matched elements are assigned the given class.
        ///</summary>
        ///<param name="className">The class name to search for.</param>
        public extern bool hasClass(string className);

        ///<summary>
        /// Remove an attribute from each element in the set of matched elements.
        ///</summary>
        ///<param name="attributeName">An attribute to remove; as of version 1.7, it can be a space-separated list of attributes.</param>
        public extern jQuery removeAttr(string attributeName);

        ///<summary>
        /// Get the value of an attribute for the first element in the set of matched elements.
        ///</summary>
        ///<param name="attributeName">The name of the attribute to get.</param>
        public extern String attr(string attributeName);

        ///<summary>
        /// Set one or more attributes for the set of matched elements.
        ///</summary>
        ///<param name="attributeName">The name of the attribute to set.</param>
        ///<param name="value">A value to set for the attribute.</param>
        public extern jQuery attr(string attributeName, string value);

        ///<summary>
        /// Set one or more attributes for the set of matched elements.
        ///</summary>
        ///<param name="attributeName">The name of the attribute to set.</param>
        ///<param name="value">A value to set for the attribute.</param>
        public extern jQuery attr(string attributeName, Number value);

        ///<summary>
        /// Set one or more attributes for the set of matched elements.
        ///</summary>
        ///<param name="map">A map of attribute-value pairs to set.</param>
        public extern jQuery attr(object map);

        ///<summary>
        /// Set one or more attributes for the set of matched elements.
        ///</summary>
        ///<param name="attributeName">The name of the attribute to set.</param>
        ///<param name="callback">A function returning the value to set. this is the current element. Receives the index position of the element in the set and the old attribute value as arguments.</param>
        public extern jQuery attr(string attributeName, Action<int, object> callback);

        ///<summary>
        /// Adds the specified class(es) to each of the set of matched elements.
        ///</summary>
        ///<param name="className">One or more class names to be added to the class attribute of each matched element.</param>
        public extern jQuery addClass(string className);

        ///<summary>
        /// Adds the specified class(es) to each of the set of matched elements.
        ///</summary>
        ///<param name="callback">A function returning one or more space-separated class names to be added to the existing class name(s). Receives the index position of the element in the set and the existing class name(s) as arguments. Within the function, this refers to the current element in the set.</param>
        public extern jQuery addClass(Action<int, object> callback);
    }
}
#pragma warning restore 0626
