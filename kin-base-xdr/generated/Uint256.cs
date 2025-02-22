// Automatically generated by xdrgen
// DO NOT EDIT or your changes may be overwritten

using System;

namespace Kin.Base.xdr
{
// === xdr source ============================================================
//  typedef opaque uint256[32];
//  ===========================================================================
    public class Uint256
    {
        public byte[] InnerValue { get; set; } = default(byte[]);

        public Uint256()
        {
        }

        public Uint256(byte[] value)
        {
            InnerValue = value;
        }

        public static void Encode(XdrDataOutputStream stream, Uint256 encodedUint256)
        {
            int uint256size = encodedUint256.InnerValue.Length;
            stream.Write(encodedUint256.InnerValue, 0, uint256size);
        }

        public static Uint256 Decode(XdrDataInputStream stream)
        {
            Uint256 decodedUint256 = new Uint256();
            int uint256size = 32;
            decodedUint256.InnerValue = new byte[uint256size];
            stream.Read(decodedUint256.InnerValue, 0, uint256size);
            return decodedUint256;
        }
    }
}
