using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Errors
{
    public class ApiResponse
    {
        public ApiResponse(int StatusCode, string Message = null)
        {
            this.StatusCode = StatusCode;
            this.Message = Message ?? GetDefauktMessageForStatusCode(StatusCode);
        }

        public int StatusCode { get; set; }
        public string Message { get; set; }
        

        private string GetDefauktMessageForStatusCode(int statusCode)
        {
            return statusCode switch 
            {
                400 => "A bad request.",
                401 => "Unauthorized.",
                404 => "Resource not found.",
                500 => "Error.",
                _ => null
            };
        }
    }
}