using System.Text.Json.Serialization;

namespace TestAPI1.Models
{
    public class CreateCommentForRequest
    {
        [JsonPropertyName("body")]
        public string Body { get; set; }
    }
}
