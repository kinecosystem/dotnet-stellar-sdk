// This file was modified by Kin Ecosystem (2019)


using System;

namespace Kin.Base.requests
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
