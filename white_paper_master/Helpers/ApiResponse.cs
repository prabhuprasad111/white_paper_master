namespace white_paper_master.Helper
{
    public class ApiResponse<T>
    {
       
            public int StatusCode { get; set; }
            public string Message { get; set; }
            public int? PageNumber { get; set; }
            public int? PageSize { get; set; }
            public int? TotalRecords { get; set; }
            public T Data { get; set; }

            public ApiResponse(int statusCode, string message, T data,
                               int? pageNumber = null, int? pageSize = null, int? totalRecords = null)
            {
                StatusCode = statusCode;
                Message = message;
                Data = data;
                PageNumber = pageNumber;
                PageSize = pageSize;
                TotalRecords = totalRecords;
            }
        
    }
}
