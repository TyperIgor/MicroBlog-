using Microsoft.Extensions.Configuration;
using Npgsql;
using System.Data;

namespace PlasticGold.Infra.Data.Context
{
    public class DbContext : IDbContext
    {
        private readonly IConfiguration _configuration;
        private NpgsqlConnection _npsqlConnection;
        public DbContext(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public NpgsqlConnection GetConnection()
        {
            if (_npsqlConnection == null || _npsqlConnection.State == ConnectionState.Closed)
                return CreateConnection();

            return _npsqlConnection;
        }

        public NpgsqlConnection CreateConnection()
        {
            _npsqlConnection = new NpgsqlConnection(_configuration.GetConnectionString("EqualityDb"));
            _npsqlConnection.Open();
            return _npsqlConnection;
        }
    }
}
