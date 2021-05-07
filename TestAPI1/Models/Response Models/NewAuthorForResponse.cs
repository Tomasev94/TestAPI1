using System.Text.Json.Serialization;

namespace TestAPI1.Models
{
    public class NewAuthorForResponse
    {
        [JsonPropertyName("username")]
        public string Username { get; set; }

        [JsonPropertyName("bio")]
        public object Bio { get; set; }

        [JsonPropertyName("image")]
        public string Image { get; set; }

        [JsonPropertyName("following")]
        public bool Following { get; set; }
    }
}
