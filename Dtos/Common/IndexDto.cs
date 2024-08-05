using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using onboarding_backend.Common.Requests;

namespace onboarding_backend.Dtos.Common
{
    public class IndexDto : PaginateRequest
    {
        public int PerPage { get; set; }
        public int Page { get; set; }
        public string Search { get; set; }
    }
}