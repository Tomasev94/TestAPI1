using System.Text.Json.Serialization;
using TestAPI1.Models;

namespace TestAPI1.API.Request
{
    public class JCreateArticleRequest
    {
        [JsonPropertyName("article")]
        public CreateArticleForRequest Article { get; set; }
    }
}
