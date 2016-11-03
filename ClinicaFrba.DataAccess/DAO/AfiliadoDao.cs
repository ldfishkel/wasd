namespace ClinicaFrba.DataAccess.DAO
{
    using Configuration;
    using System;
    using System.Collections.Generic;
    using System.Linq;

    //Todos estos metodos llaman a Stores Procedures, Functions y Views mapeados por entity framework
    public class AfiliadoDao : DaoBase
    {
        public AfiliadoDao() : base()
        {
        }

        public List<Afiliado> GetAfiliados()
        {
            return _ds.ListaAfiliados.ToList().Select(x => new Afiliado()
            {
                usuario_id = x.usuario_id,
                afiliado_numero = x.afiliado_numero,
                afiliado_nombre = x.afiliado_nombre,
                afiliado_apellido = x.afiliado_apellido,
            }).ToList();
        }

        public EstadoCivil[] GetEstadosCiviles()
        {
            return _ds.ListaEstadoCivils.ToList().Select(x => new EstadoCivil()
            {
                estadocivil_id = x.estadocivil_id,
                estadocivil_nombre = x.estadocivil_nombre
            }).ToArray();
        }

        public string[] GetTipoDeDocumentos()
        {
            return _ds.ListaTipoDocumentoes.ToList().Select(x => x.tipoDocumento).ToArray();
        }

        public List<PlanMedico> PlanesMedicos()
        {
            return _ds.PlanMedicoes.ToList().Select(x => new PlanMedico()
            {
                planmedico_nombre = x.planmedico_nombre,
                planmedico_id = x.planmedico_id,
                planmedico_precio_bono = x.planmedico_precio_bono,
                planmedico_cuota = x.planmedico_cuota
            }).ToList();
        }

        public void UpdateAfiliado(Afiliado afiliado, string motivo)
        {
            DateTime date = Config.SystemDate().AddHours(DateTime.Now.Hour).AddMinutes(DateTime.Now.Minute);

            _ds.UpdateAfiliado(afiliado.afiliado_id, afiliado.afiliado_direccion, afiliado.afiliado_telefono, afiliado.afiliado_mail, afiliado.estadocivil_id, afiliado.planmedico_id, motivo, date);
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
                afiliado_cantidad_bonos_usados = x.afiliado_cantidad_bonos_usados,
                EstadoCivil = new EstadoCivil()
                {
                    estadocivil_id = x.estadocivil_id,
                    estadocivil_nombre = x.estadocivil_nombre
                }
            };
        }

        public void DeleteAfiliado(int afiliadoId)
        {
            DateTime date = Config.SystemDate().AddHours(DateTime.Now.Hour).AddMinutes(DateTime.Now.Minute);

            _ds.DeleteAfiliado(afiliadoId, date);
        }

        public List<HistorialPlan> HistorialPlan(int afiliadoId)
        {
            return _ds.HistorialDeAfiliado(afiliadoId).ToList().Select(x => new HistorialPlan()
            {
                historial_fecha = x.historial_fecha,
                historial_motivo = x.historial_motivo,
                afiliado_id = x.afiliado_id
            }).ToList();
        }

        public PlanMedico GetPlanMedico(int planmedico_id)
        {
            return _ds.PlanMedicoBy(planmedico_id).ToList().Select(x => new PlanMedico()
            {
                planmedico_id = x.planmedico_id,
                planmedico_nombre = x.planmedico_nombre,
                planmedico_cuota = x.planmedico_cuota,
                planmedico_precio_bono = x.planmedico_precio_bono
            }).SingleOrDefault();
        }

        public List<Bono> GetBonos(int nroAfiliado)
        {
            return _ds.BonosNroAfiliado(nroAfiliado).ToList().Select(x =>
                new Bono()
                {
                    bono_id = x.bono_id
                }).ToList();
        }

        public AltaAfiliado_Result AltaAfiliado(Afiliado _a)
        {
            var result = _ds.AltaAfiliado(_a.estadocivil_id, _a.afiliado_tipodocumento, _a.planmedico_id, _a.afiliado_sexo, _a.afiliado_numero, _a.afiliado_nombre, _a.afiliado_apellido, 
                _a.afiliado_numero_documento, _a.afiliado_direccion, _a.afiliado_telefono, _a.afiliado_mail, _a.afiliado_fecha_nacimiento,
                (byte)_a.Afiliado1.Count, null).SingleOrDefault();

            if (result.status == 1)
                return result;

            int grupoFamiliarId = result.scopeIdentity.Value;

            foreach (var a in _a.Afiliado1)
            {
                result = _ds.AltaAfiliado(a.estadocivil_id, a.afiliado_tipodocumento, _a.planmedico_id, a.afiliado_sexo, a.afiliado_numero, a.afiliado_nombre, a.afiliado_apellido,
                a.afiliado_numero_documento, a.afiliado_direccion, a.afiliado_telefono, a.afiliado_mail, a.afiliado_fecha_nacimiento, 0, grupoFamiliarId).SingleOrDefault();

                if (result.status == 1)
                    return result;
            }

            return result;
        }

        public void CompraDeBonos(int cant, int afiliado_id, int plan_id)
        {
            DateTime date = Config.SystemDate().AddHours(DateTime.Now.Hour).AddMinutes(DateTime.Now.Minute);

            _ds.CompraBono(afiliado_id, cant, plan_id, date);
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
    }
}
