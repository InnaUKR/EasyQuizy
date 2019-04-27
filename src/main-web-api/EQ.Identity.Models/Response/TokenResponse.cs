namespace EQ.Identity.Models.Response
{
    public class TokenResponse : BaseResponse
    {
        public string AccessToken { get; set; }

        public string RefreshToken { get; set; }

        public int ExpiresIn { get; set; }

        public string TokenType { get; set; }
    }
}