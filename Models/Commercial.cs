using Nine_Ali.Helpers;


namespace Nine_Ali.Models
{
    public class Commercial
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public CommercialTypes CommercialTypes { get; set; }
        public DemographicTypes DemographicTypes { get; set; }
    }
}
