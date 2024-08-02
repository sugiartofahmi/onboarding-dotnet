using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace onboarding_backend.Common.Interfaces
{
    public interface IPaginateRequest
    {
        int PerPage { get; set; }
        int Page { get; set; }
    }

    public interface IPaginationMeta
    {
        int Page { get; set; }
        int PerPage { get; set; }
        int Total { get; set; }
        int TotalPages { get; set; }
    }

    public interface IPaginateResponse<T>
    {
        IPaginationMeta? Meta { get; set; }
        IEnumerable<T> Data { get; set; }
    }

    public interface IResponse<T>
    {
        T Data { get; set; }
        IPaginationMeta? Meta { get; set; }
        bool Success { get; set; }

        string? Message { get; set; }
    }
}