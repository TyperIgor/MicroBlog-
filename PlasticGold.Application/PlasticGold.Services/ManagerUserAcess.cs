using System.Linq;
using System.Threading.Tasks;
using PlasticGold.Services.Interfaces;
using PlasticGold.Infra.Data.Repository;

namespace PlasticGold.Services
{
    public class ManagerUserAcess :IManagerUserAcess
    {
        private readonly IUserRepository _userRepository;
        public ManagerUserAcess(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public bool CheckUserExist(string email)
        {
            return _userRepository.CheckUserExist(email);
        }

        public object InsertUserAccreditation(string email)
        {
            throw new System.NotImplementedException();
        }
    }
}
