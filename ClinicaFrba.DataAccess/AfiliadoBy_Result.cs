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
    
    public partial class AfiliadoBy_Result
    {
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
    }
}
