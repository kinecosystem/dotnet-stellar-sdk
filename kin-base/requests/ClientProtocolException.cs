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