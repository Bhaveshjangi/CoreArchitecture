using System;
using System.Collections.Generic;
using System.Text;

namespace CoreModels.ViewModels
{
   public class ServiceResult
    {
        public bool Status { get; set; }
        public int StatusCode { get; set; }
        public dynamic ResultData { get; set; }
        public string Message { get; set; }
    }
}
