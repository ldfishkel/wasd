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
    
    public partial class TurnoCancelado
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TurnoCancelado()
        {
            this.Turnoes = new HashSet<Turno>();
        }
    
        public int turnocancelado_id { get; set; }
        public int turnocancelado_tipocancelacion_id { get; set; }
        public string turnocancelado_descripcion { get; set; }
        public string turnocancelado_cancelado_por { get; set; }
    
        public virtual TipoCancelacion TipoCancelacion { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Turno> Turnoes { get; set; }
    }
}