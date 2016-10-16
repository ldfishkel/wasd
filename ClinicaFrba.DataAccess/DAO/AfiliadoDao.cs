namespace ClinicaFrba.DataAccess.DAO
{
    using System.Collections.Generic;

    public class AfiliadoDao : DaoBase
    {
        public AfiliadoDao() : base()
        {
        }

        public List<Afiliado> GetAfiliados()
        {
            List<Afiliado> afiliados = new List<Afiliado>();
            /*
            for (int i = 0; i < 50; i++)
            {
                var afiliado = new Afiliado();
                afiliado.afiliado_activo = true;
                afiliado.afiliado_apellido = "asdsadasds asdasas";
                afiliado.afiliado_direccion = "asdsaasd";
                afiliado.afiliado_estado_civil = 1;
                afiliado.afiliado_familiares_dependientes = 2;
                afiliado.afiliado_fecha_alta = new System.DateTime();
                afiliado.afiliado_fecha_baja = new System.DateTime();
                afiliado.afiliado_fecha_nacimiento = new System.DateTime();
                afiliado.afiliado_grupo_familiar = 123132;
                afiliado.afiliado_id = i;
                afiliado.afiliado_mail = "asddas@asdas.asd";
                afiliado.afiliado_nombre = "nombre";
                afiliado.afiliado_numero = 123456;
                afiliado.afiliado_numero_documento = 1232435;
                afiliado.afiliado_plan = 1;
                afiliado.afiliado_sexo = 1;
                afiliado.afiliado_telefono = 1;
                afiliado.afiliado_tipo_documento = 1;
                afiliado.afiliado_usuario = i;
            }
            */
            return afiliados;
        }
    }
}
