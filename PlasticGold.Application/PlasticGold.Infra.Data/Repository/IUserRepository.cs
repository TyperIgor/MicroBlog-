using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using PlasticGold.Services.Common.Enum;

namespace PlasticGold.Infra.Data.Repository
{
    public interface IUserRepository
    {
        bool CheckUserExist(string email);

        Task<string> GetByLogin(string email);

        Task<object> InsertAccreditationUserInDatabase(string name, string LastName, string contactPhone, string Address, string neighboor, string number, string? complement);

    }
}
