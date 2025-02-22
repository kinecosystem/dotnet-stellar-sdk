// This file was modified by Kin Ecosystem (2019)


using Kin.Base.xdr;

namespace Kin.Base
{
    public class AssetTypeNative : Asset
    {
        public override int GetHashCode()
        {
            return 0;
        }

        public override string GetType()
        {
            return "native";
        }

        public override bool Equals(object obj)
        {
            return GetHashCode() == obj.GetHashCode();
        }

        public override xdr.Asset ToXdr()
        {
            var thisXdr = new xdr.Asset();
            thisXdr.Discriminant = AssetType.Create(AssetType.AssetTypeEnum.ASSET_TYPE_NATIVE);
            return thisXdr;
        }
    }
}
