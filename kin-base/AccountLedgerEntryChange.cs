using Kin.Base.xdr;

namespace Kin.Base
{
    public class AccountLedgerEntryChange : LedgerEntryChange
    {
        public KeyPair AccountId { get; private set;}
        public string Balance { get; private set;}

        AccountLedgerEntryChange() {}

        public static AccountLedgerEntryChange FromXdr(AccountEntry xdr)
        {
            AccountLedgerEntryChange entry = new AccountLedgerEntryChange();
            entry.AccountId = KeyPair.FromXdrPublicKey(xdr.AccountID.InnerValue);
            entry.Balance = Operation.FromXdrAmount(xdr.Balance.InnerValue);
            return entry;
        }
    }
}
