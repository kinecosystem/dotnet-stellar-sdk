// This file was modified by Kin Ecosystem (2019)


using System;

namespace Kin.Base.requests
{
    public class TooManyRequestsException : Exception
    {
        public TooManyRequestsException(int retryAfter)
            : base("The rate limit for the requesting IP address is over its alloted limit.")
        {
            RetryAfter = retryAfter;
        }

        public int RetryAfter { get; set; }
    }
}
