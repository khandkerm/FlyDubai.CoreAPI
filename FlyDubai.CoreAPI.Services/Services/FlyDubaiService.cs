using FlyDubai.CoreAPI.Models.Requests;
using FlyDubai.CoreAPI.Models.Responses;
using FlyDubai.CoreAPI.Services.Contracts;
using Newtonsoft.Json;

namespace FlyDubai.CoreAPI.Services.Services
{
    public class FlyDubaiService : IFlyDubai
    {
        public async Task<AccessTokenResponse> AuthenticateAsync(LoginRequest request)
        {
            try
            {
                var client = new HttpClient();

                var content = new FormUrlEncodedContent(
                [
                    new KeyValuePair<string, string>("client_id", request.ClientId),
                    new KeyValuePair<string, string>("client_secret", request.ClientSecret),
                    new KeyValuePair<string, string>("grant_type", request.GrantType),
                    new KeyValuePair<string, string>("username", request.Username),
                    new KeyValuePair<string, string>("password", request.Password),
                    new KeyValuePair<string, string>("scope", request.Scope)
                ]);

                var response = await client.PostAsync("https://devapi.flydubai.com/res/v3/authenticate", content);
                var responseString = await response.Content.ReadAsStringAsync();

                if (response.IsSuccessStatusCode)
                {
                    var accessTokenResponse = JsonConvert.DeserializeObject<AccessTokenResponse>(responseString);
                    return accessTokenResponse;
                }
                return new AccessTokenResponse();
            }
            catch (System.Exception e)
            {
                throw new System.Exception(e.Message, e);
            }
        }
    }
}
