namespace ClinicaFrba.DataAccess.DAO
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class ProfesionalDao : DaoBase
    {
        public ProfesionalDao() : base()
        {
        }

        public Profesional GetProfesional(int id)
        {
            return _ds.Profesionals.SingleOrDefault(x => x.profesional_id == id);
        }

        public void SaveAgendum(Profesional profesional)
        {
            _ds.Profesionals.Attach(profesional);
            _ds.SaveChanges();
        }

        public List<Turno> GetTurnos(int id, Especialidad especialidad)
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
            pro.Especialidads.Add(especialidad);

            for (int i = 0; i < 10; i++)
            {
                var turno = new Turno();
                turno.Afiliado = afiliado;
                turno.Profesional = pro;
                turno.Especialidad = especialidad ?? new Especialidad()
                {
                    especialidad_nombre = "Sarasa"
                };
                turnos.Add(turno);
            }

            return turnos;
        }

        public List<Turno> GetTurnos(string name, Especialidad especialidad)
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
            pro.Especialidads.Add(especialidad);

            for (int i = 0; i < 10; i++)
            {
                var turno = new Turno();
                turno.Afiliado = afiliado;
                turno.Profesional = pro;
                turno.Especialidad = especialidad ?? new Especialidad()
                {
                    especialidad_nombre = "Sarasa"
                };
                turnos.Add(turno);
            }

            return turnos;
        }

        public List<Especialidad> GetEspecialidades()
        {
            return _ds.Especialidads.ToList();
        }

        public List<DateTime> GetFechasDisponibles(Profesional profesional, Especialidad especialidad)
        {
            return _ds.FechasDisponibles(profesional.profesional_id, especialidad.especialidad_id).Select(x => x.Fecha).ToList();
        }

        public List<int> GetHorasDisponibles(Profesional profesional, Especialidad especialidad, string fecha)
        {
            return _ds.HorasDisponibles(profesional.profesional_id, especialidad.especialidad_id, 
                DateTime.ParseExact(fecha, "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture))
                .Select(x => x.Value).ToList();
        }

        public List<Profesional> GetProfesionales(Especialidad especialidad)
        {
            return _ds.Profesionals.Where(x => x.Especialidads.Any(y => y.especialidad_id == especialidad.especialidad_id)).ToList();
        }
    }
}
