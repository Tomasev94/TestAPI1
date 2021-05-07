using System.Text.Json.Serialization;
using TestAPI1.Models;

namespace TestAPI1.API.Response
{
    public class JNewCommentResponse
    {
        [JsonPropertyName("comment")]
        public NewCommentForResponse Comment { get; set; }
    }
}
