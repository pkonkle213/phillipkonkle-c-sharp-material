namespace WorldGeography.Models
{
    public class City
    {
        public int CityId { get; set; }
        public string Name { get; set; }
        public string District { get; set; }
        public string CountryCode { get; set; }
        public int Population { get; set; }

        public override string ToString()
        {
            // -6's etc. are PadRight(6) calls. :N0 is a ToString("N0") call
            return $"{CityId,-6}{Name,-30}{District,-30}{Population,-10:N0}";
        }
    }
}
