// This file was modified by Kin Ecosystem (2019)


using System;

namespace kin_base.responses.results
{
    public class CreateAccountResult : OperationResult
    {
        public static CreateAccountResult FromXdr(xdr.CreateAccountResult result)
        {
            switch (result.Discriminant.InnerValue)
            {
                case xdr.CreateAccountResultCode.CreateAccountResultCodeEnum.CREATE_ACCOUNT_SUCCESS:
                    return new CreateAccountSuccess();
                case xdr.CreateAccountResultCode.CreateAccountResultCodeEnum.CREATE_ACCOUNT_MALFORMED:
                    return new CreateAccountMalformed();
                case xdr.CreateAccountResultCode.CreateAccountResultCodeEnum.CREATE_ACCOUNT_UNDERFUNDED:
                    return new CreateAccountUnderfunded();
                case xdr.CreateAccountResultCode.CreateAccountResultCodeEnum.CREATE_ACCOUNT_LOW_RESERVE:
                    return new CreateAccountLowReserve();
                case xdr.CreateAccountResultCode.CreateAccountResultCodeEnum.CREATE_ACCOUNT_ALREADY_EXIST:
                    return new CreateAccountAlreadyExists();
                default:
                    throw new SystemException("Unknown CreateAccountResult type");
            }
        }
    }
}