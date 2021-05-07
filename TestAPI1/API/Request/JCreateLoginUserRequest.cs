using System.Text.Json.Serialization;
using TestAPI1.Models;

namespace TestAPI1.API.Request
{
    public class JCreateLoginUserRequest
    {
        [JsonPropertyName("user")]
        public CreateUserForRequest createUser { get; set; }
    }
}
