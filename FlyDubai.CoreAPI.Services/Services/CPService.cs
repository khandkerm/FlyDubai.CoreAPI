using FlyDubai.CoreAPI.Models.Requests;
using FlyDubai.CoreAPI.Models.Responses;
using FlyDubai.CoreAPI.Services.Contracts;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyDubai.CoreAPI.Services.Services
{
    public class CPService: ICP
    {
        public Task<SummaryPNRResponse> SummaryPNRAsync(SummaryPNRRequest)
        {
            try
            {
                var client = new HttpClient();


            }
            catch (System.Exception ex)
            {

            }
            
        }
    }
}
