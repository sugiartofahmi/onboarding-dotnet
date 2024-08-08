namespace onboarding_backend.Common.Responses
{
    public class ApiResponse
    {
        public object? Data { get; set; }
        public bool Success { get; set; }

        public string? Message { get; set; }


        public ApiResponse(object? data, bool success = true, string? message = null)
        {
            Success = success;
            Message = message;
            Data = data;
        }

        public ApiResponse(bool success, string? message = null)
        {
            Success = success;
            Message = message;
        }
    }

    public class PaginationMeta
    {
        public int Page { get; set; }
        public int PerPage { get; set; }
        public int TotalItems { get; set; }
        public int TotalPages { get; set; }

        public string NextPageLink { get; set; }
        public string PreviousPageLink { get; set; }
    }

    public class PaginateResponse<T>
    {
        public PaginationMeta? Pagination { get; set; }
        public required List<T> Items { get; set; }
    }

}