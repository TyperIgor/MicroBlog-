using Npgsql;

namespace PlasticGold.Infra.Data.Context
{
    public interface IDbContext
    {
        NpgsqlConnection GetConnection();
    }
}
