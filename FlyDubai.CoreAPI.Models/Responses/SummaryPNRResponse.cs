using FlyDubai.CoreAPI.Models.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace FlyDubai.CoreAPI.Models.Responses
{
    public class History
    {
        public int HistoryID { get; set; }
        public string Key { get; set; }
        public int RecordNumber { get; set; }
        public int HistoryType { get; set; }
        public DateTime ActivityDate { get; set; }
        public string Passenger { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Segment { get; set; }
        public string UserIPAddress { get; set; }
        public string Action { get; set; }
        public string UserID { get; set; }
        public int PersonOrgID { get; set; }
        public string Details { get; set; }
        public int ReservationChannelID { get; set; }
    }
    public class Packages
    {
        public string CompanyID { get; set; }
        public string ConfirmationNumber { get; set; }
        public string Description { get; set; }
        public string ReservationNumber { get; set; }
        public string Type { get; set; }

    }
    public class Hotels
    {
        public string CompanyID { get; set; }
        public string ConfirmationNumber { get; set; }
        public string Description { get; set; }
        public string ReservationNumber { get; set; }
        public string Type { get; set; }

    }
    public class Vouchers
    {
        public string Key { get; set; }
        public int VoucherNumber { get; set; }
        public string CurrencyCode { get; set; }
        public string ReasonCode { get; set; }
        public int PersonOrgID { get; set; }
        public string SeriesNum { get; set; }
        public string ConfirmationNumber { get; set; }
        public int RecordNumber { get; set; }
        public int ChargeNumber { get; set; }
        public string Sponsor { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime EffectiveDate { get; set; }
        public DateTime ExpirationDate { get; set; }
        public int OriginalAmount { get; set; }
        public int BalanceAmount { get; set; }
        public string UserId { get; set; }
        public int NonTransferable { get; set; }
        public DateTime BatchProcessStart { get; set; }
        public int BatchProcessExtracted { get; set; }
        public int VoucherType { get; set; }
        public int TripType { get; set; }
        public int IncludeTaxes { get; set; }
        public int IncludePenalty { get; set; }
        public int IncludeSSR { get; set; }
        public int IncludeAuto { get; set; }
        public int IncludeHotel { get; set; }
        public DateTime STimeRestrict { get; set; }
        public DateTime ETimeRestrict { get; set; }
        public int SundayRestrict { get; set; }
        public int MondayRestrict { get; set; }
        public int TuesdayRestrict { get; set; }
        public int WednesdayRestrict { get; set; }
        public int ThursdayRestrict { get; set; }
        public int FridayRestrict { get; set; }
        public int SaturdayRestrict { get; set; }
        public string VoucherNumFull { get; set; }
        public string VoucherPW { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime TravelEffectiveDate { get; set; }
        public DateTime TravelExpirationDate { get; set; }
        public string LogicalFlightsKey { get; set; }
    }
    public class Cars
    {
        public string Classification { get; set; }
        public string CompanyID { get; set; }
        public string ConfirmationNumber { get; set; }
        public string Description { get; set; }
        public string ReservationNumber { get; set; }
    }
    public class ReservationContacts
    {
        public int VendorID { get; set; }
        public string Key { get; set; }
        public int PersonOrgID { get; set; }
        public bool MarketingOptIn { get; set; }
        public string RedressNum { get; set; }
        public string FirstName { get; set; }
        public string KnownTravNum { get; set; }
        public string LastName { get; set; }
        public List<ContactInfos> ContactInfos { get; set; }
        public string MiddleName { get; set; }
        public int Age { get; set; }
        public DateTime DOB { get; set; }
        public string Gender { get; set; }
        public string Title { get; set; }
        public int NationalityLaguageID { get; set; }
        public string RelationType { get; set; }
        public int WBCID { get; set; }
        public int PTCID { get; set; }
        public bool UseInventory { get; set; }
        public string Address { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Postal { get; set; }
        public string Country { get; set; }
        public string Company { get; set; }
        public string Comments { get; set; }
        public string Passport { get; set; }
        public string Nationality { get; set; }
        public string PassportIssueCountry { get; set; }
        public DateTime PassportExpiryDate { get; set; }
        public int ProfileId { get; set; }
        public string NameLineID { get; set; }
        public string NameElementID { get; set; }
        public string NamePositionID { get; set; }
        public string StaffId { get; set; }
        public DateTime StaffDOJ { get; set; }
        public string PriorityCode { get; set; }
        public string ReservationChannel { get; set; }
        public int CancelReasonID { get; set; }
    }
    public class Comments
    {
        public int CommentID { get; set; }
        public string Key { get; set; }
        public DateTime CommentDate { get; set; }
        public string Comment { get; set; }
        public int CommentLength { get; set; }
        public string UserID { get; set; }

    }
    public class CPGInProgressPayments
    {
        public string ResExtPaymentID { get; set; }
        public string EntityID { get; set; }
        public string ExtPaymentSessionID { get; set; }
        public string CreateDate { get; set; }
        public string LastModifiedDate { get; set; }
        public string SystemID { get; set; }
    }
    public class Payments
    {
        public string Key { get; set; }
        public int ReservationPaymentID { get; set; }
        public string CardHolder { get; set; }
        public int PaymentAmount { get; set; }
        public DateTime ExpirationDate { get; set; }
        public string CardNumber { get; set; }
        public string CVCode { get; set; }
        public string Authorizationcode { get; set; }
        public int TerminalID { get; set; }
        public string CurrencyPaid { get; set; }
        public int CheckNumber { get; set; }
        public string Reference { get; set; }
        public string Result { get; set; }
        public string TransactionID { get; set; }
        public string ValueCode { get; set; }
        public int TransactionIndicator { get; set; }
        public string SettlementBatch { get; set; }
        public int AuthorizedAmount { get; set; }
        public int VoucherNumber { get; set; }
        public string FFNumber { get; set; }
        public int Miles { get; set; }
        public string PaymentComment { get; set; }
        public string BaseCurrency { get; set; }
        public int BaseAmount { get; set; }
        public int ExchangeRate { get; set; }
        public DateTime ExchangeRateDate { get; set; }
        public string DocumentReceivedBy { get; set; }
        public DateTime BatchProcessStart { get; set; }
        public int BatchProcessExtracted { get; set; }
        public string TicketCouponNumber { get; set; }
        public DateTime ATCANDateProcessed { get; set; }
        public string TicketType { get; set; }
        public string GcxID { get; set; }
        public string GcxOptOption { get; set; }
        public int GcxExported { get; set; }
        public DateTime GcxExportedDate { get; set; }
        public string OriginalCurrency { get; set; }
        public int OriginalAmount { get; set; }
        public string IATANum { get; set; }
        public string ProcessorID { get; set; }
        public string MerchantID { get; set; }
        public string ProcessorName { get; set; }
        public string OriginalPaymentMethod { get; set; }
        public int TransactionStatus { get; set; }
        public string ResponseMessage { get; set; }
        public string ResponseCode { get; set; }
        public int PersonOrgID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string CompanyName { get; set; }
        public string Address { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Postal { get; set; }
        public string Country { get; set; }
        public string PaymentMethod { get; set; }
        public DateTime DatePaid { get; set; }
        public string UserData { get; set; }
        public string CardVerification { get; set; }
        public int GrossAmtResCurrency { get; set; }
        public int GrossAmtPayCurrency { get; set; }
        public int NetAmtResCurrency { get; set; }
        public int CommissionDeductedResCurrency { get; set; }
        public int CommissionDeductedPayCurrency { get; set; }
        public int RptNetFrmResCurrency { get; set; }
        public int RptCommissionFromResCurrency { get; set; }
        public int RptCommissionFromPayCurrency { get; set; }
        public int TotalRefundResCurrency { get; set; }
        public int TotalRefundRptCurrency { get; set; }
        public int TotalRefundPayCurrency { get; set; }
        public int RedeemedVoucherAmount { get; set; }
        public string UserID { get; set; }
        public int OriginalPaymentID { get; set; }
        public int PaymentReservationChannelID { get; set; }
        public string AncillaryData01 { get; set; }
        public string AncillaryData02 { get; set; }
        public string AncillaryData03 { get; set; }
        public string AncillaryData04 { get; set; }
        public string AncillaryData05 { get; set; }
        public bool AuthenticationByPassed { get; set; }
        public int CostCenter { get; set; }
        public string CorrelationId { get; set; }
        public string ExternalPaymentRefNum { get; set; }
        public int ResExternalPaymentID { get; set; }
        public string VoucherNumberFull { get; set; }
        public string TransactionAirport { get; set; }
        public string TransactionTerminal { get; set; }
        public string DisplayedCurrency { get; set; }
        public int DisplayedAmount { get; set; }
        public int MccInitExchangeRate { get; set; }
        public string DeviceTerminalID { get; set; }
        public string RRNNumber { get; set; }
        public bool CardholderSignatureRequired { get; set; }
        public string FailureReason { get; set; }
        public string PaymentReceiptURL { get; set; }
    }
    public class OAFlightPersons
    {
        public string Key { get; set; }
        public int RecordNumber { get; set; }
        public int PersonOrgID { get; set; }
        public int ResSegStatus { get; set; }
    }
    public class OAFlights
    {
        public string Key { get; set; }
        public int OALogicalFlightID { get; set; }
        public DateTime DepartureDate { get; set; }
        public string Origin { get; set; }
        public string Destination { get; set; }
        public string OperatingCarrier { get; set; }
        public string OperatingFlightNumber { get; set; }
        public DateTime DepartureTime { get; set; }
        public DateTime Arrivaltime { get; set; }
        public List<OAFlightPersons> OAFlightPersons { get; set; }
    }
    public class Bags
    {
        public int BagsId { get; set; }
        public string Key { get; set; }
        public int BagNumber { get; set; }
        public int BagWeight { get; set; }
        public string BagCode { get; set; }
        public int BagChecked { get; set; }
        public int Pet { get; set; }
        public int BagActive { get; set; }
        public int BagTagPrinted { get; set; }
        public int RecordNumber { get; set; }
    }
    public class ReservationPaymentMaps
    {
        public string Key { get; set; }
        public int ReservationPaymentID { get; set; }
        public int AmountApplied { get; set; }
        public int ReservationChargeID { get; set; }
        public DateTime DatePaid { get; set; }
        public int OriginalReferencePaymentID { get; set; }
        public int RefundAmount { get; set; }
        public int PaymentCurrencyAmount { get; set; }
        public string ApprovalCode { get; set; }
        public string SaleCurrency { get; set; }
        public int SaleAmount { get; set; }
    }
    public class Charges
    {
        public string Key { get; set; }
        public string CodeType { get; set; }
        public string RefundType { get; set; }
        public string CurrencyCode { get; set; }
        public string OriginalCurrency { get; set; }
        public int RecordNumber { get; set; }
        public int VoucherNumber { get; set; }
        public DateTime BillDate { get; set; }
        public int TaxID { get; set; }
        public string ChargeComment { get; set; }
        public int Amount { get; set; }
        public int ChargeStatus { get; set; }
        public int IsRefundable { get; set; }
        public int ExchangeRate { get; set; }
        public DateTime ExchangeRateDate { get; set; }
        public int OriginalAmount { get; set; }
        public string Description { get; set; }
        public int StatusReasonID { get; set; }
        public bool IsSSR { get; set; }
        public int PaymentNumber { get; set; }
        public int TaxChargeID { get; set; }
        public int Commission { get; set; }
        public int ResChannelId { get; set; }
        public int OriginalChargeID { get; set; }
        public bool Bundled { get; set; }
        public bool TaxIsRefundable { get; set; }
        public bool TaxIsCommissionable { get; set; }
        public bool ServiceIsRefundable { get; set; }
        public bool ServiceIsCommissionable { get; set; }
        public List<ReservationPaymentMaps> ReservationPaymentMaps {  get; set; }
        public int PenaltyChargeID { get; set; }
        public int PenaltyTypeID { get; set; }
        public int BoardingPassSsrOrder { get; set; }
        public int PhysicalFlightID { get; set; }
        public string ExtPenaltyRule { get; set; }
        public string Discount { get; set; }
        public string TaxCode { get; set; }
        public int BasePoints { get; set; }
        public int TierPoints { get; set; }
        public int BonusPoints { get; set; }
        public int BonusTierPoints { get; set; }
        public int TierBonusMiles { get; set; }
        public int TierBonusTierMiles { get; set; }
        public int PromoRewards { get; set; }
        public int PromoTier { get; set; }
        public string PromoRuleId { get; set; }
        public int MilesActive { get; set; }
        public string SSRStatus { get; set; }
        public bool IsNew { get; set; }
        public bool IsModify { get; set; }
        public string ChargeSequence { get; set; }
        public int PaymentRefStatus { get; set; }
        public string SaleCurrency { get; set; }
        public int SaleAmount { get; set; }
        public string POSAirport { get; set; }
        public int NonRefChargeId { get; set; }
    }
    public class SeatAssignments
    {
        public string Key { get; set; }
        public int PhysicalFlightID { get; set; }
        public DateTime ActualDepartureDate { get; set; }
        public string FlightNumber { get; set; }
        public DateTime ScheduledDeparturetime { get; set; }
        public DateTime ScheduledArrivaltime { get; set; }
        public int BoardingPassNumber { get; set; }
        public string Seat { get; set; }
        public int RowNumber { get; set; }
        public string Gate { get; set; }
        public string OldSeat { get; set; }
        public int OldRowNumber { get; set; }
        public bool Boarded { get; set; }
        public string CheckInAgent { get; set; }
        public DateTime CheckInDate { get; set; }
        public string CouponStatusIndicator { get; set; }
        public string BoardingSequence { get; set; }
        public DateTime LastModifiedDate { get; set; }
        public int BoardingPassPrinted { get; set; }
        public string FrequentFlyerCarrierCode { get; set; }
        public string FrequentFlyerNumber { get; set; }
        public string FrequentFlyerSSRCode { get; set; }
        public string FrequentFlyerMemberTierLevel { get; set; }
        public string FrequentFlyerMemberRating { get; set; }
        public int FrequentFlyerNumberActionTracker { get; set; }
        public int ReservationChannelID { get; set; }
        public int FrequentFlyerInfoReservationChannelID { get; set; }
        public DateTime FrequentFlyerNumberLAstModifiedDate { get; set; }
        public int PaxJourneyID { get; set; }
        public string StaffId { get; set; }
        public DateTime StaffDOJ { get; set; }
        public string PriorityCode { get; set; }
    }
    public class AirlinePersons
    {
        public int Weight { get; set; }
        public string Key { get; set; }
        public int PersonOrgID { get; set; }
        public string FFNum { get; set; }
        public bool PaxActive { get; set; }
        public string FirstName { get; set; }
        public int RecordNumber { get; set; }
        public string LastName { get; set; }
        public int OriginalRecordNumber { get; set; }
        public int Age { get; set; }
        public string ContactInfo { get; set; }
        public DateTime DOB { get; set; }
        public int DropoffID { get; set; }
        public string Gender { get; set; }
        public int PickupID { get; set; }
        public string PickupName { get; set; }
        public string Title { get; set; }
        public int LapChildID { get; set; }
        public int NationalityLaguageID { get; set; }
        public string FareClassCode { get; set; }
        public string RelationType { get; set; }
        public string FareBasisCode { get; set; }
        public int WBCID { get; set; }
        public string WebFareType { get; set; }
        public int PTCID {  get; set; }
        public string FareBasisSched { get; set; }
        public bool UseInventory { get; set; }
        public int FareAmount { get; set; }
        public string Address { get; set; }
        public int ResSegStatus { get; set; }
        public string Address2 { get; set; }
        public int SegSubStatus { get; set; }
        public string City { get; set; }
        public int SelecteeStatus { get; set; }
        public string State { get; set; }
        public bool CheckinStatus { get; set; }
        public string Postal { get; set; }
        public string Cabin { get; set; }
        public string Country { get; set; }
        public string TicketNumber { get; set; }
        public string Company { get; set; }
        public bool HasTickets { get; set; }
        public string Comments { get; set; }
        public int UIDisplayValue { get; set; }
        public string Passport { get; set; }
        public int InterlinedSegment { get; set; }
        public string Nationality { get; set; }
        public string InterlinedCarrierCode { get; set; }
        public string PassportIssueCountry { get; set; }
        public int ManualFare { get; set; }
        public DateTime PassportExpiryDate { get; set; }
        public int InventoryOverbooked { get; set; }
        public int ProfileId { get; set; }
        public string TicketCouponNumber { get; set; }
        public string NameLineID { get; set; }
        public string NVB { get; set; }
        public string NameElementID { get; set; }
        public string NVA { get; set; }
        public string NamePositionID { get; set; }
        public int TicketControl { get; set; }
        public string StaffId { get; set; }
        public string TicketControlOwner { get; set; }
        public DateTime StaffDOJ { get; set; }
        public DateTime TicketControlModifiedDate { get; set; }
        public string PriorityCode { get; set; }
        public string MarketingCode { get; set; }
        public string ReservationChannel { get; set; }
        public bool MarketingOptIn { get; set; }
        public int CancelReasonID { get; set; }
        public int EmergencyContactID { get; set; }
        public int DisclosedEmergencyContact { get; set; }
        public int CappsStatus { get; set; }
        public int ToRecordNumber { get; set; }
        public int FromRecordNumber { get; set; }
        public int ChangeConsent { get; set; }
        public string StoreFrontID { get; set; }
        public string InsuranceConfNum { get; set; }
        public string InsuranceTransID { get; set; }
        public string RedressNum { get; set; }
        public string KnownTravNum { get; set; }
        public bool PrimaryPassenger { get; set; }
        public int NameChangeCount { get; set; }
        public string CrsCode { get; set; }
        public string FareCalcString { get; set; }
        public string Endorsement { get; set; }
        public int FareTypeID { get; set; }
        public string FareCarrier { get; set; }
        public string TicketDesignator { get; set; }
        public List<SeatAssignments> SeatAssignments { get; set; }
        public string SecondaryCRSCode { get; set; }
        public List<Charges> Charges { get; set; }
        public int RecordSubType { get; set; }
        public List<Bags> Bags { get; set; }
        public bool IsNew { get; set; }
        public bool IsModify { get; set; }
        public int TierID { get; set; }
        public string TierName { get; set; }
        public string LastGDSStatus { get; set; }
        public string OperatingRBD { get; set; }
        public string SecondaryRecordLocator { get; set; }
        public string PosOfficeOrCityCode { get; set; }
        public string PosUserIdentificationNumber { get; set; }
        public string PosAirportCode { get; set; }
        public string PosCrsCode { get; set; }
        public string PosUserType { get; set; }
        public string PosIsoCountryCode { get; set; }
        public string PosIsoCurrency { get; set; }
        public string PosDutyCode { get; set; }
        public string PosErspIdNumber { get; set; }
        public string PosPointOfFirstDeparture { get; set; }
        public string POSOffice { get; set; }
        public string PricingKey { get; set; }
    }
    public class Customers
    {
        public string Key { get; set; }
        public List<AirlinePersons> AirlinePersons { get; set; }
    }
    public class PhysicalFlights
    {
        public string Key { get; set; }
        public int RecordNumber { get; set; }
        public string DestinationDefaultTerminal { get; set; }
        public int PhysicalFlightID { get; set; }
        public int LogicalFlightID { get; set; }
        public string CarrierCode { get; set; }
        public string CarrierName { get; set; }
        public string FlightNumber { get; set; }
        public int FlightOrder { get; set; }
        public DateTime DepartureDate { get; set; }
        public string Origin { get; set; }
        public string OriginDefaultTerminal { get; set; }
        public string OriginName { get; set; }
        public string Destination { get; set; }
        public string DestinationName { get; set; }
        public string OriginMetroGroup { get; set; }
        public string DestinationMetroGroup { get; set; }
        public string SellingCarrier { get; set; }
        public string OperatingCarrier { get; set; }
        public string OperatingFlightNumber { get; set; }
        public string SellingFlightNumber { get; set; }
        public DateTime DepartureTime { get; set; }
        public DateTime Arrivaltime { get; set; }
        public int FlightDuration { get; set; }
        public int Trip { get; set; }
        public string Gate { get; set; }
        public int TotalWeight { get; set; }
        public int UIDisplayValue { get; set; }
        public bool Active { get; set; }
        public string FlightStatus { get; set; }
        public List<Customers> Customers { get; set; }
        public string FromTerminal { get; set; }
        public string ToTerminal { get; set; }
        public string AirCraftType { get; set; }
        public string AirCraftDescription { get; set; }
        public bool ReaccomChangeAlert { get; set; }
    }
    public class LogicalFlight
    {
        public string Key { get; set; }
        public string FlightGroupId { get; set; }
        public string FareGroupId { get; set;}
        public int RecordNumber { get; set; }
        public int LogicalFlightID { get; set; }
        public DateTime DepartureDate { get; set; }
        public string Origin { get; set; }
        public string OriginName { get; set; }
        public string OriginDefaultTerminal { get; set; }
        public string Destination { get; set; }
        public string DestinationName { get; set; }
        public string DestinationDefaultTerminal { get; set; }
        public string OriginMetroGroup { get; set; }
        public string DestinationMetroGroup { get; set; }
        public string FlightNumber { get; set; }
        public string SellingCarrier { get; set; }
        public string OperatingCarrier { get; set; }
        public string OperatingFlightNumber { get; set; }
        public string SellingFlightNumber { get; set; }
        public DateTime DepartureTime { get; set; }
        public DateTime Arrivaltime { get; set; }
        public int PackageItemID { get; set; }
        public string PackageItemName { get; set; }
        public string PackageItemDescription { get; set;}
        public DateTime PackageItemBookDate { get; set; }
        public DateTime PackageItemStartDate { get; set; }
        public DateTime PackageItemEndDate { get; set; }
        public int VendorId { get; set; }
        public string VendorName { get; set; }
        public bool Active { get; set; }
        public string VendorDescription { get; set; }
        public int UIDisplayValue { get; set; }
        public List<PhysicalFlights> PhysicalFlights { get; set; }
        public DateTime DepartTimeGMT { get; set; }
    }
    public class Airlines
    {
        public string Key;
        public List<LogicalFlight> LogicalFlight { get; set; }
        public List<OAFlights> OAFlights { get; set; }
    }
    public class SummaryPNRResponse : ResponseBase
    {
        public string Key { get; set; }
        public string SeriesNumber { get; set; }
        public string ConfirmationNumber { get; set; }
        public string BookingAgent { get; set; }
        public string CRSCode { get; set; }
        public int TravelGroupID { get; set; }
        public string IATANumber { get; set; }
        public string ExternalAppID { get; set; }
        public string WebBookingID { get; set; }
        public int PromotionalID { get; set; }
        public string PromotionalCode { get; set; }
        public int RecieptLanguageID { get; set; }
        public string ReservationCurrency { get; set; }
        public string GDSControl { get; set; }
        public string ProfileID { get; set; }
        public int PNRPin { get; set; }
        public DateTime BookDate { get; set; }
        public string ReservationType { get; set; }
        public DateTime TodaysDate { get; set; }
        public DateTime LastModified { get; set; }
        public DateTime ReservationExpirationDate { get; set; }
        public string CorporationID { get; set; }
        public string SecurityGuid { get; set; }
        public bool HasTickets { get; set; }
        public string ValuePackageData { get; set; }
        public string UserIPAddress { get; set; }
        public string ManageBookingAgent { get; set; }
        public string HistoricConfirmationNum { get; set; }
        public string Cabin { get; set; }
        public int ReservationBalance { get; set; }
        public int ChangeFee { get; set; }
        public int LogicalFlightCount { get; set; }
        public int ActivePassengerCount { get; set; }
        public bool BalancedReservation { get; set; }
        public DateTime ReservationFulfillmentRequiredByGMT { get; set; }
        public DateTime ReservationFulfillmentRequiredByODT { get; set; }
        public bool IsInterline { get; set; }
        public bool IsCodeShare { get; set; }
        public string GroupName { get; set; }
        public List<Airlines> Airlines { get; set; }
        public List<Payments> Payments { get; set; }
        public List<CPGInProgressPayments> CPGInProgressPayments { get; set; }
        public List<Comments> Comments { get; set; }
        public List<ReservationContacts> ReservationContacts { get; set; }
        public List<ContactInfos> ContactInfos { get; set; }
        public List<DocumentInfos> DocumentInfos { get; set; }
        public List<Cars> Cars { get; set; }
        public List<Vouchers> Vouchers { get; set; }
        public List<Hotels> Hotels { get; set; }
        public List<Packages> Packages { get; set; }
        public List<Exceptions> Exceptions { get; set; }
        public string StaffCarrierCode { get; set; }
        public bool IsCpgProcess { get; set; }
        public List<History> History { get; set; }
        public List<Bags> Bags { get; set; }
        public int ReservationFulfillmentOverride { get; set; }
    }
}
