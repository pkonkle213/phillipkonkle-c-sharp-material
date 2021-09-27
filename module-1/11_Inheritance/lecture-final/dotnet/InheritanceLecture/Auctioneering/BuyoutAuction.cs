using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceLecture.Auctioneering
{
    public class BuyoutAuction : Auction
    {
        public BuyoutAuction(string itemName, int buyoutAmount)
            : base(itemName)
        {
            this.BuyoutAmount = buyoutAmount;
        }

        public int BuyoutAmount { get; set; }

        public override bool PlaceBid(Bid offeredBid)
        {
            bool isHighestBid = base.PlaceBid(offeredBid);

            if (offeredBid.BidAmount > BuyoutAmount && !HasEnded)
            {
                EndAuction();
            }

            return isHighestBid;
        }
    }
}
