using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace onboarding_backend.Common.Requests
{

    public class PaginateRequest
    {
        public int PerPage { get; set; }
        public int Page { get; set; }
    }
}