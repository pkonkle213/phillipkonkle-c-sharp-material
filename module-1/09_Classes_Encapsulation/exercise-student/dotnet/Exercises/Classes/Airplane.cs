namespace Exercises.Classes
{
    public class Airplane
    {
        public Airplane(string planeNumber, int totalFirstClassSeats, int totalCoachSeats)
        {
            this.PlaneNumber = planeNumber;
            this.TotalFirstClassSeats = totalFirstClassSeats;
            this.TotalCoachSeats = totalCoachSeats;
        }
        
        public string PlaneNumber { get; private set; }
        
        public int TotalFirstClassSeats { get; private set; }
        
        public int BookedFirstClassSeats { get; private set; }
        
        public int TotalCoachSeats { get; private set; }
        
        public int BookedCoachSeats { get; private set; }
        
        public int AvailableFirstClassSeats
        {
            get
            {
                return TotalFirstClassSeats - BookedFirstClassSeats;
            }
        }

        public int AvailableCoachSeats
        {
            get
            {
                return TotalCoachSeats - BookedCoachSeats;
            }
        }

        public bool ReserveSeats(bool forFirstClass,int totalNumberOfSeats)
        {
            if (forFirstClass && TotalFirstClassSeats >= totalNumberOfSeats)
            {
                BookedFirstClassSeats += totalNumberOfSeats;
                return true;
            }
            else if (!forFirstClass && TotalCoachSeats >= totalNumberOfSeats)
            {
                BookedCoachSeats += totalNumberOfSeats;
                return true;
            }
            return false;
        }
    }
}
