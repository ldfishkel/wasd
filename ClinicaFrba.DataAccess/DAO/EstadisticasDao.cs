
namespace ClinicaFrba.DataAccess.DAO
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class EstadisticasDao : DaoBase
    {
        public EstadisticasDao() : base()
        {
        }

        public List<SP_ListadoEstadistico1_Result> Consulta1(DateTime fechaDesde, DateTime fechaHasta)
        {
            return _ds.SP_ListadoEstadistico1(fechaDesde, fechaHasta).ToList();
        }
        /*
        public List<SP_ListadoEstadistico2_Result> Consulta2(DateTime fechaDesde, DateTime fechaHasta)
        {
            return _ds.SP_ListadoEstadistico2(fechaDesde, fechaHasta).ToList();
        }

        public List<SP_ListadoEstadistico3_Result> Consulta3(DateTime fechaDesde, DateTime fechaHasta)
        {
            return _ds.SP_ListadoEstadistico3(fechaDesde, fechaHasta).ToList();
        }
        */
        public List<SP_ListadoEstadistico4_Result> Consulta4(DateTime fechaDesde, DateTime fechaHasta)
        {
            return _ds.SP_ListadoEstadistico4(fechaDesde, fechaHasta).ToList();
        }

        public List<SP_ListadoEstadistico5_Result> Consulta5(DateTime fechaDesde, DateTime fechaHasta)
        {
            return _ds.SP_ListadoEstadistico5(fechaDesde, fechaHasta).ToList();
        }
    }
}
