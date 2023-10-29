namespace TestAppBackend.DTO
{
    public class BaseResponse
    {

        protected Response ResponseResult { get; set; }

        protected class Response
        {
            public string Message { get;  set; }
            public bool Success { get;  set; }
        }


        public BaseResponse(string message, bool success)
        {
            ResponseResult = new Response() { Message = message, Success = success };
      
        }

    }
}
