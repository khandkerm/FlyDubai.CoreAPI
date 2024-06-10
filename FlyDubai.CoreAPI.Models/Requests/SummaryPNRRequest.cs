using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyDubai.CoreAPI.Models.Requests
{
    public class Seats
    {
        public int PersonOrgID { get; set; }
        public int LogicalFlightID { get; set; }
        public int PhysicalFlightID { get; set; }
        public DateTime DepartureDate { get; set; }
        public string SeatSelected { get; set; }
        public string RowNumber { get; set; }
    }
    public class SpecialServices
    {
        public string CodeType { get; set; }
        public int ServiceID { get; set; }
        public int SSRCategory { get; set; }
        public int LogicalFlightID { get; set; }
        public DateTime DepartureDate { get; set; }
        public int Amount { get; set; }
        public bool OverrideAmount { get; set; }
        public string CurrencyCode { get; set; }
        public bool Commissionable { get; set; }
        public bool Refundable { get; set; }
        public string ChargeComment { get; set; }
        public int PersonOrgID { get; set; }
        public int PhysicalFlightID { get; set; }
        public string OverrideAmtReason { get; set; }
        public string ExtPenaltyRule { get; set; }
        public string ExtIsRePriceFixed { get; set; }
        public string ExtRePriceSourceName { get; set; }
        public string ExtRePriceValue { get; set; }
        public string ExtRePriceValueReason { get; set; }
        public string SSRStatus { get; set; }
        public int NREFChargeId { get; set; }
        public string Parameter1Name { get; set; }
        public string Parameter1Value { get; set; }
        public string Parameter2Name { get; set; }
        public string Parameter2Value { get; set; }
        public string Parameter3Name { get; set; }
        public string Parameter3Value { get; set; }
        public string Parameter4Name { get; set; }
        public string Parameter4Value { get; set; }
        public string Parameter5Name { get; set; }
        public string Parameter5Value { get; set; }

    }
    public class Segments
    {
        public int PersonOrgID { get; set; }
        public int FareInformationID { get; set; }
        public string MarketingCode { get; set; }
        public string StoreFrontID { get; set; }
        public string RecordLocator { get; set; }
        public List<SpecialServices> SpecialServices { get; set; }
        public List<Seats> Seats { get; set; }
        public string StaffId { get; set; }
        public DateTime StaffDOJ {  get; set; }
        public string PriorityCode { get; set; }
        public string StaffCarrierCode { get; set; }
    }
    public class ContactInfos
    {
        public int ContactID { get; set; }
        public int PersonOrgID { get; set; }
        public string ContactField { get; set; }
        public string ContactType { get; set; }
        public string Extension { get; set; }
        public string CountryCode { get; set; }
        public string AreaCode { get; set; }
        public string PhoneNumber { get; set; }
        public bool PreferredContactMethod { get; set; }
        public bool ValidatedContact { get; set; }
        public int PreferenceId { get; set; }
    }
    public class DocumentInfos
    {
        public string DocType { get; set; }
        public string DocNumber { get; set; }
        public string ExpiryDate { get; set; }
        public string IssueDate { get; set; }
        public string IssuingCountry { get; set; }
    }
    public class Passengers
    {
        public int PersonOrgID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MiddleName { get; set; }
        public int Age { get; set; }
        public DateTime DOB { get; set; }
        public string Gender { get; set; }
        public string Title { get; set; }
        public int NationalityLaguageID { get; set; }
        public string RelationType { get; set; }
        public int WBCID { get; set; }
        public int PTCID { get; set; }
        public string PTC { get; set; }
        public int TravelsWithPersonOrgID { get; set; }
        public string RedressNumber { get; set; }
        public string KnownTravelerNumber { get; set; }
        public bool MarketingOptIn { get; set; }
        public bool UseInventory { get; set; }
        public Address Address { get; set; }
        public string Company { get; set; }
        public string Comments { get; set; }
        public string Passport { get; set; }
        public string Nationality { get; set; }
        public int ProfileId { get; set; }
        public bool IsPrimaryPassenger { get; set; }
        public List<DocumentInfos> DocumentInfos { get; set; }
        public List<ContactInfos> ContactInfos { get; set; }
        public string FrequentFlyerNumber { get; set; }
        public string Suffix { get; set; }
        public string TierName { get; set; }
        public string PassportIssueCountry { get; set; }
        public DateTime PassportExpiryDate { get; set; }
    }
    public class Address
    {
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Postal { get; set; }
        public string Country { get; set; }
        public string CountryCode { get; set; }
        public string AreaCode { get; set; }
        public string PhoneNumber { get; set; }
        public string Display { get; set; }
    }
    public class ReservationInfo
    {
        public string SeriesNumber { get; set; }
        public string ConfirmationNumber { get; set; }
    }
    public class SummaryPNRRequest
    {
        public string SecurityGUID { get; set; }
        public string ActionType { get; set; }
        public List<CarrierCodes> CarrierCodes { get; set; }
        public ReservationInfo ReservationInfo { get; set; }
        public string ClientIPAddress { get; set; }
        public string SecurityToken { get; set; }
        public string HistoricUserName { get; set; }
        public string CarrierCurrency { get; set; }
        public string ChannelType { get; set; }
        public string DisplayCurrency { get; set; }
        public string Office { get; set; }
        public string IATANum { get; set; }
        public string User { get; set; }
        public string ReceiptLanguageID { get; set; }
        public string PromoCode { get; set; }
        public string SeriesNumber { get; set; }
        public string ExternalBookingID { get; set; }
        public string ConfirmationNumber { get; set; }
        public Address Address { get; set; }
        public int LocationID { get; set; }
        public List<ContactInfos> ContactInfos { get; set; }
        public List<Passengers> Passengers { get; set; }
        public List<Segments> Segments { get; set; }
        public string Comment { get; set; }
        public string StaffCarrierCode { get; set; }
    }
}
