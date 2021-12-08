using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PlasticGold.Infra.Data.Repository
{
    public interface IRepository
    {
        void Commit();
        void BeginTransaction();
        void Rollback();

    }
}
