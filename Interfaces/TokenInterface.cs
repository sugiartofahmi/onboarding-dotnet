
namespace onboarding_backend.Interfaces
{
    public interface IToken
    {
        public string AccessToken { get; set; }
        public string RefreshToken { get; set; }
    }
}