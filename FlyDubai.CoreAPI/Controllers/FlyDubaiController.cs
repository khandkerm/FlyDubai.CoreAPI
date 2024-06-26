﻿using Asp.Versioning;
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
    /// <param name="service"></param>
    /// <param name="logger"></param>
    /// <param name="cache"></param>
    /// <param name="appSettings"></param>
    [Authorize]
    [ApiController]
    [ApiVersion("1.0")]
    [ValidateAntiForgeryToken]
    [Route("api/flydubai")]
    [Route("api/v{version:apiVersion}/flydubai")]
    public class FlyDubaiController(IFlyDubai service, ILogger<FlyDubaiController> logger, IFlyDubaiCache cache, IOptions<AppSettings> appSettings) : ControllerBase
    {
        private readonly ILogger _logger = logger;
        private readonly IFlyDubai _service = service;
        private readonly IFlyDubaiCache _cache = cache;

        private readonly AppSettings _appSettings = appSettings.Value;
        private readonly DateTimeOffset _options = Helper.Helper.CreateFlyDubaiCacheOptions();


        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        [HttpPost("authenticate")]
        [AllowAnonymous, IgnoreAntiforgeryToken]
        public async Task<IActionResult> Authenticate()
        {
            AccessTokenResponse response = new();

            if (string.IsNullOrEmpty(_appSettings.ClientId))
            {
                response.ReturnStatus = StatusCodes.Status417ExpectationFailed;
                response.ReturnMessage.Add("ClientId is required.");
                return StatusCode(StatusCodes.Status417ExpectationFailed, response);
            }

            if (string.IsNullOrEmpty(_appSettings.ClientSecret))
            {
                response.ReturnStatus = StatusCodes.Status417ExpectationFailed;
                response.ReturnMessage.Add("ClientSecret is required.");
                return StatusCode(StatusCodes.Status417ExpectationFailed, response);
            }

            if (string.IsNullOrEmpty(_appSettings.Username))
            {
                response.ReturnStatus = StatusCodes.Status417ExpectationFailed;
                response.ReturnMessage.Add("Username is required.");
                return StatusCode(StatusCodes.Status417ExpectationFailed, response);
            }

            if (string.IsNullOrEmpty(_appSettings.Password))
            {
                response.ReturnStatus = StatusCodes.Status417ExpectationFailed;
                response.ReturnMessage.Add("Password is required.");
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

                string key = $"Authenticate~{loginRequest.ClientId}~{loginRequest.ClientSecret}~{loginRequest.Username}~{loginRequest.Password}";
                if (_cache.TryGetValue(key: key, value: out response) == false)
                {
                    response = await _service.AuthenticateAsync(loginRequest);
                    //Cache
                    _ = _cache.Set(key: key, value: response, options: _options);
                }
                    
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
