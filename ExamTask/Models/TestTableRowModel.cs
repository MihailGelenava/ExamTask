using Newtonsoft.Json;

namespace ExamTask.Models
{
    public class TestTableRowModel
    {
        [JsonProperty("name")]
        public string? Name { get; set; }
        
        [JsonProperty("method")]
        public string? MethodName { get; set; }

        [JsonProperty("status")]
        public string? Status { get; set; }

        [JsonProperty("startTime")]
        public DateTime StartTime { get; set; }

        [JsonProperty("endTime")]
        public DateTime EndTime { get; set; }

        [JsonProperty("duration")]
        public TimeOnly Duration { get; set; }
        
    }
}
