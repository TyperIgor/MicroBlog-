using System.Threading.Tasks;

namespace PlasticGold.Services.Interfaces
{
    public interface IManagerUserAcess
    {
        bool CheckUserExist(string email);

        object InsertUserAccreditation(string email);
    }
}
