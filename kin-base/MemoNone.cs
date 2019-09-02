// This file was modified by Kin Ecosystem (2019)


using kin_base.xdr;

namespace kin_base
{
    public class MemoNone : Memo
    {
        public override xdr.Memo ToXdr()
        {
            var memo = new xdr.Memo();
            memo.Discriminant = MemoType.Create(MemoType.MemoTypeEnum.MEMO_NONE);
            return memo;
        }

        public override bool Equals(System.Object o)
        {
            if (this == o) return true;
            if (o == null || GetType() != o.GetType()) return false;
            return true;
        }

        public override int GetHashCode()
        {
            return GetType().GetHashCode();
        }
    }
}