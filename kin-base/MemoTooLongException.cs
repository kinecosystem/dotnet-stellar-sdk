// This file was modified by Kin Ecosystem (2019)


using System;
using System.Runtime.Serialization;

namespace Kin.Base
{
    [Serializable]
    public class MemoTooLongException : Exception
    {
        public MemoTooLongException()
        {
        }

        public MemoTooLongException(string message) : base(message)
        {
        }

        public MemoTooLongException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected MemoTooLongException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
