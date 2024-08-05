using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace onboarding_backend.Dtos.Common
{
    public record ExceptionResponse(HttpStatusCode StatusCode, string Description);
}