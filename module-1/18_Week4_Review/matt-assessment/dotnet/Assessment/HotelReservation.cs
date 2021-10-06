using System;
using System.Collections.Generic;
using System.Text;

namespace Assessment
{
    public class HotelReservation
    {
        public HotelReservation(string name, int numNights)
        {
            this.Name = name;
            this.NumberOfNights = numNights;
        }

        public string Name { get; }
        public int NumberOfNights { get; }

        public decimal EstimatedTotal
        {
            get
            {
                const decimal dailyRate = 59.99M;

                return NumberOfNights * dailyRate;
            }
        }

        public decimal CalcuateTotal(bool requiresCleaning, bool usedMinibar)
        {
            decimal total = EstimatedTotal; // Start out at the base price per night of the stay

            const decimal cleaningFee = 34.99M;
            const decimal minibarFee = 12.99M;

            if (usedMinibar)
            {
                total += minibarFee;
            }

            if (requiresCleaning)
            {

                total += cleaningFee;

                if (usedMinibar) // Cleaning fee is doubled if they used the minibar (in addition to the minibar fee)
                {
                    total += cleaningFee;
                } 
            }

            return total;
        }

        public override string ToString()
        {
            return $"RESERVATION - {Name} - {EstimatedTotal}";
        }
    }
}
