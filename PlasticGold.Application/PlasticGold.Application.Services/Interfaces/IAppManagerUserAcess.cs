using System.Collections.Generic;
using System.Threading.Tasks;
using PlasticGold.Application.Messages;

namespace PlasticGold.Application.Services.Interfaces
{
    public interface IAppManagerUserAcess
    {
        Task<UserEmailResponse> UserServicesVerification(string emailRequest);

        Task<object> UserServicesAccreditation();

    }
}
