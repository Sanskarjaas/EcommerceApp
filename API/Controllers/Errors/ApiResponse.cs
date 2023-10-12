using SQLitePCL;

namespace API.Errors
{
    public class ApiResponse
    {
        public int StatusCode { get; set; }
        public string Message { get; set; }
        public ApiResponse(int statuscode, string message = null)
        {
            StatusCode = statuscode;
            Message = message ?? GetDefaultMessageForStatusCode(statuscode);
        }
        private string GetDefaultMessageForStatusCode(int statusCode)
        {
            return statusCode switch
            {
                400 =>"A bad request,you have made",
                401=>"Authorized ,you are not",
                404=>"Resorce found,it was not",
                500=>"Internal Server Server",
                _ =>null
            };
        }
    }
}