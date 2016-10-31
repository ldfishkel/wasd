
namespace ClinicaFrba.DataAccess.DAO
{
    using System.Collections.Generic;
    using System.Linq;

    //Todos estos metodos llaman a Stores Procedures, Functions y Views mapeados por entity framework
    public class RolDao : DaoBase
    {
        public RolDao() : base()
        {
        }

        public void Guardar(Rol rol)
        { 
            //TODO CREATE PROCEDURE AltaRol @nombre VARCHAR -- Con try catch para UNIQUE contraint (ver AltaAfiliado)
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
            _ds.BajaRol(id);
        }

        public bool Modify(Rol rol)
        {
            //TODO CREATE PROCEDURE ModificarRol @rolId INT, @rolNombre VARCHAR  -- borrar las relaciones de funcionalidades y updetea el nombre del rol try catch para UNIQUE
            //TODO CREATE PROCEDURE AltaFuncionalidadPorRol @rolId INT, @funcionalidadId INT-- Insert de funcionalidad por rol
            _ds.Entry(rol).State = System.Data.Entity.EntityState.Modified;
            _ds.SaveChanges();
            return true;
        }
    }
}
