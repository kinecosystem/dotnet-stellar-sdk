// This file was modified by Kin Ecosystem (2019)


using System;

namespace Kin.Base.federation
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
