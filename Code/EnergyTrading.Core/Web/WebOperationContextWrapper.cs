﻿// <auto-generated />

namespace EnergyTrading.Web
{
    using System;
    using System.Collections.Specialized;
    using System.Net;
    using System.ServiceModel.Web;

    public class WebOperationContextWrapper : IWebOperationContextWrapper
    {
        public string ContentType
        {
            get { return OutgoingResponse.ContentType; }
            set { OutgoingResponse.ContentType = value; }
        }

        public string Location
        {
            get { return OutgoingResponse.Location; }
            set { OutgoingResponse.Location = value; }
        }

        public string InboundAbsoloutePath 
        {
            get
            {
                return this.AppPath();
            }
        }

        public Uri BaseUri
        {
            get
            {
                return WebOperationContext.Current.IncomingRequest.UriTemplateMatch.BaseUri;
            }
        }

        private string AppPath()
        {
            return WebOperationContext.Current.IncomingRequest.UriTemplateMatch.BaseUri.AbsolutePath.Substring(1);
        }

        public HttpStatusCode StatusCode
        {
            get { return OutgoingResponse.StatusCode; }
            set { OutgoingResponse.StatusCode = value; }
        }

        public WebHeaderCollection Headers
        {
            get { return WebOperationContext.Current.IncomingRequest.Headers; }
        }

        public NameValueCollection QueryParameters
        {
            get { return WebOperationContext.Current.IncomingRequest.UriTemplateMatch.QueryParameters; }
        }

        public void CheckConditionalRetrieve(long entityTag)
        {
            WebOperationContext.Current.IncomingRequest.CheckConditionalRetrieve(entityTag);
        }

        public void SetETag(long entityTag)
        {
            WebOperationContext.Current.OutgoingResponse.SetETag(entityTag);
        }

        private OutgoingWebResponseContext OutgoingResponse
        {
            get { return WebOperationContext.Current.OutgoingResponse; }
        }

        protected T QueryParameter<T>(string name, T defaultValue = default(T))
        {
            bool found;
            return QueryParameter<T>(name, out found, defaultValue);
        }

        /// <summary>
        /// Get a query string parameter of type T, returning the specified value if not found.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="name"></param>
        /// <param name="found"></param>
        /// <param name="defaultValue"></param>
        /// <returns></returns>
        protected T QueryParameter<T>(string name, out bool found, T defaultValue = default(T))
        {
            var value = QueryParameters[name];
            if (string.IsNullOrEmpty(value))
            {
                found = false;
                return defaultValue;
            }

            found = true;
            // Does this do a cast or a parse?
            return (T)Convert.ChangeType(value, typeof(T));
        }

        /// <summary>
        /// Get a query string parameter of type T, returning the specified value if not found and letting us
        /// know if we found a value.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="name"></param>
        /// <param name="value"></param>
        /// <param name="defaultValue"></param>
        /// <returns></returns>
        protected bool TryGetQueryParameter<T>(string name, out T value, T defaultValue = default(T))
        {
            var fred = QueryParameters[name];

            if (fred == null)
            {
                value = defaultValue;
                return false;
            }

            // Does this do a cast or a parse?
            value = (T)Convert.ChangeType(fred, typeof(T));
            return true;
        }

        [Obsolete("Use TryGetQueryParameter")]
        protected bool aTryGetQueryParameter<T>(string name, out T value, T defaultValue = default(T))
        {
            var fred = QueryParameters[name];

            if (fred == null)
            {
                value = defaultValue;
                return false;
            }

            // Does this do a cast or a parse?
            value = this.Factory<T>(fred);
            return true;
        }

        protected virtual T Factory<T>(string value)
        {
            return (T) Convert.ChangeType(value, typeof(T));
        }
    }
}