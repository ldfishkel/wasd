namespace ClinicaFrba.DataAccess.DAO
{
    using Configuration;

    public abstract class DaoBase
    {
        private string connectionString;

        public DaoBase()
        {
            connectionString = Config.ConnectionString(ConnectionStringType.Local);
        }

        protected Entities GetDatasource()
        {
            return new Entities(connectionString);
        }

        protected string GetFecha()
        {
            return Utils.FormatDate(Config.SystemDate());
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
