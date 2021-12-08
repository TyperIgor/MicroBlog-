using PlasticGold.Infra.Data.Context;
using Npgsql;
using System;
using System.Data;

namespace PlasticGold.Infra.Data.Repository
{
    public abstract class Repository : IRepository, IDisposable
    {
        protected readonly NpgsqlConnection _npgsqlConnection;
        private IDbTransaction _dbTransaction;

        public Repository(IDbContext dbContext)
        {
            _npgsqlConnection = dbContext.GetConnection();
        }

        public void BeginTransaction()
        {
            _dbTransaction = _npgsqlConnection.BeginTransaction();
        }

        public void Commit()
        {
            if (_dbTransaction != null)
            {
                _dbTransaction.Commit();
                _dbTransaction.Dispose();

                _npgsqlConnection.Close();
            }
        }

        public void Dispose()
        {
            _dbTransaction?.Dispose();
            _npgsqlConnection.Dispose();
        }

        public void Rollback()
        {
            if (_dbTransaction != null)
            {
                _dbTransaction.Rollback();
                _dbTransaction.Dispose();

                _npgsqlConnection.Close();
            }
        }
    }
}
