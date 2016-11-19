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
    
    public partial class Afiliado
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Afiliado()
        {
            this.Afiliado1 = new HashSet<Afiliado>();
            this.Bonoes = new HashSet<Bono>();
            this.Bonoes1 = new HashSet<Bono>();
            this.Compras = new HashSet<Compra>();
            this.HistorialPlans = new HashSet<HistorialPlan>();
            this.Turnoes = new HashSet<Turno>();
        }
    
        public int afiliado_id { get; set; }
        public int usuario_id { get; set; }
        public int estadocivil_id { get; set; }
        public string afiliado_tipodocumento { get; set; }
        public int planmedico_id { get; set; }
        public string afiliado_sexo { get; set; }
        public int afiliado_numero { get; set; }
        public string afiliado_nombre { get; set; }
        public string afiliado_apellido { get; set; }
        public int afiliado_numero_documento { get; set; }
        public string afiliado_direccion { get; set; }
        public int afiliado_telefono { get; set; }
        public string afiliado_mail { get; set; }
        public System.DateTime afiliado_fecha_nacimiento { get; set; }
        public byte afiliado_familiares_dependientes { get; set; }
        public bool afiliado_activo { get; set; }
        public Nullable<int> afiliado_grupo_familiar { get; set; }
        public short afiliado_cantidad_bonos_usados { get; set; }
        public Nullable<System.DateTime> afiliado_fecha_baja { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Afiliado> Afiliado1 { get; set; }
        public virtual Afiliado Afiliado2 { get; set; }
        public virtual EstadoCivil EstadoCivil { get; set; }
        public virtual PlanMedico PlanMedico { get; set; }
        public virtual Usuario Usuario { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Bono> Bonoes { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Bono> Bonoes1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Compra> Compras { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HistorialPlan> HistorialPlans { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Turno> Turnoes { get; set; }
        public override string ToString()
        {
            return afiliado_nombre.Trim() + " " + afiliado_apellido.Trim();
        }
    }
}
