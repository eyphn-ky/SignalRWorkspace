using System.Text.Json.Serialization;

namespace SignalRWorkspace.Dtos
{
    public class MessageDto
    {
        [JsonPropertyName("message")]
        public string Message { get; set; }
    }
}
