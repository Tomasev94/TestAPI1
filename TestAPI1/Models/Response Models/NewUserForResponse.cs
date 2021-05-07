using System;
using System.Text.Json.Serialization;

namespace TestAPI1.Models
{
    public class NewUserForResponse
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("email")]
        public string Email { get; set; }

        [JsonPropertyName("createdAt")]
        public DateTime CreatedAt { get; set; }

        [JsonPropertyName("updatedAt")]
        public DateTime UpdatedAt { get; set; }

        [JsonPropertyName("username")]
        public string Username { get; set; }

        [JsonPropertyName("bio")]
        public string Bio { get; set; }

        [JsonPropertyName("image")]
        public object Image { get; set; }

        [JsonPropertyName("token")]
        public string Token { get; set; }
    }
}
