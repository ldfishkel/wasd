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
    
    public partial class Bono
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Bono()
        {
            this.ConsultaMedicas = new HashSet<ConsultaMedica>();
        }
    
        public int bono_id { get; set; }
        public int planmedico_id { get; set; }
        public int afiliado_id { get; set; }
        public int compra_id { get; set; }
        public Nullable<int> bono_afiliado_usado { get; set; }
    
        public virtual Afiliado Afiliado { get; set; }
        public virtual Afiliado Afiliado1 { get; set; }
        public virtual Compra Compra { get; set; }
        public virtual PlanMedico PlanMedico { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ConsultaMedica> ConsultaMedicas { get; set; }
        public override string ToString()
        {
            return bono_id.ToString();
        }
    }
}
