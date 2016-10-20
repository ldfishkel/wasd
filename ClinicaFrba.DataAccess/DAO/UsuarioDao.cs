namespace ClinicaFrba.DataAccess.DAO
{
    using System;
    using System.Linq;
    using System.Security.Cryptography;
    using System.Text;

    public class UsuarioDao : DaoBase
    {
        public UsuarioDao() : base()
        {
        }

        public Usuario Login(string username, string password)
        {
            string hashedPassword = HashSha256(password);
            return _ds.Usuarios.SingleOrDefault(x => x.usuario_nombre == username && x.usuario_password == hashedPassword);
        }

        public string HashSha256(string text)
        {
            byte[] bytes = Encoding.UTF8.GetBytes(text);
            SHA256Managed hashstring = new SHA256Managed();
            byte[] hash = hashstring.ComputeHash(bytes);
            string hashString = string.Empty;
            foreach (byte x in hash)
            {
                hashString += String.Format("{0:x2}", x);
            }
            return hashString;
        }
    }
}
