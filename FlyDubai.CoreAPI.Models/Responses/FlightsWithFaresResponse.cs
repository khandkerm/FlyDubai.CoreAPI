namespace FlyDubai.CoreAPI.Models.Responses
{
    public class FlightsWithFaresResponse: ResponseBase
    {
        public RetrieveFareQuoteDateRangeResult RetrieveFareQuoteDateRangeResult { get; set; }
    }

    public class RetrieveFareQuoteDateRangeResult
    {
        public Exceptions Exceptions { get; set; }
        public FlightSegments FlightSegments { get; set; }
        public LegDetails LegDetails { get; set; }
        public SegmentDetails SegmentDetails { get; set; }
        public TaxDetails TaxDetails { get; set; }
        public ServiceDetails ServiceDetails { get; set; }
        public Combinability Combinability { get; set; }
        public string FullInBoundDate { get; set; }
        public string FullOutBoundDate { get; set; }
    }

    public class Exceptions
    {
        public ExceptionInformation ExceptionInformation { get; set; }
    }

    public class ExceptionInformation
    {
        public List<Exception> Exception { get; set; }
    }

    public class Exception
    {
        public int ExceptionCode { get; set; }
        public string ExceptionDescription { get; set; }
        public string ExceptionSource { get; set; }
        public string ExceptionLevel { get; set; }
    }

    public class FlightSegments
    {
        public List<FlightSegment> FlightSegment { get; set; }
    }

    public class FlightSegment
    {
        public int LFID { get; set; }
        public DateTime DepartureDate { get; set; }
        public DateTime ArrivalDate { get; set; }
        public int LegCount { get; set; }
        public bool International { get; set; }
        public FareTypes FareTypes { get; set; }
        public FlightLegDetails FlightLegDetails { get; set; }
    }

    public class FareTypes
    {
        public List<FareType> FareType { get; set; }
    }

    public class FareType
    {
        public int FareTypeID { get; set; }
        public int SolnId { get; set; }
        public string FareTypeName { get; set; }
        public int Changeable { get; set; }
        public int Refundable { get; set; }
        public FareInfos FareInfos { get; set; }
    }

    public class FareInfos
    {
        public List<FareInfo> FareInfo { get; set; }
    }

    public class FareInfo
    {
        public List<Pax> Pax { get; set; }
    }

    public class Pax
    {
        public int ID { get; set; }
        public int FareID { get; set; }
        public int PaxCount { get; set; }
        public string FCCode { get; set; }
        public string FBCode { get; set; }
        public decimal BaseFareAmtNoTaxes { get; set; }
        public decimal BaseFareAmt { get; set; }
        public decimal FareAmtNoTaxes { get; set; }
        public decimal BaseFareAmtInclTax { get; set; }
        public decimal FareAmtInclTax { get; set; }
        public int PTCID { get; set; }
        public string Cabin { get; set; }
        public int SeatsAvailable { get; set; }
        public int InfantSeatsAvailable { get; set; }
        public decimal DisplayFareAmt { get; set; }
        public decimal DisplayTaxSum { get; set; }
        public bool SpecialMarketed { get; set; }
        public int PromotionCatID { get; set; }
        public ApplicableTaxDetails ApplicableTaxDetails { get; set; }
        public AccruedPoints AccruedPoints { get; set; }
        public string RuleId { get; set; }
        public string Hashcode { get; set; }
        public BookingCodes BookingCodes { get; set; }
        public string FareCarrier { get; set; }
        public Penalties Penalties { get; set; }
    }

    public class ApplicableTaxDetails
    {
        public List<ApplicableTaxDetail> ApplicableTaxDetail { get; set; }
    }

    public class ApplicableTaxDetail
    {
        public int TaxID { get; set; }
        public decimal Amt { get; set; }
    }

    public class AccruedPoints
    {
        public string BaseRewardPoints { get; set; }
        public string BonusRewardPoints { get; set; }
        public string BaseTierPoints { get; set; }
        public string BonusTierPoints { get; set; }
        public string TierBonusMiles { get; set; }
        public string TierBonusTierMiles { get; set; }
    }

    public class BookingCodes
    {
        public List<Bookingcode> Bookingcode { get; set; }
    }

    public class Bookingcode
    {
        public string RBD { get; set; }
        public string Cabin { get; set; }
        public int PFID { get; set; }
        public DateTime DepartureDate { get; set; }
    }

    public class Penalties
    {
        public ChangeFees ChangeFees { get; set; }
        public CancellationFees CancellationFees { get; set; }
    }

    public class ChangeFees
    {
        public List<ChangeFee> ChangeFee { get; set; }
    }

    public class ChangeFee
    {
        public bool DateChangeInd { get; set; }
        public string PenaltyType { get; set; }
        public string Percentage { get; set; }
        public string ToTime { get; set; }
        public string FromTime { get; set; }
        public string Type { get; set; }
    }

    public class CancellationFees
    {
        public List<RefundPenalty> RefundPenalty { get; set; }
    }

    public class RefundPenalty
    {
        public string PenaltyType { get; set; }
        public string Percentage { get; set; }
        public string ToTime { get; set; }
        public string FromTime { get; set; }
        public string Type { get; set; }
    }

    public class FlightLegDetails
    {
        public List<FlightLegDetail> FlightLegDetail { get; set; }
    }

    public class FlightLegDetail
    {
        public int PFID { get; set; }
        public DateTime DepartureDate { get; set; }
    }

    public class LegDetails
    {
        public List<LegDetail> LegDetail { get; set; }
    }

    public class LegDetail
    {
        public int PFID { get; set; }
        public DateTime DepartureDate { get; set; }
        public string Origin { get; set; }
        public string Destination { get; set; }
        public string FlightNum { get; set; }
        public bool International { get; set; }
        public DateTime ArrivalDate { get; set; }
        public int FlightTime { get; set; }
        public string OperatingCarrier { get; set; }
        public string MarketingCarrier { get; set; }
        public string MarketingFlightNum { get; set; }
        public string FromTerminal { get; set; }
        public string ToTerminal { get; set; }
        public string EQP { get; set; }
        public string GeneralEQP { get; set; }
    }

    public class SegmentDetails
    {
        public List<SegmentDetail> SegmentDetail { get; set; }
    }

    public class SegmentDetail
    {
        public int LFID { get; set; }
        public string Origin { get; set; }
        public string Destination { get; set; }
        public DateTime DepartureDate { get; set; }
        public string CarrierCode { get; set; }
        public DateTime ArrivalDate { get; set; }
        public int Stops { get; set; }
        public int FlightTime { get; set; }
        public string AircraftType { get; set; }
        public string SellingCarrier { get; set; }
        public string FlightNum { get; set; }
        public string OperatingCarrier { get; set; }
        public string OperatingFlightNum { get; set; }
        public bool FlyMonday { get; set; }
        public bool FlyTuesday { get; set; }
        public bool FlyWednesday { get; set; }
        public bool FlyThursday { get; set; }
        public bool FlyFriday { get; set; }
        public bool FlySaturday { get; set; }
        public bool FlySunday { get; set; }
        public string FlightCorrelationID { get; set; }
    }

    public class TaxDetails
    {
        public List<TaxDetail> TaxDetail { get; set; }
    }

    public class TaxDetail
    {
        public int TaxID { get; set; }
        public string TaxCode { get; set; }
        public string CodeType { get; set; }
        public string TaxDesc { get; set; }
    }

    public class ServiceDetails
    {
        public List<ServiceDetail> ServiceDetail { get; set; }
    }

    public class ServiceDetail
    {
        public int ID { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
    }

    public class Combinability
    {
        public List<string> BS { get; set; }
    }

}
