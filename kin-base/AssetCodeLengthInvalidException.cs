// This file was modified by Kin Ecosystem (2019)


using System;
using System.Runtime.Serialization;

namespace Kin.Base
{
    [Serializable]
    internal class AssetCodeLengthInvalidException : Exception
    {
        public AssetCodeLengthInvalidException()
        {
        }

        public AssetCodeLengthInvalidException(string message) : base(message)
        {
        }

        public AssetCodeLengthInvalidException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected AssetCodeLengthInvalidException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
