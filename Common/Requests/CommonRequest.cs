using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace onboarding_backend.Common.Requests
{

    public class PaginateRequest
    {
        public int PerPage { get; set; } = 10;
        public int Page { get; set; } = 1;
        public string Search { get; set; } = "";
    }
}