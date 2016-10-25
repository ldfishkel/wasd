namespace ClinicaFrba.DataAccess.DAO
{
    using Configuration;

    public abstract class DaoBase
    {
        protected Entities _ds;

        public DaoBase()
        {
            _ds = new Entities(Config.ConnectionString());
        }
    }
}

namespace ClinicaFrba.DataAccess
{
    using System.Data.Entity;

    public partial class Entities : DbContext
    {
        public Entities(string connectionString)
            : base(connectionString)
        {
        }
    }
}
