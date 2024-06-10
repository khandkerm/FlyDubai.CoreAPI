using FlyDubai.CoreAPI.Models.Requests;
using FlyDubai.CoreAPI.Models.Responses;

namespace FlyDubai.CoreAPI.Services.Contracts
{
    public interface ICP
    {
        Task<SummaryPNRResponse> SummaryPNRAsync(SummaryPNRRequest request, string endpointBaseUrl, string accessToken);
    }
}
