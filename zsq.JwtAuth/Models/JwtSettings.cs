namespace zsq.JwtAuth.Models
{
    public class JwtSettings
    {
        public string Issuer { get; set; }

        public string Audience { get; set; }

        //HmacSha256加密：要求密码必须大于16位
        public string SecretKey { get; set; }
    }
}