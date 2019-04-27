namespace EQ.Identity.Models.Response
{
    public class BaseResponse
    {
        public bool IsSucceed { get; set; } = true;

        public string ErrorMessage { get; set; }
    }
}