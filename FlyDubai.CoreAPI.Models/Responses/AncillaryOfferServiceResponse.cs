namespace FlyDubai.CoreAPI.Models.Responses
{
    public class AncillaryOfferServiceResponse : ResponseBase
    {
        public AncillaryQuotes AncillaryQuotes { get; set; }
        public List<string> Exceptions { get; set; }
    }

    public class AncillaryQuotes
    {
        public List<Flight> Flights { get; set; }
    }

    public class Flight
    {
        public Segment Segments { get; set; }
        public List<Leg> Legs { get; set; }
    }

    public class Segment
    {
        public string LfID { get; set; }
        public DateTime DepDate { get; set; }
        public string Origin { get; set; }
        public string Dest { get; set; }
        public List<ServiceQuote> ServiceQuotes { get; set; }
    }

    public class Leg
    {
        public string LfID { get; set; }
        public string PfID { get; set; }
        public DateTime DepDate { get; set; }
        public string Origin { get; set; }
        public string Dest { get; set; }
        public List<ServiceQuote> ServiceQuotes { get; set; }
    }

    public class ServiceQuote
    {
        public string Code { get; set; }
        public int CategoryID { get; set; }
        public int CutoffHours { get; set; }
        public string Currency { get; set; }
        public string Description { get; set; }
        public decimal Amount { get; set; }
        public int RedeemMiles { get; set; }
        public string RuleID { get; set; }
        public string RuleDesc { get; set; }
        public int MaxCountFlightLevel { get; set; }
        public int MaxCountServiceLevel { get; set; }
        public int Quantity { get; set; }
    }
}
