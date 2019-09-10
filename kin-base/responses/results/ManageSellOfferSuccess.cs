// This file was modified by Kin Ecosystem (2019)


using System;
using System.Linq;
using Kin.Base.xdr;

namespace Kin.Base.responses.results
{
    /// <summary>
    /// Operation successful.
    /// </summary>
    public class ManageSellOfferSuccess : ManageSellOfferResult
    {
        public override bool IsSuccess => true;

        /// <summary>
        /// Offers that got claimed while creating this offer.
        /// </summary>
        public ClaimOfferAtom[] OffersClaimed { get; set; }

        public static ManageSellOfferSuccess FromXdr(xdr.ManageOfferSuccessResult result)
        {
            var offersClaimed = result.OffersClaimed.Select(ClaimOfferAtom.FromXdr).ToArray();

            switch (result.Offer.Discriminant.InnerValue)
            {
                case ManageOfferEffect.ManageOfferEffectEnum.MANAGE_OFFER_CREATED:
                    var createdOffer = OfferEntry.FromXdr(result.Offer.Offer);
                    return new ManageSellOfferCreated
                    {
                        OffersClaimed = offersClaimed,
                        Offer = createdOffer,
                    };
                case ManageOfferEffect.ManageOfferEffectEnum.MANAGE_OFFER_UPDATED:
                    var updatedOffer = OfferEntry.FromXdr(result.Offer.Offer);
                    return new ManageSellOfferUpdated
                    {
                        OffersClaimed = offersClaimed,
                        Offer = updatedOffer,
                    };
                case ManageOfferEffect.ManageOfferEffectEnum.MANAGE_OFFER_DELETED:
                    return new ManageSellOfferDeleted
                    {
                        OffersClaimed = offersClaimed
                    };
                default:
                    throw new SystemException("Unknown ManageSellOfferSuccess type");
            }
        }
    }
}
