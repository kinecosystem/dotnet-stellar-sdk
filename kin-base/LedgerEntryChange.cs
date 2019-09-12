using System;
using Kin.Base.xdr;

namespace Kin.Base
{
    public class LedgerEntryChange
    {
        public UInt32 LastModifiedLedgerSeq { get; private set;}

        protected LedgerEntryChange() {}

        public static LedgerEntryChange FromXdr(LedgerEntry xdr)
        {
            LedgerEntryChange entryChange = null;
            switch (xdr.Data.Discriminant.InnerValue)
            {
                case LedgerEntryType.LedgerEntryTypeEnum.ACCOUNT:
                    entryChange = AccountLedgerEntryChange.FromXdr(xdr.Data.Account);
                    entryChange.LastModifiedLedgerSeq = (UInt32) xdr.LastModifiedLedgerSeq.InnerValue;
                    break;
                case LedgerEntryType.LedgerEntryTypeEnum.DATA:
                case LedgerEntryType.LedgerEntryTypeEnum.TRUSTLINE:
                case LedgerEntryType.LedgerEntryTypeEnum.OFFER:
                    break;
                default:
                    throw new ArgumentException("The provided xdr's entry type is invalid");
            }

            return entryChange;
        }
    }
}
