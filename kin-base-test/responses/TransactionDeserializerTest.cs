// This file was modified by Kin Ecosystem (2019)


using System.IO;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;
using Kin.Base;
using Kin.Base.responses;

namespace kin_base_test.responses
{
    [TestClass]
    public class TransactionDeserializerTest
    {
        [TestMethod]
        public void TestDeserialize()
        {
            var json = File.ReadAllText(Path.Combine("testdata", "transactionTransaction.json"));
            var transaction = JsonSingleton.GetInstance<TransactionResponse>(json);

            AssertTestData(transaction);
        }

        [TestMethod]
        public void TestSerializeDeserialize()
        {
            var json = File.ReadAllText(Path.Combine("testdata", "transactionTransaction.json"));
            var transaction = JsonSingleton.GetInstance<TransactionResponse>(json);
            var serialized = JsonConvert.SerializeObject(transaction);
            var back = JsonConvert.DeserializeObject<TransactionResponse>(serialized);

            Assert.IsTrue(back.Successful);
            AssertTestData(back);
        }

        public static void AssertTestData(TransactionResponse transaction)
        {
            Assert.AreEqual("5c2e4dad596941ef944d72741c8f8f1a4282f8f2f141e81d827f44bf365d626b", transaction.Hash);
            Assert.AreEqual(915744L, transaction.Ledger);
            Assert.AreEqual("2015-11-20T17:01:28Z", transaction.CreatedAt);
            Assert.AreEqual("3933090531512320", transaction.PagingToken);
            Assert.AreEqual("GCUB7JL4APK7LKJ6MZF7Q2JTLHAGNBIUA7XIXD5SQTG52GQ2DAT6XZMK", transaction.SourceAccount);
            Assert.AreEqual(2373051035426646L, transaction.SourceAccountSequence);
            Assert.AreEqual(100L, transaction.FeePaid);
            Assert.AreEqual(1, transaction.OperationCount);
            Assert.AreEqual(
                "AAAAAKgfpXwD1fWpPmZL+GkzWcBmhRQH7ouPsoTN3RoaGCfrAAAAZAAIbkcAAB9WAAAAAAAAAANRBBZE6D1qyGjISUGLY5Ldvp31PwAAAAAAAAAAAAAAAAAAAAEAAAABAAAAAP1qe44j+i4uIT+arbD4QDQBt8ryEeJd7a0jskQ3nwDeAAAAAAAAAADA7RnarSzCwj3OT+M2btCMFpVBdqxJS+Sr00qBjtFv7gAAAABLCs/QAAAAAAAAAAEaGCfrAAAAQG/56Cj2J8W/KCZr+oC4sWND1CTGWfaccHNtuibQH8kZIb+qBSDY94g7hiaAXrlIeg9b7oz/XuP3x9MWYw2jtwM=",
                transaction.EnvelopeXdr);
            Assert.AreEqual("AAAAAAAAAGQAAAAAAAAAAQAAAAAAAAAAAAAAAAAAAAA=", transaction.ResultXdr);
            Assert.AreEqual(
                "AAAAAAAAAAEAAAACAAAAAAAN+SAAAAAAAAAAAMDtGdqtLMLCPc5P4zZu0IwWlUF2rElL5KvTSoGO0W/uAAAAAEsKz9AADfkgAAAAAAAAAAAAAAAAAAAAAAAAAAABAAAAAAAAAAAAAAAAAAAAAAAAAQAN+SAAAAAAAAAAAP1qe44j+i4uIT+arbD4QDQBt8ryEeJd7a0jskQ3nwDeAAHp6WMr55YACD1BAAAAHgAAAAoAAAAAAAAAAAAAAAABAAAAAAAACgAAAAARC07BokpLTOF+/vVKBwiAlop7hHGJTNeGGlY4MoPykwAAAAEAAAAAK+Lzfd3yDD+Ov0GbYu1g7SaIBrKZeBUxoCunkLuI7aoAAAABAAAAAERmsKL73CyLV/HvjyQCERDXXpWE70Xhyb6MR5qPO3yQAAAAAQAAAABSORGwAdyuanN3sNOHqNSpACyYdkUM3L8VafUu69EvEgAAAAEAAAAAeCzqJNkMM/jLvyuMIfyFHljBlLCtDyj17RMycPuNtRMAAAABAAAAAIEi4R7juq15ymL00DNlAddunyFT4FyUD4muC4t3bobdAAAAAQAAAACaNpLL5YMfjOTdXVEqrAh99LM12sN6He6pHgCRAa1f1QAAAAEAAAAAqB+lfAPV9ak+Zkv4aTNZwGaFFAfui4+yhM3dGhoYJ+sAAAABAAAAAMNJrEvdMg6M+M+n4BDIdzsVSj/ZI9SvAp7mOOsvAD/WAAAAAQAAAADbHA6xiKB1+G79mVqpsHMOleOqKa5mxDpP5KEp/Xdz9wAAAAEAAAAAAAAAAA==",
                transaction.ResultMetaXdr);

            Assert.IsTrue(transaction.Memo is MemoHash);
            var memo = (MemoHash) transaction.Memo;
            Assert.AreEqual("51041644e83d6ac868c849418b6392ddbe9df53f000000000000000000000000", memo.GetHexValue());

            Assert.AreEqual("/accounts/GCUB7JL4APK7LKJ6MZF7Q2JTLHAGNBIUA7XIXD5SQTG52GQ2DAT6XZMK",
                transaction.Links.Account.Href);
            Assert.AreEqual(
                "/transactions/5c2e4dad596941ef944d72741c8f8f1a4282f8f2f141e81d827f44bf365d626b/effects{?cursor,limit,order}",
                transaction.Links.Effects.Href);
            Assert.AreEqual("/ledgers/915744", transaction.Links.Ledger.Href);
            Assert.AreEqual(
                "/transactions/5c2e4dad596941ef944d72741c8f8f1a4282f8f2f141e81d827f44bf365d626b/operations{?cursor,limit,order}",
                transaction.Links.Operations.Href);
            Assert.AreEqual("/transactions?cursor=3933090531512320&order=asc", transaction.Links.Precedes.Href);
            Assert.AreEqual("/transactions/5c2e4dad596941ef944d72741c8f8f1a4282f8f2f141e81d827f44bf365d626b",
                transaction.Links.Self.Href);
            Assert.AreEqual("/transactions?cursor=3933090531512320&order=desc", transaction.Links.Succeeds.Href);
        }

        [TestMethod]
        public void TestDeserializeWithoutMemo()
        {
            var json = File.ReadAllText(Path.Combine("testdata", "transactionTransactionWithoutMemo.json"));
            var transaction = JsonSingleton.GetInstance<TransactionResponse>(json);

            Assert.IsFalse(transaction.Successful);
            Assert.IsTrue(transaction.Memo is MemoNone);
        }

        [TestMethod]
        public void TestGetChanges()
        {
            var json = File.ReadAllText(Path.Combine("testdata", "transactionResultChanges.json"));
            var transaction = JsonSingleton.GetInstance<TransactionResponse>(json);

            // Transaction which created an account, and payed 10 kin to another
            List<LedgerEntryChanges> changes = transaction.GetLedgerChanges();
            Assert.AreEqual(changes.Count, 2); // Two operations
            Assert.AreEqual(changes[0].LedgerEntryUpdates.Length, 1);
            var accountEntry = (AccountLedgerEntryChange) changes[0].LedgerEntryUpdates[0];
            Assert.AreEqual(accountEntry.LastModifiedLedgerSeq, 4145508U);
            Assert.AreEqual(accountEntry.Balance, "74327872");
            Assert.AreEqual(accountEntry.AccountId.AccountId, "GA5VKONC2ABAHER37Q6WZ7JLBEQ2RENLU2GVP2K2E2HAJT2T6CNPZ7QX");

            Assert.AreEqual(changes[1].LedgerEntryUpdates.Length, 2);
            var accountEntry2 = (AccountLedgerEntryChange) changes[1].LedgerEntryUpdates[0];
            Assert.AreEqual(accountEntry2.LastModifiedLedgerSeq, 4145508U);
            Assert.AreEqual(accountEntry2.Balance, "74327862");
            Assert.AreEqual(accountEntry2.AccountId.AccountId, "GA5VKONC2ABAHER37Q6WZ7JLBEQ2RENLU2GVP2K2E2HAJT2T6CNPZ7QX");

            var accountEntry3 = (AccountLedgerEntryChange) changes[1].LedgerEntryUpdates[1];
            Assert.AreEqual(accountEntry3.LastModifiedLedgerSeq, 4145508U);
            Assert.AreEqual(accountEntry3.Balance, "10");
            Assert.AreEqual(accountEntry3.AccountId.AccountId, "GBGAUR5WGQF3UGGPT2FSWLBCA4WDWKVZOHXWVG5RVQHY4EKJ6SP4SG5G");
        }
    }
}
