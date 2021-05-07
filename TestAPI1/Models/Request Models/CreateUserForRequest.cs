using System.Text.Json.Serialization;

namespace TestAPI1.Models
{
    public class CreateUserForRequest
    {

        [JsonPropertyName("username")]
        public string Username { get; set; }

        [JsonPropertyName("email")]
        public string Email { get; set; }

        [JsonPropertyName("password")]
        public string Password { get; set; }
    }
}
