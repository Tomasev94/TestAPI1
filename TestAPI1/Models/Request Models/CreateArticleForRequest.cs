using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace TestAPI1.Models
{
    public class CreateArticleForRequest
    {
        [JsonPropertyName("title")]
        public string Title { get; set; }

        [JsonPropertyName("description")]
        public string Description { get; set; }

        [JsonPropertyName("body")]
        public string Body { get; set; }

        [JsonPropertyName("tagList")]
        public List<string> TagList { get; set; }
    }
}
