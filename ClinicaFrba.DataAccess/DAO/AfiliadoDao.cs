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

        public string[] getTipoDeDocumentos()
        {
            return new string[] { "DNI" };
        }

        public List<Turno> GetTurnos(int usuario_id)
        {
            //llamar a un proc que traiga todos los turnos que no tengan un bono con el mismo afiliado y fecha

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
            return _ds.BonosNroAfiliado(nroAfiliado).Select(x =>
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
            return _ds.Afiliadoes.SingleOrDefault(x => x.afiliado_tipodocumento == tipoDoc && x.afiliado_numero_documento == nroDoc);
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
