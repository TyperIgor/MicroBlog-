using System.Text.Json.Serialization;
using PlasticGold.Services.Common.Enum;
using PlasticGold.Services.Common.Extension;

namespace PlasticGold.Application.Messages
{
    public class UserEmailResponse
    {
        [JsonPropertyName("userExist")]
        public bool UserExist { get; set; }

        [JsonPropertyName("token")]
        public string Token { get; set; }

        [JsonPropertyName("message")]
        public string StatusMessage { get; set; }

        public UserEmailResponse StatusOfUserOperation(UserStatusEnum userStatusEnum)
        {
            StatusMessage = userStatusEnum.GetDescription();
            return this;
        }
    }
}
