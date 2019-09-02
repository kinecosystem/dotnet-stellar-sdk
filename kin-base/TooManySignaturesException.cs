// This file was modified by Kin Ecosystem (2019)


using System;
using System.Runtime.Serialization;

namespace kin_base
{
    [Serializable]
    internal class TooManySignaturesException : Exception
    {
        public TooManySignaturesException()
        {
        }

        public TooManySignaturesException(string message) : base(message)
        {
        }

        public TooManySignaturesException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected TooManySignaturesException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}