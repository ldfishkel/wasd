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
    
    public partial class PlanMedico
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PlanMedico()
        {
            this.Afiliadoes = new HashSet<Afiliado>();
            this.Bonoes = new HashSet<Bono>();
        }
    
        public int planmedico_id { get; set; }
        public string planmedico_nombre { get; set; }
        public decimal planmedico_cuota { get; set; }
        public decimal planmedico_precio_bono { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Afiliado> Afiliadoes { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Bono> Bonoes { get; set; }

        public override string ToString()
        {
            return planmedico_nombre.Trim();
        }
    }
}
