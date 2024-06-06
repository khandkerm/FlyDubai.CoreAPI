using Asp.Versioning;
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
    /// <param name="appSettings"></param>
    [Authorize]
    [ApiController]
    [ApiVersion("1.0")]
    [ValidateAntiForgeryToken]
    [Route("api/flydubai")]
    [Route("api/v{version:apiVersion}/flydubai")]
    public class FlyDubaiController(IFlyDubai service, IOptions<AppSettings> appSettings) : ControllerBase
    {
        private readonly IFlyDubai _service = service;
        private readonly AppSettings _appSettings = appSettings.Value;

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        [HttpPost("authenticate")]
        [AllowAnonymous]
        [IgnoreAntiforgeryToken]
        public async Task<IActionResult> Authenticate()
        {
            AccessTokenResponse response = new();

            if (string.IsNullOrEmpty(_appSettings.ClientId) == false)
            {
                response.ReturnStatus = StatusCodes.Status417ExpectationFailed;
                response.ReturnMessage.Add("ClientId is required.");
                return StatusCode(StatusCodes.Status417ExpectationFailed);
            }

            if (string.IsNullOrEmpty(_appSettings.ClientSecret) == false)
            {
                response.ReturnStatus = StatusCodes.Status417ExpectationFailed;
                response.ReturnMessage.Add("ClientSecret is required.");
                return StatusCode(StatusCodes.Status417ExpectationFailed);
            }

            if (string.IsNullOrEmpty(_appSettings.Username) == false)
            {
                response.ReturnStatus = StatusCodes.Status417ExpectationFailed;
                response.ReturnMessage.Add("Username is required.");
                return StatusCode(StatusCodes.Status417ExpectationFailed);
            }

            if (string.IsNullOrEmpty(_appSettings.Password) == false)
            {
                response.ReturnStatus = StatusCodes.Status417ExpectationFailed;
                response.ReturnMessage.Add("Password is required.");
                return StatusCode(StatusCodes.Status417ExpectationFailed);
            }

            LoginRequest loginRequest = new()
            {
                ClientId= _appSettings.ClientId,
                ClientSecret = _appSettings.ClientSecret,
                Username = _appSettings.Username,
                Password = _appSettings.Password
            };

            response = await _service.AuthenticateAsync(loginRequest);

            return Ok(response);
        }
    }
}
