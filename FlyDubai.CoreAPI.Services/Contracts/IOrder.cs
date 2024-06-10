using FlyDubai.CoreAPI.Models.Requests;
using FlyDubai.CoreAPI.Models.Responses;

namespace FlyDubai.CoreAPI.Services.Contracts
{
    public interface IOrder
    {
        Task<OrderResponse> AddToCartAsync(OrderRequest request, string endpointBaseUrl, string accessToken);
    }
}
