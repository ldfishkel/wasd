
namespace ClinicaFrba.DataAccess.DAO
{
    using System.Collections.Generic;
    using System.Linq;

    public class RolDao : DaoBase
    {
        public RolDao() : base()
        {
        }

        public void Guardar(Rol rol)
        {
            _ds.Rols.Add(rol);
            _ds.SaveChanges();
        }

        public List<Rol> GetAll()
        {
            return _ds.ListaRoles.ToList().Select(x => new Rol()
            {
                rol_id = x.rol_id,
                rol_activo = x.rol_activo,
                rol_nombre = x.rol_nombre
            }).ToList();
        }

        public List<Funcionalidad> GetFuncionalidades()
        {
            return _ds.ListaFuncionalidades.ToList().Select(x => new Funcionalidad()
            {
                funcionalidad_id = x.funcionalidad_id,
                funcionalidad_nombre = x.funcionalidad_nombre
            }).ToList();
        }

        public void Delete(int id)
        {
            //TODO 01 CREATE PROCEDURE BajaRol @rolId
            Rol rol = _ds.Rols.SingleOrDefault(x => x.rol_id == id);
            rol.rol_activo = false;

            _ds.Entry(rol).State = System.Data.Entity.EntityState.Modified;
            _ds.SaveChanges();
        }

        public bool Modify(Rol rol)
        {
            _ds.Entry(rol).State = System.Data.Entity.EntityState.Modified;
            _ds.SaveChanges();
            return true;
        }
    }
}
