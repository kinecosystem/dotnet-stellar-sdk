using System;

namespace kin_base
{
    /// <summary>
    /// Exception thrown when WebAuthentication verification fails.
    /// </summary>
    public class InvalidWebAuthenticationException : Exception
    {
        public InvalidWebAuthenticationException(string message) : base(message)
        {
        }

        public InvalidWebAuthenticationException(string message, Exception inner) : base(message, inner)
        {
        }
    }
}