using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Errors
{
    public class ApiResponse
    {
        public ApiResponse(int statusCode, string responseMessage = null)
        {
            StatusCode = statusCode;
            ResponseMessage = responseMessage ?? GetDefaultResponseForStatus(statusCode);
        }

        public int StatusCode { get; set; }

        public string ResponseMessage { get; set; }

        
        private string GetDefaultResponseForStatus(int statusCode)
        {
            return statusCode switch
            {
                400 => "A bad request you have made",
                402 => "Authorized you are not",
                404 or 0 => "Resource found, it was not",
                500 => "Errors are the path to the dark side. Errors lead to anger. Anger leads to hate. Hate leads to career change",
                _ => string.Empty
            };
        }
    }
}