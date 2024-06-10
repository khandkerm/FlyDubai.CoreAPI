namespace FlyDubai.CoreAPI.Models.Responses
{
    public class SeatQuoteResponse : ResponseBase
    {
        public SeatQuotes SeatQuotes { get; set; }
        public List<ExceptionDetail> Exceptions { get; set; }
    }

    public class SeatQuotes
    {
        public List<FlightForSeatQuote> Flights { get; set; }
    }

    public class FlightForSeatQuote
    {
        public string PfID { get; set; }
        public DateTime DepDate { get; set; }
        public string Origin { get; set; }
        public string Dest { get; set; }
        public string OriginName { get; set; }
        public string DestName { get; set; }
        public string TailNum { get; set; }
        public string FlightNum { get; set; }
        public bool Circular { get; set; }
        public int LegOrder { get; set; }
        public List<SeatCodeForFlight> SeatCodes { get; set; }
        public List<CabinForFlight> Cabins { get; set; }
    }

    public class SeatCodeForFlight
    {
        public string SeatCode { get; set; }
        public string Desc { get; set; }
    }

    public class CabinForFlight
    {
        public string Cabin { get; set; }
        public List<SeatMap> SeatMaps { get; set; }
    }

    public class SeatMap
    {
        public string RowNumber { get; set; }
        public string SeatMapName { get; set; }
        public bool IsWing { get; set; }
        public bool IsExit { get; set; }
        public List<Seat> Seats { get; set; }
    }

    public class Seat
    {
        public string SeatNumber { get; set; }
        public string ServiceCode { get; set; }
        public decimal Amount { get; set; }
        public string Currency { get; set; }
        public bool Assigned { get; set; }
        public int RedeemMiles { get; set; }
        public string RuleID { get; set; }
        public string RuleDesc { get; set; }
        public bool IsBlocked { get; set; }
        public bool IsPreBlocked { get; set; }
    }

    public class ExceptionDetail
    {
        public string Code { get; set; }
        public string Desc { get; set; }
        public string Source { get; set; }
        public string Level { get; set; }
    }
}
