//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ClinicaFrba.DataAccess
{
    using System;
    
    public partial class TurnosProfesionalEspecialidad_Result
    {
        public int turno_id { get; set; }
        public Nullable<int> turnocancelado_id { get; set; }
        public System.TimeSpan turno_hora { get; set; }
        public bool turno_llego { get; set; }
        public string afiliado_nombre { get; set; }
        public string afiliado_apellido { get; set; }
        public int afiliado_numero { get; set; }
        public string especialidad_nombre { get; set; }
        public string profesional_nombre { get; set; }
        public string profesional_apellido { get; set; }
    }
}
