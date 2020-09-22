using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.ServiceModel
{
    public class BaseResponse<T>
    {
        public int StatusCode { get; set; }
        public string ErrorDescription { get; set; } = "";
        public string UserMesssage { get; set; } = "";
        public string UserMessageTitle { get; set; } = "";
        public int TotalCount { get; set; }
        public T Result { get; set; }
        public bool IsSuccess { get; set; }
    }
}
