// This file was modified by Kin Ecosystem (2019)


using System;

namespace Kin.Base.responses.results
{
    public class BumpSequenceResult : OperationResult
    {
        public static BumpSequenceResult FromXdr(xdr.BumpSequenceResult result)
        {
            switch (result.Discriminant.InnerValue)
            {
                case xdr.BumpSequenceResultCode.BumpSequenceResultCodeEnum.BUMP_SEQUENCE_SUCCESS:
                    return new BumpSequenceSuccess();
                case xdr.BumpSequenceResultCode.BumpSequenceResultCodeEnum.BUMP_SEQUENCE_BAD_SEQ:
                    return new BumpSequenceBadSeq();
                default:
                    throw new SystemException("Unknown BumpSequence type");
            }
        }
    }
}
