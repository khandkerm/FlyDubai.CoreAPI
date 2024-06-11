namespace FlyDubai.CoreAPI.Models.Requests
{
    public class FlightsWithFaresRequest
    {
        public RetrieveFareQuoteDateRange RetrieveFareQuoteDateRange { get; set; }
    }

    public class RetrieveFareQuoteDateRange
    {
        public RetrieveFareQuoteDateRangeRequest RetrieveFareQuoteDateRangeRequest { get; set; }
    }

    public class RetrieveFareQuoteDateRangeRequest
    {
        public CarrierCodes CarrierCodes { get; set; }

        public string SecutiryGUID { get; set; } = string.Empty;

        public string ChannelID { get; set; }

        public string CountryCode { get; set; }

        public string ClientIPAddress { get; set; }

        public string HistoricUserName { get; set; }

        public string CurrencyOfFareQuote { get; set; }

        public string IataNumberOfRequestor { get; set; }

        public string FullInBoundDate { get; set; }

        public string FullOutBoundDate { get; set; }

        public int CorporationID { get; set; }

        public string FareFilterMethod { get; set; }

        public string FareGroupMethod { get; set; }

        public string InventoryFilterMethod { get; set; }

        public FareQuoteDetails FareQuoteDetails { get; set; }
    }

    public class CarrierCodes
    {
        public List<CarrierCode> CarrierCode { get; set; }
    }

    public class CarrierCode
    {
        public string AccessibleCarrierCode { get; set; }
    }

    public class FareQuoteDetails
    {
        public List<FareQuoteDetailDateRange> FareQuoteDetailDateRange { get; set; }
    }

    public class FareQuoteDetailDateRange
    {
        public string Origin { get; set; }

        public string Destination { get; set; }

        public bool UseAirportsNotMetroGroups { get; set; }

        public bool UseAirportsNotMetroGroupsAsRule { get; set; }

        public bool UseAirportsNotMetroGroupsForFrom { get; set; }

        public bool UseAirportsNotMetroGroupsForTo { get; set; }

        public DateTime DateOfDepartureStart { get; set; }

        public DateTime DateOfDepartureEnd { get; set; }

        public FareQuoteRequestInfos FareQuoteRequestInfos { get; set; }
    }

    public class FareQuoteRequestInfos
    {
        public List<FareQuoteRequestInfo> FareQuoteRequestInfo { get; set; }
    }

    public class FareQuoteRequestInfo
    {
        public int PassengerTypeID { get; set; }

        public int TotalSeatsRequired { get; set; }
    }
}
