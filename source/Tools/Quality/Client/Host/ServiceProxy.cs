using System;
using System.Browser;
using Blade.Tools.Quality.Shared;

namespace Blade.Tools.Quality.Host
{
    /// <summary>
    /// A class capable of communicating with the server.
    /// </summary>
    [ScriptNamespace("Blade")]
    internal class ServiceProxy
    {
        private string _baseUrl;
        private string _id;

        /// <summary>
        /// Creates a new proxy.
        /// </summary>
        /// <param name="baseUrl">The base URL.</param>
        public ServiceProxy(string baseUrl)
        {
            _baseUrl = baseUrl;
        }

        /// <summary>
        /// Sends a connection request.
        /// </summary>
        /// <param name="callback">The completion callback.</param>
        public void Connect(Action callback)
        {
            var self = this;
            Get("connect", (obj) =>
            {
                self._id = ((dynamic)obj).ClientId;
                callback();
            });
        }

        /// <summary>
        /// Gets the next operation.
        /// </summary>
        /// <param name="callback">The completion callback.</param>
        public void GetNextOp(Action<OperationData> callback)
        {
            var route = BuildRoute("nextop", null, null);

            Get(route, (obj) =>
            {
                callback((OperationData)obj);
            });
        }

        /// <summary>
        /// Marks the current test as failed.
        /// </summary>
        /// <param name="errMsg">The error message.</param>
        /// <param name="callback">The completion callback.</param>
        public void FailTest(string errMsg, Action callback)
        {
            errMsg = window.encodeURIComponent(errMsg);
            var route = BuildRoute("fail", new[] { "errorMsg" }, new[] { errMsg });

            Get(route, (obj) => { callback(); });
        }

        /// <summary>
        /// Marks the current test as passed.
        /// </summary>
        /// <param name="callback">The completion callback.</param>
        public void PassTest(Action callback)
        {
            var route = BuildRoute("pass", null, null);

            Get(route, (obj) => { callback(); });
        }

        #region Helper Methods

        private static XMLHttpRequest CreateRequest()
        {
            try { return new XMLHttpRequest(); }
            catch
            {
                try { return (dynamic)new ActiveXObject("Microsoft.XMLHTTP"); }
                catch
                {
                    throw new Error("Unable to create an XMLHttpRequest object.");
                }
            }
        }

        private string BuildRoute(string route, string[] queryParams, string[] queryData)
        {
            var fullRoute = route + "?clientId=" + _id;

            if ((dynamic)queryParams && (dynamic)queryData)
            {
                for (int i = 0; i < queryParams.length; i++)
                {
                    fullRoute += ("&" + queryParams[i] + "=" + queryData[i]);
                }
            }

            return fullRoute;
        }

        private void Get(string resource, Action<object> callback)
        {
            Request(resource, "GET", null, callback);
        }

        private void Post(string resource, string data, Action<object> callback)
        {
            Request(resource, "POST", data, callback);
        }

        private void Request(string resource, string method, string data, Action<object> callback)
        {
            var request = CreateRequest();
            var url = _baseUrl + "/" + resource;

            request.open(method, url, true);
            request.setRequestHeader("Content-type", "application/json");

            request.onreadystatechange = (Action)(() =>
            {
                if (request.readyState == ReadyState.DONE)
                {
                    if (request.HasResponse())
                    {
                        var obj = (DataObject<object>)request.GetResponseObject();
                        callback(obj.HasData() ? ((dynamic)obj).Data : null);
                    }
                    else callback(null);
                }
            });

            request.send(data);
        }

        #endregion
    }

    /// <summary>
    /// Mock object for ActiveX objects.
    /// </summary>
    [ScriptExternal]
    [ScriptIgnoreNamespace]
    internal class ActiveXObject
    {
        public ActiveXObject(string type)
        {
        }
    }
}