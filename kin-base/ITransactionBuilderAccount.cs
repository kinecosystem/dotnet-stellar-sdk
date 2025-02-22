// This file was modified by Kin Ecosystem (2019)


namespace Kin.Base
{
    public interface ITransactionBuilderAccount
    {
        string AccountId { get; }

        KeyPair KeyPair { get; }
        long SequenceNumber { get; }

        ///<summary>
        /// Returns sequence number incremented by one, but does not increment internal counter.
        ///</summary>
        long IncrementedSequenceNumber { get; }

        ///<summary>
        /// Increments sequence number in this object by one.
        ///</summary>
        void IncrementSequenceNumber();
    }
}
