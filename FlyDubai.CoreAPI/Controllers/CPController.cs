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
    /// <param name="service"></param>
    /// <param name="logger"></param>
    /// <param name="cache"></param>
    /// <param name="appSettings"></param>

    [Authorize]
    [ApiController]
    [ApiVersion("1.0")]
    [ValidateAntiForgeryToken]
    [Route("api/cp")]
    [Route("api/v{version:apiVersion}/cp")]
    public class CPController(ICP service, ILogger<CPController> logger, FlyDubaiCache cache, IOptions<AppSettings> appSettings) : ControllerBase
    {
        private readonly ILogger _logger = logger;
        private readonly ICP _service = service;
        private readonly IFlyDubaiCache _cache = cache;

        private readonly AppSettings _appSettings = appSettings.Value;
        private readonly DateTimeOffset _options = Helper.Helper.CreateCollectoCacheOptions();

        /// <summary>
        /// 
        /// </summary>
        /// <param name="summaryPNRRequest"></param>
        /// <returns></returns>
        [HttpPost("summaryPNR")]
        public async Task<IActionResult> SummaryPNR([FromBody] SummaryPNRRequest summaryPNRRequest)
        {

            SummaryPNRResponse response = new();
            
            try
            {
                response = await _service.SummaryPNRAsync(summaryPNRRequest);
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
