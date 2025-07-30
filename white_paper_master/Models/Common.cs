namespace white_paper_master.Models
{
    public class Common
    {
        public class OfficeInfo
        {
            public string OFFICE_CD { get; set; }        // Treat as text
            public int OFFICE_TYPE_CD { get; set; }
            public int DISTRICT_CD { get; set; }
            public int PS_CD { get; set; }
            public string OFFICE_NAME { get; set; }
        }

        public class ApiResponse<T>
        {
            public int StatusCode { get; set; }
            public string Message { get; set; }
            public int? PageNumber { get; set; }
            public int? PageSize { get; set; }
            public int? TotalRecords { get; set; }
            public T Data { get; set; }
        }



    }
}
