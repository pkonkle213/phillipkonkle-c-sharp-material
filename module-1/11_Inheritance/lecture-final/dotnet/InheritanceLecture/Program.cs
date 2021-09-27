using InheritanceLecture.Auctioneering;
using System;

namespace InheritanceLecture
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Create a new general auction
            Console.WriteLine("Starting a general auction");
            Console.WriteLine("-----------------");

            Auction generalAuction = new Auction("Up");

            Bid mattBid = new Bid("Matt", 1);
            generalAuction.PlaceBid(mattBid);

            generalAuction.PlaceBid(new Bid("Rick Astley", 10));
            generalAuction.PlaceBid(new Bid("Kevin", 13));
            generalAuction.PlaceBid(new Bid("Matt", 5));
            //....
            //....
            // This might go on until the auction runs out of time or hits a max # of bids
            generalAuction.EndAuction();

            // Create a new ReserveAuction (buyer can reject small bids)
            Console.WriteLine("Starting new ReserveAuction");
            ReserveAuction reserve = new ReserveAuction("John's Ferrari");
            reserve.MinimumBid = 10000;

            reserve.PlaceBid(new Bid("Matt", 5));
            reserve.PlaceBid(new Bid("Coach Steve", 10001));

            reserve.EndAuction();

            // Create a new BuyoutAuction (big bids can end the auction)
            Console.WriteLine();
            Console.WriteLine("Starting BuyoutAuction");
            BuyoutAuction buyout = new BuyoutAuction("Dr. Pepper", 50);

            buyout.PlaceBid(new Bid("Kevin", 1));
            buyout.PlaceBid(new Bid("Rachelle", 2));
            buyout.PlaceBid(new Bid("Matt", 1024));
            buyout.PlaceBid(new Bid("Kevin", 1025));


            Console.ReadLine();
        }
    }
}
