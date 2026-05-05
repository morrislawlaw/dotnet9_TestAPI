using System.Text.Json.Serialization;

namespace Anderson_Road.Models
{
    public class ApiResponse<T>
    {
        public int Code { get; set; }
        public string Message { get; set; } = string.Empty;
        public string Datetime { get; set; } = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public T? Data { get; set; }

        // Success responses
        public static ApiResponse<T> Success(T data, string message = "success")
        {
            return new ApiResponse<T>
            {
                Code = 0,
                Message = message,
                Data = data
            };
        }

        public static ApiResponse<object> Success(string message = "success")
        {
            return new ApiResponse<object>
            {
                Code = 0,
                Message = message,
                Data = null
            };
        }

        // Error responses
        public static ApiResponse<object> Error(int code, string message)
        {
            return new ApiResponse<object>
            {
                Code = code,
                Message = message,
                Data = null
            };
        }
    }
}
