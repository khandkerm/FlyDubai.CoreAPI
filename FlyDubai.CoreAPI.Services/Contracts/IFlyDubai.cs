using FlyDubai.CoreAPI.Models.Requests;
using FlyDubai.CoreAPI.Models.Responses;

namespace FlyDubai.CoreAPI.Services.Contracts
{
    public interface IFlyDubai
    {
        Task<AccessTokenResponse> AuthenticateAsync(LoginRequest loginRequest);
    }
}
