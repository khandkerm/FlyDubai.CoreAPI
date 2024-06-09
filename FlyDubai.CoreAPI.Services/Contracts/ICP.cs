using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlyDubai.CoreAPI.Models.Requests;
using FlyDubai.CoreAPI.Models.Responses;

namespace FlyDubai.CoreAPI.Services.Contracts
{
    public interface ICP
    {
        Task<SummaryPNRResponse> SummaryPNRAsync(SummaryPNRRequest summaryPNRRequest);
    }
}
