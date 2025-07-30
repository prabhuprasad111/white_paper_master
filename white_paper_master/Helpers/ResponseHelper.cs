namespace white_paper_master.Helper
{
    public static class ResponseHelper
    {
        /// <summary>
        /// Creates a standardized success response.
        /// </summary>
        public static ApiResponse<T> Success<T>(
            T data,
            string message = "Success",
            int? pageNumber = null,
            int? pageSize = null,
            int? totalRecords = null)
        {
            return new ApiResponse<T>(
                statusCode: 200,
                message: message,
                data: data,
                pageNumber: pageNumber,
                pageSize: pageSize,
                totalRecords: totalRecords
            );
        }

        /// <summary>
        /// Creates a standardized error response.
        /// </summary>
        public static ApiResponse<T> Error<T>(
            string message,
            int statusCode = 400)
        {
            return new ApiResponse<T>(
                statusCode: statusCode,
                message: message,
                data: default
            );
        }

        /// <summary>
        /// Creates a standardized paginated response.
        /// </summary>
        public static ApiResponse<IEnumerable<T>> Paginated<T>(
            IEnumerable<T> data,
            int pageNumber,
            int pageSize,
            int totalRecords,
            string message = "Success")
        {
            return new ApiResponse<IEnumerable<T>>(
                statusCode: 200,
                message: message,
                data: data,
                pageNumber: pageNumber,
                pageSize: pageSize,
                totalRecords: totalRecords
            );
        }
    }
}
