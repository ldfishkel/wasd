namespace ClinicaFrba.Core.DAO
{
    using System.Data.Entity.Core.Objects;
    using System.Linq;

    public class UserDao
    {
        private GD2C2016Entities _dataSource;

        public UserDao()
        {
            _dataSource = new GD2C2016Entities();
        }

        public Usuario GetUser(string username, string password)
        {
            ObjectQuery<Usuario> usuarioQuery = (ObjectQuery<Usuario>)(from u in _dataSource.Usuarios.Where(x => x.usuario_nombre == username && x.usuario_password == password) select u);
            var dataSet = usuarioQuery.Execute(MergeOption.NoTracking);
            return dataSet.FirstOrDefault();
        }
    }
}
