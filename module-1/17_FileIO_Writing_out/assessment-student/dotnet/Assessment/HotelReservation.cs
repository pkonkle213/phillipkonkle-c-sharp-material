using System;
using System.Collections.Generic;
using System.Text;

namespace Assessment
{
    public class HotelReservation
    {
        public HotelReservation(string name, int numberNights)
        {
            this.Name = name;
            this.NumberNights = numberNights;
        }

        public string Name { get; }
        public int NumberNights { get; }
        public decimal EstimatedTotal
        {
            get
            {
                const decimal nightlyRate = 59.99M;
                decimal estimatedTotal = NumberNights * nightlyRate;
                return estimatedTotal;
            }
        }

        public decimal ActualTotal(bool requiresCleaning, bool usedMinibar)
        {
            const decimal minibarFee = 12.99M;
            const decimal cleaningFee = 34.99M;
            decimal totalFee = EstimatedTotal;
            
            if (usedMinibar)
            {
                totalFee += minibarFee;
            }

            if (requiresCleaning && usedMinibar)
            {
                totalFee += 2 * cleaningFee;
            }
            else if (requiresCleaning)
            {
                totalFee += cleaningFee;
            }

            return totalFee;
        }

        public override string ToString()
        {
            return $"RESERVATION - {Name} - {EstimatedTotal.ToString("C")}";
        }
    }
}
