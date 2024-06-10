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
    [Route("api/pricing")]
    [Route("api/v{version:apiVersion}/pricing")]
    public class PricingController(ILogger<PricingController> logger, IPricing service, IFlyDubai flyService, IFlyDubaiCache cache, IOptions<AppSettings> appSettings) : ControllerBase
    {
        private readonly ILogger _logger = logger;
        private readonly IPricing _service = service;
        private readonly IFlyDubaiCache _cache = cache;
        private readonly IFlyDubai _flyService = flyService;

        private readonly AppSettings _appSettings = appSettings.Value;
        private readonly DateTimeOffset _options = Helper.Helper.CreateFlyDubaiCacheOptions();

        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost("flightswithfares")]
        [AllowAnonymous]
        [IgnoreAntiforgeryToken]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(FlightsWithFaresResponse))]
        public async Task<IActionResult> Flightswithfares([FromBody] FlightsWithFaresRequest request)
        {
            FlightsWithFaresResponse response = new();

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

                response = await _service.FlightswithfaresAsync(request: request, endpointBaseUrl: _appSettings.EndpointBaseUrl, accessToken: accessTokenResponse.AccessToken);

                return Ok(response);
            }
            catch (System.Exception ex)
            {
                _logger.LogError(ex);
                response.ReturnStatus = StatusCodes.Status500InternalServerError;
                response.ReturnMessage.Add(ex.InnerException != null ? ex.InnerException.Message : ex.Message);
                return StatusCode(StatusCodes.Status500InternalServerError, response);
            }
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost("services")]
        [AllowAnonymous]
        [IgnoreAntiforgeryToken]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(AncillaryOfferServiceResponse))]
        public async Task<IActionResult> AncillaryOfferServices([FromBody] AncillaryOfferServiceRequest request)
        {
            AncillaryOfferServiceResponse response = new();

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

                response = await _service.AncillaryOfferServicesAsync(request: request, endpointBaseUrl: _appSettings.EndpointBaseUrl, accessToken: accessTokenResponse.AccessToken);

                return Ok(response);
            }
            catch (System.Exception ex)
            {
                _logger.LogError(ex);
                response.ReturnStatus = StatusCodes.Status500InternalServerError;
                response.ReturnMessage.Add(ex.InnerException != null ? ex.InnerException.Message : ex.Message);
                return StatusCode(StatusCodes.Status500InternalServerError, response);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost("seats")]
        [AllowAnonymous]
        [IgnoreAntiforgeryToken]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(SeatQuoteResponse))]
        public async Task<IActionResult> SeatOffers([FromBody] SeatQuoteRequest request)
        {
            SeatQuoteResponse response = new();

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

                response = await _service.SeatOffersAsync(request: request, endpointBaseUrl: _appSettings.EndpointBaseUrl, accessToken: accessTokenResponse.AccessToken);

                return Ok(response);
            }
            catch (System.Exception ex)
            {
                _logger.LogError(ex);
                response.ReturnStatus = StatusCodes.Status500InternalServerError;
                response.ReturnMessage.Add(ex.InnerException != null ? ex.InnerException.Message : ex.Message);
                return StatusCode(StatusCodes.Status500InternalServerError, response);
            }
        }
    }
}
