using Newtonsoft.Json;

namespace LeaveSystem.Models
{
    public class ApiResponse
    {
        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("statusCode")]
        public long StatusCode { get; set; }

        public ApiResponse(string Message, int statusCode)
        {
            this.Message = Message;
            this.StatusCode = statusCode;
        }
    }

    public class ServiceResponse<T>
    {
        public ServiceResponse(long StatusCode, string Message, T Data)
        {
            this.Message = Message;
            this.StatusCode = StatusCode;
            this.Data = Data;
        }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("statusCode")]
        public long StatusCode { get; set; }

        [JsonProperty("data")]
        public T Data { get; set; }
    }

}
