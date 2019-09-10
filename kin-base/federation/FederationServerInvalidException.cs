// This file was modified by Kin Ecosystem (2019)


using System;

namespace Kin.Base.federation
{
    /// <inheritdoc />
    /// <summary>
    ///     Federation server is invalid (malformed URL, not HTTPS, etc.)
    /// </summary>
    public class FederationServerInvalidException : Exception
    {
        public override string Message => "Federation server is invalid (malformed URL, not HTTPS, etc.";
    }
}
