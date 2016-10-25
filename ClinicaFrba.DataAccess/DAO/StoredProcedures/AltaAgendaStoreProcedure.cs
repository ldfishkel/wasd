

namespace ClinicaFrba.DataAccess.DAO.StoredProcedures
{
    using EntityFrameworkExtras.EF6;
    using System.Collections.Generic;
    using System.Data;
    using UserDefinedTypes;

    [StoredProcedure("WASD.AltaAgendaProfesional")]
    public class AltaAgendaStoreProcedure
    {
        [StoredProcedureParameter(SqlDbType.Udt)]
        public List<AgendaParam> valores { get; set; }
    }
}
