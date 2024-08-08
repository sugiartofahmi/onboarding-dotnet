using onboarding_backend.Common.Requests;

namespace onboarding_backend.Dtos.Common
{
    public class IndexDto : PaginateRequest
    {
        public int PerPage { get; set; } = 10;

        public int Page { get; set; } = 1;

        public string Search { get; set; } = "";
    }
}