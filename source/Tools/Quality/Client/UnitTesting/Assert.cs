using System;

namespace Microsoft.VisualStudio.TestTools.UnitTesting
{
    /// <summary>
    /// Verifies conditions in unit tests using true/false propositions. 
    /// </summary>
    [ScriptNamespace("Blade")]
    public static class Assert
    {
        /// <summary>
        /// Verifies that a value is true.
        /// </summary>
        /// <param name="condition">The value to check.</param>
        /// <param name="message">The failure message.</param>
        /// <param name="parameters">The message parameters.</param>
        public static void IsTrue(bool condition, string message = null, object[] parameters = null)
        {
            if (!condition)
                Assert.HandleFail("Assert.IsTrue", message, parameters);
        }

        /// <summary>
        /// Verifies that a value is false.
        /// </summary>
        /// <param name="condition">The value to check.</param>
        /// <param name="message">The failure message.</param>
        /// <param name="parameters">The message parameters.</param>
        public static void IsFalse(bool condition, string message = null, object[] parameters = null)
        {
            if (condition)
                Assert.HandleFail("Assert.IsFalse", message, parameters);
        }

        /// <summary>
        /// Verifies that a value is null.
        /// </summary>
        /// <param name="value">The value to check.</param>
        /// <param name="message">The failure message.</param>
        /// <param name="parameters">The message parameters.</param>
        public static void IsNull(object value, string message = null, object[] parameters = null)
        {
            if (value != null)
                Assert.HandleFail("Assert.IsNull", message, parameters);
        }

        /// <summary>
        /// Verifies that a value is undefined.
        /// </summary>
        /// <param name="value">The value to check.</param>
        /// <param name="message">The failure message.</param>
        /// <param name="parameters">The message parameters.</param>
        public static void IsUndefined(object value, string message = null, object[] parameters = null)
        {
            if (value != window.undefined)
                Assert.HandleFail("Assert.IsUndefined", message, parameters);
        }

        /// <summary>
        /// Verifies that a value is null or undefined.
        /// </summary>
        /// <param name="value">The value to check.</param>
        /// <param name="message">The failure message.</param>
        /// <param name="parameters">The message parameters.</param>
        public static void IsNullOrUndefined(object value, string message = null, object[] parameters = null)
        {
            if (value != null && value != window.undefined)
                Assert.HandleFail("Assert.IsNullOrUndefined", message, parameters);
        }

        /// <summary>
        /// Verifies that a value is not null.
        /// </summary>
        /// <param name="value">The value to check.</param>
        /// <param name="message">The failure message.</param>
        /// <param name="parameters">The message parameters.</param>
        public static void IsNotNull(object value, string message = null, object[] parameters = null)
        {
            if (value == null)
                Assert.HandleFail("Assert.IsNotNull", message, parameters);
        }

        /// <summary>
        /// Verifies that a value is not undefined.
        /// </summary>
        /// <param name="value">The value to check.</param>
        /// <param name="message">The failure message.</param>
        /// <param name="parameters">The message parameters.</param>
        public static void IsNotUndefined(object value, string message = null, object[] parameters = null)
        {
            if (value == window.undefined)
                Assert.HandleFail("Assert.IsNotUndefined", message, parameters);
        }

        /// <summary>
        /// Verifies that a value is not null or undefined.
        /// </summary>
        /// <param name="value">The value to check.</param>
        /// <param name="message">The failure message.</param>
        /// <param name="parameters">The message parameters.</param>
        public static void IsNotNullOrUndefined(object value, string message = null, object[] parameters = null)
        {
            if (value == null || value == window.undefined)
                Assert.HandleFail("Assert.IsNotNullOrUndefined", message, parameters);
        }

        /// <summary>
        /// Verifies that two values are equal.
        /// </summary>
        /// <param name="expected">The expected value.</param>
        /// <param name="actual">The actual value.</param>
        /// <param name="message">The failure message.</param>
        /// <param name="parameters">The message parameters.</param>
        public static void AreEqual(object expected, object actual, string message = null, object[] parameters = null)
        {
            if (!(dynamic)expected || !(dynamic)actual)
                Assert.HandleFail("Assert.AreEqual", message, parameters);

            if (expected != actual)
                Assert.HandleFail("Assert.AreEqual", message, parameters);
        }

        /// <summary>
        /// Verifies that two values not equal.
        /// </summary>
        /// <param name="notExpected">The unexpected value.</param>
        /// <param name="actual">The actual value.</param>
        /// <param name="message">The failure message.</param>
        /// <param name="parameters">The message parameters.</param>
        public static void AreNotEqual(object notExpected, object actual, string message = null, object[] parameters = null)
        {
            if (!(dynamic)notExpected || !(dynamic)actual)
                return;

            if (notExpected == actual)
                Assert.HandleFail("Assert.AreNotEqual", message, parameters);
        }

        /// <summary>
        /// Verifies that two numbers are equal.
        /// </summary>
        /// <param name="expected">The expected value.</param>
        /// <param name="actual">The actual value.</param>
        /// <param name="delta"></param>
        /// <param name="message">The failure message.</param>
        /// <param name="parameters">The message parameters.</param>
        public static void AreEqualNumbers(INumber expected, INumber actual, INumber delta, string message = null, object[] parameters = null)
        {
            if(!(expected is Number) || !(actual is Number))
                Assert.HandleFail("Assert.AreEqual", message, parameters);

            if (Math.abs((double)expected - (double)actual) > (double)delta)
                Assert.HandleFail("Assert.AreEqual", message, parameters);
        }

        /// <summary>
        /// Verifies that two numbers are not equal.
        /// </summary>
        /// <param name="notExpected">The unexpected value.</param>
        /// <param name="actual">The actual value.</param>
        /// <param name="delta"></param>
        /// <param name="message">The failure message.</param>
        /// <param name="parameters">The message parameters.</param>
        public static void AreNotEqualNumbers(INumber notExpected, INumber actual, INumber delta, string message = null, object[] parameters = null)
        {
            if (!(notExpected is Number) || !(actual is Number))
                return;

            if (Math.abs((double)notExpected - (double)actual) <= (double)delta)
                Assert.HandleFail("Assert.AreNotEqual", message, parameters);
        }


        /// <summary>
        /// Verifies that two strings are equal.
        /// </summary>
        /// <param name="expected">The expected value.</param>
        /// <param name="actual">The actual value.</param>
        /// <param name="ignoreCase">True to ignore case, false otherwise.</param>
        /// <param name="message">The failure message.</param>
        /// <param name="parameters">The message parameters.</param>
        public static void AreEqualStrings(string expected, string actual, bool ignoreCase = false, string message = null, object[] parameters = null)
        {
            if (!(dynamic)expected || !(dynamic)actual)
                Assert.HandleFail("Assert.AreEqual", message, parameters);

            if (ignoreCase)
            {
                if (expected.toLowerCase() != actual.toLowerCase())
                    Assert.HandleFail("Assert.AreEqual", message, parameters);
            }
            else
            {
                if (expected != actual)
                    Assert.HandleFail("Assert.AreEqual", message, parameters);
            }
        }

        /// <summary>
        /// Verifies that two strings are not equal.
        /// </summary>
        /// <param name="notExpected">The unexpected value.</param>
        /// <param name="actual">The actual value.</param>
        /// <param name="ignoreCase">True to ignore case, false otherwise.</param>
        /// <param name="message">The failure message.</param>
        /// <param name="parameters">The message parameters.</param>
        public static void AreNotEqualStrings(string notExpected, string actual, bool ignoreCase = false, string message = null, object[] parameters = null)
        {
            if (!(dynamic)notExpected || !(dynamic)actual)
                return;

            if (ignoreCase)
            {
                if (notExpected.toLowerCase() == actual.toLowerCase())
                    Assert.HandleFail("Assert.AreNotEqual", message, parameters);
            }
            else
            {
                if (notExpected == actual)
                    Assert.HandleFail("Assert.AreNotEqual", message, parameters);
            }
        }

        /// <summary>
        /// Fails with a specific message.
        /// </summary>
        /// <param name="message">The failure message.</param>
        /// <param name="parameters">The message parameters.</param>
        public static void Fail(string message = null, object[] parameters = null)
        {
            Assert.HandleFail("Assert.Fail", message, parameters);
        }

        /// <summary>
        /// Handler for all failures.
        /// </summary>
        /// <param name="assertionName">The assert name.</param>
        /// <param name="message">The failure message.</param>
        /// <param name="parameters">The message parameters.</param>
        internal static void HandleFail(string assertionName, string message, object[] parameters)
        {
            message = assertionName + " - " + (message ?? "");

            if ((dynamic)parameters)
            {
                for (int i = 0; i < parameters.length; i++)
                {
                    message = message.replace("{" + i + "}", parameters[i].toString());
                }
            }

            throw new Error(message);
        }
    }
}