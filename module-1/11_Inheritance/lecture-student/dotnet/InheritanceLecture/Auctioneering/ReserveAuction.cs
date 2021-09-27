using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceLecture.Auctioneering
{
    public class ReserveAuction : Auction
    {
        public ReserveAuction(string itemname)
        {

        }
        public int MinimumBid { get; set; }

        public override bool PlaceBid(Bid offeredBid)
        {
            Console.WriteLine("Using ReserveAuction PlaceBid");

            if (offeredBid.BidAmount >= MinimumBid)
            {
                return base.PlaceBid(offeredBid);
            }

            Console.WriteLine("Cut it out, cheapskate!");
            return base.PlaceBid(offeredBid);
        }
    }
}
