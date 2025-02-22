// Automatically generated by xdrgen
// DO NOT EDIT or your changes may be overwritten

using System;

namespace Kin.Base.xdr
{
// === xdr source ============================================================
//  union Asset switch (AssetType type)
//  {
//  case ASSET_TYPE_NATIVE: // Not credit
//      void;
//
//  case ASSET_TYPE_CREDIT_ALPHANUM4:
//      struct
//      {
//          AssetCode4 assetCode;
//          AccountID issuer;
//      } alphaNum4;
//
//  case ASSET_TYPE_CREDIT_ALPHANUM12:
//      struct
//      {
//          AssetCode12 assetCode;
//          AccountID issuer;
//      } alphaNum12;
//
//      // add other asset types here in the future
//  };
//  ===========================================================================
    public class Asset
    {
        public Asset()
        {
        }

        public AssetType Discriminant { get; set; } = new AssetType();
        public AssetAlphaNum4 AlphaNum4 { get; set; }
        public AssetAlphaNum12 AlphaNum12 { get; set; }

        public static void Encode(XdrDataOutputStream stream, Asset encodedAsset)
        {
            stream.WriteInt((int) encodedAsset.Discriminant.InnerValue);
            switch (encodedAsset.Discriminant.InnerValue)
            {
                case AssetType.AssetTypeEnum.ASSET_TYPE_NATIVE:
                    break;
                case AssetType.AssetTypeEnum.ASSET_TYPE_CREDIT_ALPHANUM4:
                    AssetAlphaNum4.Encode(stream, encodedAsset.AlphaNum4);
                    break;
                case AssetType.AssetTypeEnum.ASSET_TYPE_CREDIT_ALPHANUM12:
                    AssetAlphaNum12.Encode(stream, encodedAsset.AlphaNum12);
                    break;
            }
        }

        public static Asset Decode(XdrDataInputStream stream)
        {
            Asset decodedAsset = new Asset();
            AssetType discriminant = AssetType.Decode(stream);
            decodedAsset.Discriminant = discriminant;
            switch (decodedAsset.Discriminant.InnerValue)
            {
                case AssetType.AssetTypeEnum.ASSET_TYPE_NATIVE:
                    break;
                case AssetType.AssetTypeEnum.ASSET_TYPE_CREDIT_ALPHANUM4:
                    decodedAsset.AlphaNum4 = AssetAlphaNum4.Decode(stream);
                    break;
                case AssetType.AssetTypeEnum.ASSET_TYPE_CREDIT_ALPHANUM12:
                    decodedAsset.AlphaNum12 = AssetAlphaNum12.Decode(stream);
                    break;
            }

            return decodedAsset;
        }

        public class AssetAlphaNum4
        {
            public AssetAlphaNum4()
            {
            }

            public AssetCode4 AssetCode { get; set; }
            public AccountID Issuer { get; set; }

            public static void Encode(XdrDataOutputStream stream, AssetAlphaNum4 encodedAssetAlphaNum4)
            {
                AssetCode4.Encode(stream, encodedAssetAlphaNum4.AssetCode);
                AccountID.Encode(stream, encodedAssetAlphaNum4.Issuer);
            }

            public static AssetAlphaNum4 Decode(XdrDataInputStream stream)
            {
                AssetAlphaNum4 decodedAssetAlphaNum4 = new AssetAlphaNum4();
                decodedAssetAlphaNum4.AssetCode = AssetCode4.Decode(stream);
                decodedAssetAlphaNum4.Issuer = AccountID.Decode(stream);
                return decodedAssetAlphaNum4;
            }
        }

        public class AssetAlphaNum12
        {
            public AssetAlphaNum12()
            {
            }

            public AssetCode12 AssetCode { get; set; }
            public AccountID Issuer { get; set; }

            public static void Encode(XdrDataOutputStream stream, AssetAlphaNum12 encodedAssetAlphaNum12)
            {
                AssetCode12.Encode(stream, encodedAssetAlphaNum12.AssetCode);
                AccountID.Encode(stream, encodedAssetAlphaNum12.Issuer);
            }

            public static AssetAlphaNum12 Decode(XdrDataInputStream stream)
            {
                AssetAlphaNum12 decodedAssetAlphaNum12 = new AssetAlphaNum12();
                decodedAssetAlphaNum12.AssetCode = AssetCode12.Decode(stream);
                decodedAssetAlphaNum12.Issuer = AccountID.Decode(stream);
                return decodedAssetAlphaNum12;
            }
        }
    }
}
