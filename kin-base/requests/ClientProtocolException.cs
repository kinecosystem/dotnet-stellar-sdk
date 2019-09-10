// This file was modified by Kin Ecosystem (2019)


using System;

namespace Kin.Base.requests
{
    public class ClientProtocolException : Exception
    {
        public ClientProtocolException(string message)
            : base(message)
        {
        }
    }
}
