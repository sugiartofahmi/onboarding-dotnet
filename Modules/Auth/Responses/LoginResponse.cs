namespace onboarding_backend.Modules.Auth.Responses
{
    public class LoginResponse
    {
        public string Email { get; set; } = string.Empty;
        public string Avatar { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
        public string Token { get; set; } = string.Empty;
    }
}
