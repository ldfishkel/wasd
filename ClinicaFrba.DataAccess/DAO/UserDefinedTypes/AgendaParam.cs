namespace ClinicaFrba.DataAccess.DAO.UserDefinedTypes
{
    using EntityFrameworkExtras.EF6;

    [UserDefinedTableType("WASD.AgendaParam")]
    public class AgendaParam
    {
        [UserDefinedTableTypeColumn(1)]
        public int profesional_id { get; set; }
        [UserDefinedTableTypeColumn(2)]
        public int especialidad_id { get; set; }
        [UserDefinedTableTypeColumn(3)]
        public string agenda_dia { get; set; }
        [UserDefinedTableTypeColumn(4)]
        public int agenda_hora_desde { get; set; }
        [UserDefinedTableTypeColumn(5)]
        public int agenda_hora_hasta { get; set; }
        [UserDefinedTableTypeColumn(6)]
        public System.DateTime agenda_fecha_desde { get; set; }
        [UserDefinedTableTypeColumn(7)]
        public System.DateTime agenda_fecha_hasta { get; set; }

    }
}
