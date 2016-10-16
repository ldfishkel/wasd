namespace ClinicaFrba.DataAccess.DAO
{
    using System.Linq;

    public class UsuarioDao : DaoBase
    {
        public UsuarioDao() : base()
        {
        }

        public Usuario Login(string username, string password)
        {
            return _ds.Usuarios.SingleOrDefault(x => x.usuario_nombre == username && x.usuario_password == password);
        }
    }
}
