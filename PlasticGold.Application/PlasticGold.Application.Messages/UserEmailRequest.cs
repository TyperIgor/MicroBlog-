using System;
using System.Text.Json.Serialization;

namespace PlasticGold.Application.Messages
{
    public class UserEmailRequest
    {
        [JsonPropertyName("email")]
        public string Email { get; set; }
    }
}
