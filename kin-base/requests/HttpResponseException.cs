// This file was modified by Kin Ecosystem (2019)


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