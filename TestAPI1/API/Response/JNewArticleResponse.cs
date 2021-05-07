using System.Text.Json.Serialization;
using TestAPI1.Models;

namespace TestAPI1.API.Response
{
    public class JNewArticleResponse
    {
        [JsonPropertyName("article")]
        public NewArticleForResponse Article { get; set; }
    }
}
