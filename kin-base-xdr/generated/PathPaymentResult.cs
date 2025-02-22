// Automatically generated by xdrgen
// DO NOT EDIT or your changes may be overwritten

using System;

namespace Kin.Base.xdr
{
// === xdr source ============================================================
//  union PathPaymentResult switch (PathPaymentResultCode code)
//  {
//  case PATH_PAYMENT_SUCCESS:
//      struct
//      {
//          ClaimOfferAtom offers<>;
//          SimplePaymentResult last;
//      } success;
//  case PATH_PAYMENT_NO_ISSUER:
//      Asset noIssuer; // the asset that caused the error
//  default:
//      void;
//  };
//  ===========================================================================
    public class PathPaymentResult
    {
        public PathPaymentResult()
        {
        }

        public PathPaymentResultCode Discriminant { get; set; } = new PathPaymentResultCode();
        public PathPaymentResultSuccess Success { get; set; }
        public Asset NoIssuer { get; set; }

        public static void Encode(XdrDataOutputStream stream, PathPaymentResult encodedPathPaymentResult)
        {
            stream.WriteInt((int) encodedPathPaymentResult.Discriminant.InnerValue);
            switch (encodedPathPaymentResult.Discriminant.InnerValue)
            {
                case PathPaymentResultCode.PathPaymentResultCodeEnum.PATH_PAYMENT_SUCCESS:
                    PathPaymentResultSuccess.Encode(stream, encodedPathPaymentResult.Success);
                    break;
                case PathPaymentResultCode.PathPaymentResultCodeEnum.PATH_PAYMENT_NO_ISSUER:
                    Asset.Encode(stream, encodedPathPaymentResult.NoIssuer);
                    break;
                default:
                    break;
            }
        }

        public static PathPaymentResult Decode(XdrDataInputStream stream)
        {
            PathPaymentResult decodedPathPaymentResult = new PathPaymentResult();
            PathPaymentResultCode discriminant = PathPaymentResultCode.Decode(stream);
            decodedPathPaymentResult.Discriminant = discriminant;
            switch (decodedPathPaymentResult.Discriminant.InnerValue)
            {
                case PathPaymentResultCode.PathPaymentResultCodeEnum.PATH_PAYMENT_SUCCESS:
                    decodedPathPaymentResult.Success = PathPaymentResultSuccess.Decode(stream);
                    break;
                case PathPaymentResultCode.PathPaymentResultCodeEnum.PATH_PAYMENT_NO_ISSUER:
                    decodedPathPaymentResult.NoIssuer = Asset.Decode(stream);
                    break;
                default:
                    break;
            }

            return decodedPathPaymentResult;
        }

        public class PathPaymentResultSuccess
        {
            public PathPaymentResultSuccess()
            {
            }

            public ClaimOfferAtom[] Offers { get; set; }
            public SimplePaymentResult Last { get; set; }

            public static void Encode(XdrDataOutputStream stream,
                PathPaymentResultSuccess encodedPathPaymentResultSuccess)
            {
                int offerssize = encodedPathPaymentResultSuccess.Offers.Length;
                stream.WriteInt(offerssize);
                for (int i = 0; i < offerssize; i++)
                {
                    ClaimOfferAtom.Encode(stream, encodedPathPaymentResultSuccess.Offers[i]);
                }

                SimplePaymentResult.Encode(stream, encodedPathPaymentResultSuccess.Last);
            }

            public static PathPaymentResultSuccess Decode(XdrDataInputStream stream)
            {
                PathPaymentResultSuccess decodedPathPaymentResultSuccess = new PathPaymentResultSuccess();
                int offerssize = stream.ReadInt();
                decodedPathPaymentResultSuccess.Offers = new ClaimOfferAtom[offerssize];
                for (int i = 0; i < offerssize; i++)
                {
                    decodedPathPaymentResultSuccess.Offers[i] = ClaimOfferAtom.Decode(stream);
                }

                decodedPathPaymentResultSuccess.Last = SimplePaymentResult.Decode(stream);
                return decodedPathPaymentResultSuccess;
            }
        }
    }
}
