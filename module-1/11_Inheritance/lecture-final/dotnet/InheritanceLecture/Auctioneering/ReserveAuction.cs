using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceLecture.Auctioneering
{
    // ReserveAuction inherits from Auction ("is a")
    public class ReserveAuction : Auction
    {
        public ReserveAuction() : base("Mystery Item")
        {

        }

        public ReserveAuction(string item) : base(item)
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

            LogBid(offeredBid);

            Console.WriteLine("Cut it out, cheapskate!");
            return false; // False means not the high bid
        }
    }
}
