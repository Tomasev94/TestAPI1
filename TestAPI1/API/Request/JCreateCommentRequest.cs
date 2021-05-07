using System.Text.Json.Serialization;
using TestAPI1.Models;

namespace TestAPI1.API.Request
{
    public class JCreateCommentRequest
    {
        [JsonPropertyName("comment")]
        public CreateCommentForRequest Comment { get; set; }
    }
}
