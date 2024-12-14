namespace MIS331_07.Models
{
    public class PriceList
    {
        public int          Id              { get; set; }
        public DateTime     Date            { get; set; }
        public string       Item            { get; set; }
        public string       UOM             { get; set; }
        public Double       Amount          { get; set; }
        public string       Brand           { get; set; }
        public Double       OriginalPrice   { get; set; }
        public Double       Discount        { get; set; }
        public Double       ExtendedPrice   { get; set; }


    }
}
