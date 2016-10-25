namespace ClinicaFrba.DataAccess.DAO
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class AfiliadoDao : DaoBase
    {
        public AfiliadoDao() : base()
        {
        }

        public List<Afiliado> GetAfiliados()
        {
            return _ds.ListaAfiliados.ToList().Select(x => new Afiliado()
            {
                afiliado_id = x.afiliado_id,
                usuario_id = x.usuario_id,
                estadocivil_id = x.estadocivil_id,
                afiliado_tipodocumento = x.afiliado_tipodocumento,
                planmedico_id = x.planmedico_id,
                afiliado_sexo = x.afiliado_sexo,
                afiliado_numero = x.afiliado_numero,
                afiliado_nombre = x.afiliado_nombre,
                afiliado_apellido = x.afiliado_apellido,
                afiliado_numero_documento = x.afiliado_numero_documento,
                afiliado_direccion = x.afiliado_direccion,
                afiliado_telefono = x.afiliado_telefono,
                afiliado_mail = x.afiliado_mail,
                afiliado_fecha_nacimiento = x.afiliado_fecha_nacimiento,
                afiliado_familiares_dependientes = x.afiliado_familiares_dependientes,
                afiliado_activo = x.afiliado_activo,
                afiliado_grupo_familiar = x.afiliado_grupo_familiar,
                afiliado_cantidad_bonos_usados = x.afiliado_cantidad_bonos_usados
            }).ToList();
        }

        public string[] GetTipoDeDocumentos()
        {
            return _ds.ListaTipoDocumentoes.ToList().Select(x => x.tipoDocumento).ToArray();
        }

        public List<Turno> GetTurnos(int usuario_id)
        {
            return new List<Turno>(); //TODO CREAR FUNCTION
        }

        public Afiliado GetAfiliado(int userId)
        {
            var x = _ds.AfiliadoDeUsuario(userId).SingleOrDefault();

            if (x == null)
                return null;

            return new Afiliado()
            {
                afiliado_id = x.afiliado_id,
                usuario_id = x.usuario_id,
                estadocivil_id = x.estadocivil_id,
                afiliado_tipodocumento = x.afiliado_tipodocumento,
                planmedico_id = x.planmedico_id,
                afiliado_sexo = x.afiliado_sexo,
                afiliado_numero = x.afiliado_numero,
                afiliado_nombre = x.afiliado_nombre,
                afiliado_apellido = x.afiliado_apellido,
                afiliado_numero_documento = x.afiliado_numero_documento,
                afiliado_direccion = x.afiliado_direccion,
                afiliado_telefono = x.afiliado_telefono,
                afiliado_mail = x.afiliado_mail,
                afiliado_fecha_nacimiento = x.afiliado_fecha_nacimiento,
                afiliado_familiares_dependientes = x.afiliado_familiares_dependientes,
                afiliado_activo = x.afiliado_activo,
                afiliado_grupo_familiar = x.afiliado_grupo_familiar,
                afiliado_cantidad_bonos_usados = x.afiliado_cantidad_bonos_usados
            };
        }

        public PlanMedico GetPlanMedico(int planmedico_id)
        {
            //TODO CREATE FUNCTION PlanMedicoBy @planmedico_id RETURNS TABLE
            return _ds.PlanMedicoes.SingleOrDefault(x => x.planmedico_id == planmedico_id);
        }

        public List<Bono> GetBonos(int nroAfiliado)
        {
            return _ds.BonosNroAfiliado(nroAfiliado).ToList().Select(x =>
                new Bono()
                {
                    bono_id = x.bono_id
                }).ToList();
        }

        public void CompraDeBonos(int cant, int afiliado_id, int plan_id)
        {
            _ds.CompraBono(afiliado_id, cant, plan_id);
        }

        public Afiliado GetAfiliado(string tipoDoc, int nroDoc)
        {
            var x = _ds.AfiliadoBy(tipoDoc, nroDoc).SingleOrDefault();

            if (x == null)
                return null;

            return new Afiliado()
            {
                afiliado_id = x.afiliado_id,
                usuario_id = x.usuario_id,
                estadocivil_id = x.estadocivil_id,
                afiliado_tipodocumento = x.afiliado_tipodocumento,
                planmedico_id = x.planmedico_id,
                afiliado_sexo = x.afiliado_sexo,
                afiliado_numero = x.afiliado_numero,
                afiliado_nombre = x.afiliado_nombre,
                afiliado_apellido = x.afiliado_apellido,
                afiliado_numero_documento = x.afiliado_numero_documento,
                afiliado_direccion = x.afiliado_direccion,
                afiliado_telefono = x.afiliado_telefono,
                afiliado_mail = x.afiliado_mail,
                afiliado_fecha_nacimiento = x.afiliado_fecha_nacimiento,
                afiliado_familiares_dependientes = x.afiliado_familiares_dependientes,
                afiliado_activo = x.afiliado_activo,
                afiliado_grupo_familiar = x.afiliado_grupo_familiar,
                afiliado_cantidad_bonos_usados = x.afiliado_cantidad_bonos_usados
            };
        }

        public void PedirTurno(Turno turno)
        {
            _ds.Turnoes.Add(turno);
            _ds.SaveChanges();
        }

        public void UsarBono(int bonoId, int turnoId)
        {
            _ds.RegistroLlegada(turnoId, bonoId, DateTime.Now);
        }
    }
}
