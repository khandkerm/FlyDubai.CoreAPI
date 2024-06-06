using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyDubai.CoreAPI.Models.Responses
{
    public abstract class ResponseBase
    {
        protected ResponseBase()
        {
            ReturnMessage = [];
        }
        public int ReturnStatus { get; set; }

        public List<string> ReturnMessage { get; set; }
    }
}
