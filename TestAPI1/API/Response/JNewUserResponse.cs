using System.Text.Json.Serialization;
using TestAPI1.Models;

namespace TestAPI1.API.Response
{
    public class JNewUserResponse
    {
        [JsonPropertyName("user")]
        public NewUserForResponse User { get; set; }
    }
}
