using System;

namespace kin_base.requests
{
    public class HttpResponseException : Exception
    {
        public HttpResponseException(int statusCode, string s)
            : base(s)
        {
            StatusCode = statusCode;
        }

        public int StatusCode { get; set; }
    }
}