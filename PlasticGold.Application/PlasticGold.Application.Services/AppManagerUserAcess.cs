using System;
using System.Threading.Tasks;
using PlasticGold.Application.Messages;
using PlasticGold.Application.Services.Interfaces;
using PlasticGold.Services.Common.Enum;
using PlasticGold.Services.Interfaces;

namespace PlasticGold.Application.Services
{
    public class AppManagerUserAcess : IAppManagerUserAcess
    {
        private readonly IManagerUserAcess _appManagerUserAcess;  

        public AppManagerUserAcess(IManagerUserAcess appManagerUserAcess)
        {
            _appManagerUserAcess = appManagerUserAcess;
        }

        public Task<object> UserServicesAccreditation()
        {
            throw new NotImplementedException();
        }

        public Task<UserEmailResponse> UserServicesVerification(string emailRequest)
        {
            var userResponse = new UserEmailResponse();
            try
            {
                var result = _appManagerUserAcess.CheckUserExist(emailRequest);

                if (result == true)
                {
                    userResponse.Token = Guid.NewGuid().ToString();
                    return Task.FromResult(userResponse.StatusOfUserOperation(UserStatusEnum.SuccessfullResponse));
                }
                    
                return Task.FromResult(userResponse.StatusOfUserOperation(UserStatusEnum.NotFoundUser));
            }
            catch (Exception e)
            {
                throw e;
                return Task.FromResult(userResponse.StatusOfUserOperation(UserStatusEnum.ErrorOcurred));
            }
        }
    }
}
