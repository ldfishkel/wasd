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
            return _ds.Afiliadoes.ToList();
        }

        public List<TipoDocumento> getTipoDeDocumentos()
        {
            return _ds.TipoDocumentoes.ToList();
        }

        public List<Turno> GetTurnos(int usuario_id)
        {
            List<Turno> turnos = new List<Turno>();

            Afiliado afiliado = new Afiliado();

            afiliado.afiliado_nombre = "Leonel";
            afiliado.afiliado_apellido = "Dan";
            afiliado.PlanMedico = new PlanMedico();
            afiliado.PlanMedico.planmedico_nombre = "OSDE 210";
            afiliado.PlanMedico.planmedico_precio_bono = 100;
            afiliado.afiliado_numero = 1564215100;

            var pro = new Profesional();
            pro.profesional_nombre = "Profesional ";
            pro.Especialidads = new List<Especialidad>();

            for (int i = 0; i < 10; i++)
            {
                var turno = new Turno();
                turno.Afiliado = afiliado;
                turno.Profesional = pro;
                turno.Especialidad = new Especialidad()
                {
                    especialidad_nombre = "Sarasa"
                };
                turnos.Add(turno);
            }

            return turnos;
        }

        public List<Bono> GetBonos(int nroAfiliado)
        {
            List<Bono> bonos = new List<Bono>();

            for (int i = 0; i < 10; i++)
            {
                bonos.Add(new DataAccess.Bono()
                {
                    bono_id = i
                });
            }

            return bonos;
        }

        public void CompraDeBonos(int cant, int afiliado_id, int plan_id)
        {
            _ds.CompraBono(afiliado_id, cant, plan_id);
        }

        public Afiliado GetAfiliado(int tipoDocId, int nroDoc)
        {
            return _ds.Afiliadoes.SingleOrDefault(x => x.TipoDocumento.tipodocumento_id== tipoDocId && x.afiliado_numero_documento == nroDoc);
        }
    }
}
