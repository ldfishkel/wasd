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
    using System.Collections.Generic;
    
    public partial class Turno
    {
        public int turno_id { get; set; }
        public int afiliado_id { get; set; }
        public int profesional_id { get; set; }
        public int especialidad_id { get; set; }
        public Nullable<int> turnocancelado_id { get; set; }
        public System.DateTime turno_fecha { get; set; }
        public System.TimeSpan turno_hora { get; set; }
        public bool turno_llego { get; set; }
    
        public virtual Afiliado Afiliado { get; set; }
        public virtual Especialidad Especialidad { get; set; }
        public virtual Profesional Profesional { get; set; }
        public virtual TurnoCancelado TurnoCancelado { get; set; }
    }
}
