﻿using FlyDubai.CoreAPI.Models.Requests;
using FlyDubai.CoreAPI.Models.Responses;
using FlyDubai.CoreAPI.Services.Contracts;
using Newtonsoft.Json;
using System.Text;

namespace FlyDubai.CoreAPI.Services.Services
{
    public class CPService: ICP
    {
        public async Task<SummaryPNRResponse> SummaryPNRAsync(SummaryPNRRequest request, string endpointBaseUrl, string accessToken)
        {
            try
            {
                var client = new HttpClient();

                var json = JsonConvert.SerializeObject(request);
                var content = new StringContent(content: json, encoding: Encoding.UTF8, mediaType: "application/json");
                var endpointUrl = endpointBaseUrl + "/cp/summaryPNR";
                var httpRequest = new HttpRequestMessage(HttpMethod.Post, endpointUrl)
                {
                    Content = content
                };
                httpRequest.Headers.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", accessToken);

                var response = await client.SendAsync(httpRequest);
                response.EnsureSuccessStatusCode();

                var responseContent = await response.Content.ReadAsStringAsync();
                var result = JsonConvert.DeserializeObject<SummaryPNRResponse>(responseContent);
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
