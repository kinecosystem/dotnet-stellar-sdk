// Automatically generated by xdrgen
// DO NOT EDIT or your changes may be overwritten

using System;

namespace Kin.Base.xdr
{
// === xdr source ============================================================
//  struct Auth
//  {
//      // Empty message, just to confirm
//      // establishment of MAC keys.
//      int unused;
//  };
//  ===========================================================================
    public class Auth
    {
        public Auth()
        {
        }

        public int Unused { get; set; }

        public static void Encode(XdrDataOutputStream stream, Auth encodedAuth)
        {
            stream.WriteInt(encodedAuth.Unused);
        }

        public static Auth Decode(XdrDataInputStream stream)
        {
            Auth decodedAuth = new Auth();
            decodedAuth.Unused = stream.ReadInt();
            return decodedAuth;
        }
    }
}
