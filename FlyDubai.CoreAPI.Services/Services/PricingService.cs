using FlyDubai.CoreAPI.Models.Requests;
using FlyDubai.CoreAPI.Models.Responses;
using FlyDubai.CoreAPI.Services.Contracts;
using Newtonsoft.Json;
using System.Text;

namespace FlyDubai.CoreAPI.Services.Services
{
    public class PricingService: IPricing
    {
        public async Task<FlightsWithFaresResponse> FlightswithfaresAsync(FlightsWithFaresRequest request, string endpointBaseUrl, string accessToken)
        {
            try
            {
                var client = new HttpClient()
                {
                    Timeout = TimeSpan.FromMinutes(5) 
                }; 

                var json = JsonConvert.SerializeObject(request);
                var content = new StringContent(content: json, encoding: Encoding.UTF8, mediaType: "application/json");
                var endpointUrl = endpointBaseUrl + "/pricing/flightswithfares";
                var httpRequest = new HttpRequestMessage(HttpMethod.Post, endpointUrl)
                {
                    Content = content
                };
                httpRequest.Headers.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", accessToken);

                var response = await client.SendAsync(httpRequest);
                response.EnsureSuccessStatusCode();

                var responseContent = await response.Content.ReadAsStringAsync();
                var result = JsonConvert.DeserializeObject<FlightsWithFaresResponse>(responseContent);
                return result;
            }
            catch (HttpRequestException httpEx)
            {
                throw new System.Exception(httpEx.Message, httpEx);
            }
            catch (System.Exception ex)
            {
                throw new System.Exception(ex.Message, ex);
            }
        }

        public async Task<AncillaryOfferServiceResponse> AncillaryOfferServicesAsync(AncillaryOfferServiceRequest request, string endpointBaseUrl, string accessToken)
        {
            try
            {
                var client = new HttpClient();

                var json = JsonConvert.SerializeObject(request);
                var content = new StringContent(content: json, encoding: Encoding.UTF8, mediaType: "application/json");
                var endpointUrl = endpointBaseUrl + "/pricing/services";
                var httpRequest = new HttpRequestMessage(HttpMethod.Post, endpointUrl)
                {
                    Content = content
                };
                httpRequest.Headers.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", accessToken);

                var response = await client.SendAsync(httpRequest);
                response.EnsureSuccessStatusCode();

                var responseContent = await response.Content.ReadAsStringAsync();
                var result = JsonConvert.DeserializeObject<AncillaryOfferServiceResponse>(responseContent);
                return result;
            }
            catch (HttpRequestException httpEx)
            {
                throw new System.Exception(httpEx.Message, httpEx);
            }
            catch (System.Exception ex)
            {
                throw new System.Exception(ex.Message, ex);
            }
        }

        public async Task<SeatQuoteResponse> SeatOffersAsync(SeatQuoteRequest request, string endpointBaseUrl, string accessToken)
        {
            try
            {
                var client = new HttpClient();

                var json = JsonConvert.SerializeObject(request);
                var content = new StringContent(content: json, encoding: Encoding.UTF8, mediaType: "application/json");
                var endpointUrl = endpointBaseUrl + "/pricing/seats";
                var httpRequest = new HttpRequestMessage(HttpMethod.Post, endpointUrl)
                {
                    Content = content
                };
                httpRequest.Headers.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", accessToken);

                var response = await client.SendAsync(httpRequest);
                response.EnsureSuccessStatusCode();

                var responseContent = await response.Content.ReadAsStringAsync();
                var result = JsonConvert.DeserializeObject<SeatQuoteResponse>(responseContent);
                return result;
            }
            catch (HttpRequestException httpEx)
            {
                throw new System.Exception(httpEx.Message, httpEx);
            }
            catch (System.Exception ex)
            {
                throw new System.Exception(ex.Message, ex);
            }
        }
    }
}
