namespace API.Errors
{
    public class ApiException : ApiResponse
    {
        public ApiException(int statusCode, string responseMessage = null, string exceptionDetails = null)
            : base(statusCode, responseMessage)
        {
            ExceptionDetails = exceptionDetails;
        }

        public string ExceptionDetails { get; set; }
    }
}