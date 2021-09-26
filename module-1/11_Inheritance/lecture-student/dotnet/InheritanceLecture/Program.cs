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

            generalAuction.PlaceBid(new Bid("Matt", 1));
            generalAuction.PlaceBid(new Bid("Rick Astley", 10));
            generalAuction.PlaceBid(new Bid("Kevin", 13));
            //....
            //....
            // This might go on until the auction runs out of time or hits a max # of bids
            generalAuction.EndAuction();

            // Create a new ReserveAuction (buyer can reject small bids)

            // Create a new BuyoutAuction (big bids can end the auction)

            Console.ReadLine();
        }
    }
}
