using Asp.Versioning;
using FlyDubai.CoreAPI.Helper;
using FlyDubai.CoreAPI.Models.Global;
using FlyDubai.CoreAPI.Models.Requests;
using FlyDubai.CoreAPI.Models.Responses;
using FlyDubai.CoreAPI.Services.Contracts;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;

namespace FlyDubai.CoreAPI.Controllers
{
    /// <summary>
    /// 
    /// </summary>
    /// <param name="logger"></param>
    /// <param name="service"></param>
    /// <param name="flyService"></param>
    /// <param name="cache"></param>
    /// <param name="appSettings"></param>
    [Authorize]
    [ApiController]
    [ApiVersion("1.0")]
    [ValidateAntiForgeryToken]
    [Route("api/cp")]
    [Route("api/v{version:apiVersion}/cp")]
    public class CPController(ILogger<CPController> logger, ICP service, IFlyDubai flyService, IFlyDubaiCache cache, IOptions<AppSettings> appSettings) : ControllerBase
    {
        private readonly ICP _service = service;
        private readonly ILogger _logger = logger;
        private readonly IFlyDubaiCache _cache = cache;
        private readonly IFlyDubai _flyService = flyService;

        private readonly AppSettings _appSettings = appSettings.Value;
        private readonly DateTimeOffset _options = Helper.Helper.CreateCollectoCacheOptions();

        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost("summaryPNR")]
        [AllowAnonymous]
        [IgnoreAntiforgeryToken]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(SummaryPNRResponse))]
        public async Task<IActionResult> SummaryPNR([FromBody] SummaryPNRRequest request)
        {
            SummaryPNRResponse response = new();

            if (request == null)
            {
                response.ReturnStatus = StatusCodes.Status417ExpectationFailed;
                response.ReturnMessage.Add("Parameter value is null.");
                return StatusCode(StatusCodes.Status417ExpectationFailed, response);
            }

            if (string.IsNullOrEmpty(_appSettings.EndpointBaseUrl))
            {
                response.ReturnStatus = StatusCodes.Status417ExpectationFailed;
                response.ReturnMessage.Add("Endpoint Base Url value is null.");
                return StatusCode(StatusCodes.Status417ExpectationFailed, response);
            }
            
            try
            {
                LoginRequest loginRequest = new()
                {
                    ClientId = _appSettings.ClientId,
                    ClientSecret = _appSettings.ClientSecret,
                    Username = _appSettings.Username,
                    Password = _appSettings.Password
                };

                AccessTokenResponse accessTokenResponse = new();

                string key = $"Authenticate~{loginRequest.ClientId}~{loginRequest.ClientSecret}~{loginRequest.Username}~{loginRequest.Password}";
                if (_cache.TryGetValue(key: key, value: out accessTokenResponse) == false)
                {
                    accessTokenResponse = await _flyService.AuthenticateAsync(loginRequest);
                    //Cache
                    _ = _cache.Set(key: key, value: accessTokenResponse, options: _options);
                }

                response = await _service.SummaryPNRAsync(request: request, endpointBaseUrl: _appSettings.EndpointBaseUrl, accessToken: accessTokenResponse.AccessToken); ;
            }
            catch (System.Exception ex)
            {
                _logger.LogError(ex);
                response.ReturnStatus = StatusCodes.Status500InternalServerError;
                response.ReturnMessage.Add(ex.InnerException != null ? ex.InnerException.Message : ex.Message);
                return StatusCode(StatusCodes.Status500InternalServerError, response);
            }

            return Ok(response);
        }
    }

}
