using System.Net;

namespace onboarding_backend.Dtos.Common
{
    public record ExceptionResponse(HttpStatusCode StatusCode, string Description);
}