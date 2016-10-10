namespace ClinicaFrba.DataAccess.DAO
{
    public class Afiliado
    {

        public string NombreyApellido;
        public string Dni;
        public string Direcci;
        public string Tel;
        public string Mail;
        public string Fecha;
        public string Sexo;
        public string EstadoCivil;
        public string Cantidadacargo;
        public string Plan;
        public string idAfiliado;

        public Afiliado(
            string NombreyApellido,
            string Dni,
            string Direcci,
            string Tel,
            string Mail,
            string Fecha,
            string Sexo,
            string EstadoCivil,
            string Cantidadacargo,
            string Plan,
            string idAfiliado
            )
        {
            this.NombreyApellido = NombreyApellido;
            this.Dni = Dni;
            this.Direcci = Direcci;
            this.Tel =  Tel;
            this.Mail = Mail;
            this.Fecha = Fecha;
            this.Sexo =  Sexo;
            this.EstadoCivil =  EstadoCivil;
            this.Cantidadacargo = Cantidadacargo;
            this.Plan = Plan;
            this.idAfiliado = idAfiliado;
        }

    }

}