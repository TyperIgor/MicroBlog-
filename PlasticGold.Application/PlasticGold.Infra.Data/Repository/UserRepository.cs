using Dapper;
using PlasticGold.Infra.Data.Context;
using PlasticGold.Infra.Data.Query;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace PlasticGold.Infra.Data.Repository
{
    public class UserRepository : Repository, IUserRepository
    {
        public UserRepository(IDbContext dbContext) : base(dbContext) { }

        public bool CheckUserExist(string email)
        {
            var parametersToQuery = new DynamicParameters();
            parametersToQuery.Add("@email", email);

            var sql = "select * from \"UserData\" where \"Email\" = @email";

            var result = _npgsqlConnection.Query(sql, parametersToQuery);

            return result.Any() ? true : false;
        }

        public async Task<string> GetByLogin(string email)
        {
            var parametersToQuery = new DynamicParameters();
            parametersToQuery.Add("@email", email);

            var sql = UserQuery.UserExistQuery;

            var result = await _npgsqlConnection.ExecuteReaderAsync(sql, parametersToQuery);

            if (result != null)
            {
                var token = Guid.NewGuid().ToString();
                return token;
            }

            return null;
        }

        public Task<object> InsertAccreditationUserInDatabase(string name, string LastName, string contactPhone, string Address, string neighboor, string number, string complement)
        {
            throw new NotImplementedException();
        }
        

    }
}
