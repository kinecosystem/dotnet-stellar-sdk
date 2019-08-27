using System;

namespace kin_base.federation
{
    /// <summary>
    ///     Federation server was not found in stellar.toml file.
    /// </summary>
    internal class NoFederationServerException : Exception
    {
    }
}