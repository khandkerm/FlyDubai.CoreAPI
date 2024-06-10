namespace FlyDubai.CoreAPI.Models.Requests
{
    public class AncillaryOfferServiceRequest
    {
        public List<FlightService> Flights { get; set; }
    }

    public class FlightService
    {
        public string LfId { get; set; }
        public string FlightNum { get; set; }
        public DateTime DepDate { get; set; }
        public string Origin { get; set; }
        public string Dest { get; set; }
        public string Currency { get; set; }
        public int UTCOffset { get; set; }
        public string OperatingCarrierCode { get; set; }
        public string MarketingCarrierCode { get; set; }
        public string ServiceCode { get; set; }
        public string Channel { get; set; }
    }
}
