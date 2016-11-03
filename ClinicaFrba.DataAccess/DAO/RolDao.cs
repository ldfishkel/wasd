
namespace ClinicaFrba.DataAccess.DAO
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    //Todos estos metodos llaman a Stores Procedures, Functions y Views mapeados por entity framework
    public class RolDao : DaoBase
    {
        public RolDao() : base()
        {
        }

        public SP_AgregarRol_Result Guardar(Rol rol)
        {
            var result = _ds.SP_AgregarRol(rol.rol_nombre).SingleOrDefault();

            if (result.status == 0)
                foreach (var f in rol.Funcionalidads)
                    _ds.SP_AgregarFuncionalidadPorRol(result.scopeIdentity, f.funcionalidad_id);

            return result;
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

        public List<Funcionalidad> GetFuncionalidades(int rol_id)
        {
            return _ds.FuncionalidadesDeRol(rol_id).ToList().Select(x => new Funcionalidad()
            {
                funcionalidad_id = x.funcionalidad_id,
                funcionalidad_nombre = x.funcionalidad_nombre
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

        public SP_ModificarRol_Result Modify(Rol rol)
        {
            var result = _ds.SP_ModificarRol(rol.rol_id, rol.rol_nombre).SingleOrDefault();

            if (result.status == 0)
            {
                _ds.QuitarFuncionalidades(rol.rol_id);

                foreach (var f in rol.Funcionalidads)
                    _ds.SP_AgregarFuncionalidadPorRol(rol.rol_id, f.funcionalidad_id);
            }
                
            return result;
        }
    }
}
