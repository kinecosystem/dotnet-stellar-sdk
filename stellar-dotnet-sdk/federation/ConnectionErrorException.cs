using System;

namespace kin_base.federation
{
    public class ConnectionErrorException : Exception
    {
        public ConnectionErrorException()
        {
        }

        public ConnectionErrorException(string message)
            : base(message)
        {
        }
    }
}