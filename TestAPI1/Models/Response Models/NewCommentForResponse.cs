using System;
using System.Text.Json.Serialization;

namespace TestAPI1.Models
{
    public class NewCommentForResponse
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("createdAt")]
        public DateTime CreatedAt { get; set; }

        [JsonPropertyName("updatedAt")]
        public DateTime UpdatedAt { get; set; }

        [JsonPropertyName("body")]
        public string Body { get; set; }

        [JsonPropertyName("author")]
        public NewAuthorForResponse Author { get; set; }
    }
}
