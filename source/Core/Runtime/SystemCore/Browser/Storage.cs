//
// The information in this file is adapted from the W3C recommendation from 08 December 2011: http://www.w3.org/TR/webstorage/
//

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace System.Browser
{
    /// <summary>
    /// Each Storage object provides access to a list of key/value pairs, which are sometimes called items. Keys are strings. Any string (including the empty string) is a valid key. Values are similarly strings.
    ///
    /// Each Storage object is associated with a list of key/value pairs when it is created, as defined in the sections on the sessionStorage and localStorage attributes. Multiple separate objects implementing the Storage interface can all be associated with the same list of key/value pairs simultaneously.
    /// </summary>
    public interface Storage
    {
        /// <summary>
        /// The number of key/value pairs currently present in the list associated with the object.
        /// </summary>
        [ScriptField]
        ulong length { get; }
    
        /// <summary>
        /// Returns the name of the nth key in the list. The order of keys is user-agent defined, but must be consistent within an object so long as the number of keys doesn't change. (Thus, adding or removing a key may change the order of the keys, but merely changing the value of an existing key must not.) If n is greater than or equal to the number of key/value pairs in the object, then this method must return null.
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        string key(ulong index);
        
        /// <summary>
        /// Returns the current value associated with the given key. If the given key does not exist in the list associated with the object then this method must return null. 
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        string getItem(string key);
        
        /// <summary>
        /// Checks if a key/value pair with the given key already exists in the list associated with the object.
        /// 
        /// If it does not, then a new key/value pair must be added to the list, with the given key and with its value set to value.
        /// 
        /// If it does not, then a new key/value pair must be added to the list, with the given key and with its value set to value.
        /// </summary>
        /// <param name="key"></param>
        /// <param name="value"></param>
        void setItem(string key, string value);

        /// <summary>
        /// Causes the key/value pair with the given key to be removed from the list associated with the object, if it exists. If no item with that key exists, the method must do nothing.
        /// </summary>
        /// <param name="key"></param>
        void removeItem(string key);
        
        /// <summary>
        /// Atomically causes the list associated with the object to be emptied of all key/value pairs, if there are any. If there are none, then the method must do nothing.
        /// </summary>
        void clear();
    }
}
