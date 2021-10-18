namespace WorldGeography.Models
{
    public class Country
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public string Continent { get; set; }
        public string Region { get; set; }
        public double SurfaceArea { get; set; }
        public int IndependenceYear { get; set; }
        public int Population { get; set; }
        public double? LifeExpectancy { get; set; } //<-- nullable property, it can have a value that is a double or NULL if there is no value
        public decimal? GNP { get; set; } //<-- nullable property, it can have a value that is a decimal or NULL if there is no value
        public string LocalName { get; set; }
        public string GovernmentForm { get; set; }
        public string HeadOfState { get; set; }
        public int? CapitalId { get; set; } //<-- nullable property, it can have a value that is a int or NULL if there is no value
        public string Code2 { get; set; }

        public override string ToString()
        {
            // -5's etc. are PadRight(5) calls. :N0, :N2 are ToString("N0") and ToString("N2") calls
            return $"{Code,-5}{Name,-20}{Continent,-30}{SurfaceArea,-10:N2}{Population,-15:N0}{GovernmentForm,-30}";
        }
    }
}
