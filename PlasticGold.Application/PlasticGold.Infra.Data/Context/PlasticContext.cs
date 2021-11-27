using Microsoft.EntityFrameworkCore;

namespace PlasticGold.Infra.Data.Context
{
    public class PlasticContext : DbContext
    {
        public PlasticContext(DbContextOptions<PlasticContext> options) : base(options)
        {

        }


    }
}
