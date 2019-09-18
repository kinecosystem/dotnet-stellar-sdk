using System;
using System.Collections.Generic;
using static Kin.Base.xdr.LedgerEntryChangeType.LedgerEntryChangeTypeEnum;

namespace Kin.Base
{
    public class LedgerEntryChanges
    {

        public LedgerEntryChange[] LedgerEntryUpdates { get; private set; }
        LedgerEntryChanges() { }

        public static LedgerEntryChanges FromXdr(Kin.Base.xdr.LedgerEntryChanges xdr)
        {
            LedgerEntryChanges changes = new LedgerEntryChanges();
            List<LedgerEntryChange> updates = new List<LedgerEntryChange>();
            foreach (var change in xdr.InnerValue)
            {
                switch (change.Discriminant.InnerValue)
                {
                    case LEDGER_ENTRY_UPDATED:
                        var result = LedgerEntryChange.FromXdr(change.Updated);
                        if (result != null)
                        {
                            updates.Add(result);
                        };
                        break;
                    case LEDGER_ENTRY_REMOVED:
                    case LEDGER_ENTRY_CREATED:
                    case LEDGER_ENTRY_STATE:
                        break;
                    default:
                        throw new ArgumentException("Invalid LedgerEntryType");
                }
            }

            changes.LedgerEntryUpdates = updates.ToArray();
            return changes;
        }
    }
}
