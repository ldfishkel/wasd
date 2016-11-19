namespace ClinicaFrba.DataAccess.DAO
{
    using System.Collections.Generic;
    using System.Linq;

    //Todos estos metodos llaman a Stores Procedures, Functions y Views mapeados por entity framework
    public class UsuarioDao : DaoBase
    {
        public UsuarioDao() : base()
        {
        }

        public Login_Result Login(string username, string password)
        {
            using (Entities _ds = GetDatasource())
            {
                return _ds.Login(username, password).SingleOrDefault();
            }
        }

        public List<Rol> GetRoles(int userId)
        {
            using (Entities _ds = GetDatasource())
            {
                List<Rol> roles = new List<Rol>();

                foreach (var result in _ds.RolesDeUsuario(userId).ToList())
                {
                    if (!roles.Any(x => x.rol_id == result.rol_id))
                    {
                        var rol = new Rol()
                        {
                            rol_nombre = result.rol_nombre,
                            rol_id = result.rol_id,
                            rol_activo = result.rol_activo,
                            Funcionalidads = new List<Funcionalidad>()
                            {
                                new Funcionalidad()
                                {
                                    funcionalidad_id = result.funcionalidad_id,
                                    funcionalidad_nombre = result.funcionalidad_nombre
                                }
                            }
                        };
                        roles.Add(rol);
                    }
                    else
                    {
                        roles.SingleOrDefault(x => x.rol_id == result.rol_id).Funcionalidads.Add(new Funcionalidad()
                        {
                            funcionalidad_id = result.funcionalidad_id,
                            funcionalidad_nombre = result.funcionalidad_nombre
                        });
                    }
                }

                return roles;
            }
        }
    }
}
