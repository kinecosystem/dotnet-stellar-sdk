// This file was modified by Kin Ecosystem (2019)


using System;

namespace kin_base.requests
{
    public class ClientProtocolException : Exception
    {
        public ClientProtocolException(string message)
            : base(message)
        {
        }
    }
}