//----------------------------------------------
// ECMA core object
//----------------------------------------------

namespace System
{
    /// <summary>
    /// Represents the ECMA Date object.
    /// </summary>
    public sealed class Date
    {
        #region Instance Members

        /// <summary>
        /// Get the day of the month.
        /// </summary>
        /// <returns>An integer from 1-31.</returns>
        public int getDate() { return 0; }

        /// <summary>
        /// Gets the day of the week.
        /// </summary>
        /// <returns>An integer from 0-6.</returns>
        public int getDay() { return 0; }

        /// <summary>
        /// Gets the full year.
        /// </summary>
        /// <returns>A four digit integer.</returns>
        public int getFullYear() { return 0; }

        /// <summary>
        /// Gets the hour.
        /// </summary>
        /// <returns>An integer from 0-23.</returns>
        public int getHours() { return 0; }

        /// <summary>
        /// Gets the milliseconds.
        /// </summary>
        /// <returns>An integer from 0-999.</returns>
        public int getMilliseconds() { return 0; }

        /// <summary>
        /// Gets the minutes.
        /// </summary>
        /// <returns>An integer from 0-59.</returns>
        public int getMinutes() { return 0; }

        /// <summary>
        /// Gets the month.
        /// </summary>
        /// <returns>An integer from 0-11.</returns>
        public int getMonth() { return 0; }

        /// <summary>
        /// Gets the seconds.
        /// </summary>
        /// <returns>An integer from 0-59.</returns>
        public int getSeconds() { return 0; }

        /// <summary>
        /// Get the number of milliseconds since Jan 1, 1970.
        /// </summary>
        /// <returns>An integer.</returns>
        public int getTime() { return 0; }

        /// <summary>
        /// Gets the time difference between GMT and local time, in minutes.
        /// </summary>
        /// <returns></returns>
        public int getTimezoneOffset() { return 0; }

        /// <summary>
        /// Gets the day of the month, in universal time.
        /// </summary>
        /// <returns>An integer from 1-31.</returns>
        public int getUTCDate() { return 0; }

        /// <summary>
        /// Gets the day of the week, in universal time.
        /// </summary>
        /// <returns>An integer from 0-6.</returns>
        public int getUTCDay() { return 0; }

        /// <summary>
        /// Gets the year, in universal time.
        /// </summary>
        /// <returns>A four digit integer.</returns>
        public int getUTCFullYear() { return 0; }

        /// <summary>
        /// Gets the hour, in universal time.
        /// </summary>
        /// <returns>An integer from 0-23.</returns>
        public int getUTCHours() { return 0; }

        /// <summary>
        /// Gets the milliseconds, in universal time.
        /// </summary>
        /// <returns>An integer from 0-999.</returns>
        public int getUTCMilliseconds() { return 0; }

        /// <summary>
        /// Gets the minutes, in universal time.
        /// </summary>
        /// <returns>An integer from 0-59.</returns>
        public int getUTCMinutes() { return 0; }

        /// <summary>
        /// Gets the month, in universal time.
        /// </summary>
        /// <returns>An integer from 0-11.</returns>
        public int getUTCMonth() { return 0; }

        /// <summary>
        /// Gets the seconds, in universal time.
        /// </summary>
        /// <returns>An integer 0-59.</returns>
        public int getUTCSeconds() { return 0; }

        /// <summary>
        /// Sets the day of the month, from 1-31.
        /// </summary><param name="date">The date value.</param>
        public void setDate(int date) { }

        /// <summary>
        /// Sets the four digit year.
        /// </summary>
        /// <param name="year">The year value.</param>
        public void setFullYear(int year) { }

        /// <summary>
        /// Sets the hour, from 0-23.
        /// </summary>
        /// <param name="hour">The hour value.</param>
        public void setHours(int hour) { }

        /// <summary>
        /// Sets the milliseconds, from 0-999.
        /// </summary>
        /// <param name="milliseconds">The millisecond value.</param>
        public void setMilliseconds(int milliseconds) { }

        /// <summary>
        /// Set the minutes, from 0-59.
        /// </summary>
        /// <param name="minute">The minute value.</param>
        public void setMinutes(int minute) { }

        /// <summary>
        /// Sets the month, from 0-11.
        /// </summary>
        /// <param name="month">The month value.</param>
        public void setMonth(int month) { }

        /// <summary>
        /// Sets the seconds, from 0-59.
        /// </summary>
        /// <param name="second">The second value.</param>
        public void setSeconds(int second) { }

        /// <summary>
        /// Sets the time as an offset in milliseconds from Jan 1, 1970.
        /// </summary>
        /// <param name="millisecond">The millisecond value.</param>
        public void setTime(int millisecond) { }

        /// <summary>
        /// Sets the day of the month, in universal time, from 1-31.
        /// </summary>
        /// <param name="month">The month value.</param>
        public void setUTCDate(int month) { }

        /// <summary>
        /// Set the four digit year, in universal time.
        /// </summary>
        /// <param name="year">The year value.</param>
        public void setUTCFullYear(int year) { }

        /// <summary>
        /// Sets the hour, in universal time, from 0-23.
        /// </summary>
        /// <param name="hour">The hour value.</param>
        public void setUTCHours(int hour) { }

        /// <summary>
        /// Sets the milliseconds, in universal time, from 0-999.
        /// </summary>
        /// <param name="millisecond">The millisecond value.</param>
        public void setUTCMilliseconds(int millisecond) { }

        /// <summary>
        /// Set the minutes, in universal time, from 0-59.
        /// </summary>
        /// <param name="minute">The minute value.</param>
        public void setUTCMinutes(int minute) { }

        /// <summary>
        /// Sets the month, in universal time, from 0-11.
        /// </summary>
        /// <param name="month">The month value.</param>
        public void setUTCMonth(int month) { }

        /// <summary>
        /// Set the seconds, in universal time, from 0-59.
        /// </summary>
        /// <param name="second">The second value.</param>
        public void setUTCSeconds(int second) { }

        /// <summary>
        /// Gets the date portion of a date object as a string.
        /// </summary>
        /// <returns>A date string.</returns>
        public string toDateString() { return null; }

        /// <summary>
        /// Gets the date portion of a date object as a string, using locale conventions.
        /// </summary>
        /// <returns>A date string.</returns>
        public string toLocaleDateString() { return null; }

        /// <summary>
        /// Gets the time portion of a date object as a string, using locale conventions.
        /// </summary>
        /// <returns>A date string.</returns>
        public string toLocaleTimeString() { return null; } //	Returns the time portion of a Date object as a string, using locale conventions

        /// <summary>
        /// Gets the time portion of a date object as a string.
        /// </summary>
        /// <returns>A date string.</returns>
        public string toTimeString() { return null; }

        /// <summary>
        /// Gets a date string, in universal time.
        /// </summary>
        /// <returns>A date string.</returns>
        public string toUTCString() { return null; }

        #endregion

        #region Static Members

        /// <summary>
        /// Gets the current date and time as an offset in milliseconds since Jan 1, 1970.
        /// </summary>
        /// <returns>An integer.</returns>
        public static int now() { return 0; }

        /// <summary>
        /// A string representing a date.
        /// </summary>
        /// <returns>The number of milliseconds since Jan 1, 1970.</returns>
        public static int parse(string dateString) { return 0; }

        /// <summary>
        /// Gets the number of milliseconds in a date string sine Jan 1, 1970, in universal time.
        /// </summary>
        /// <returns>An integer.</returns>
        public static int UTC() { return 0; }

        #endregion
    }
}