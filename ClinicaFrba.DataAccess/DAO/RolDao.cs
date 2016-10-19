
namespace ClinicaFrba.DataAccess.DAO
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class RolDao : DaoBase
    {
        public RolDao() : base()
        {
        }

        public bool Guardar(Rol rol)
        {
            _ds.Rols.Add(rol);
            _ds.SaveChanges();
            return true;
        }

        public List<Rol> GetAll()
        {
            return _ds.Rols.ToList();
        }

        public List<Funcionalidad> GetFuncionalidades()
        {
            return _ds.Funcionalidads.ToList();
        }

        public void Delete(int id)
        {
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
