namespace WorldGeography.Models
{
    public class Language
    {
        public string Name { get; set; }
        public bool IsOfficial { get; set; }
        public int Percentage { get; set; }
        public string CountryCode { get; set; }

        public override string ToString()
        {
            string official = (IsOfficial ? "Official" : "Unofficial");

            return $"{Name,-30}{CountryCode,-5}{official,-15}{Percentage / 100.00,-5:P}"; // :P is percent formatting
        }
    }
}
