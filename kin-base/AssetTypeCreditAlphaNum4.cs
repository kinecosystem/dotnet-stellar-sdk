// This file was modified by Kin Ecosystem (2019)


using Kin.Base.xdr;

namespace Kin.Base
{
    public class AssetTypeCreditAlphaNum4 : AssetTypeCreditAlphaNum
    {
        public AssetTypeCreditAlphaNum4(string code, string issuer) : base(code, issuer)
        {
            if (code.Length < 1 || code.Length > 4)
                throw new AssetCodeLengthInvalidException();
        }

        public override string GetType()
        {
            return "credit_alphanum4";
        }

        public override xdr.Asset ToXdr()
        {
            var thisXdr = new xdr.Asset();
            thisXdr.Discriminant = AssetType.Create(AssetType.AssetTypeEnum.ASSET_TYPE_CREDIT_ALPHANUM4);
            var credit = new xdr.Asset.AssetAlphaNum4();
            credit.AssetCode = new AssetCode4(Util.PaddedByteArray(Code, 4));
            var accountID = new AccountID();
            accountID.InnerValue = KeyPair.FromAccountId(Issuer).XdrPublicKey;
            credit.Issuer = accountID;
            thisXdr.AlphaNum4 = credit;
            return thisXdr;
        }
    }
}
