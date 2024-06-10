using FlyDubai.CoreAPI.Models.Requests;
using FlyDubai.CoreAPI.Models.Responses;

namespace FlyDubai.CoreAPI.Services.Contracts
{
    public interface IPricing
    {
        Task<FlightsWithFaresResponse> FlightswithfaresAsync(FlightsWithFaresRequest request, string endpointBaseUrl, string accessToken);
        Task<AncillaryOfferServiceResponse> AncillaryOfferServicesAsync(AncillaryOfferServiceRequest request, string endpointBaseUrl, string accessToken);
        Task<SeatQuoteResponse> SeatOffersAsync(SeatQuoteRequest request, string endpointBaseUrl, string accessToken);
    }
}
