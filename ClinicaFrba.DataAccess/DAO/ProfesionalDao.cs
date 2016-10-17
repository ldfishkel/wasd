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

        public List<Turno> GetTurnos(string nombre, Especialidad especialidad)
        {
            List<Turno> turnos = new List<Turno>();

            Afiliado afiliado = new Afiliado();

            afiliado.afiliado_nombre = "Leonel";
            afiliado.afiliado_apellido = "Dan";
            afiliado.PlanMedico = new PlanMedico();
            afiliado.PlanMedico.planmedico_nombre = "OSDE 210";
            afiliado.PlanMedico.planmedico_precio_bono = 100;
            afiliado.afiliado_numero = 1564215100;

            for (int i = 0; i < 10; i++)
            {
                var turno = new Turno();
                turno.Afiliado = afiliado;
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
            return new List<Especialidad>()
            {
                new Especialidad()
                {
                    especialidad_id = 1,
                    especialidad_nombre = "Una Especialidad",
                },
                new Especialidad()
                {
                    especialidad_id = 2,
                    especialidad_nombre = "Otra Especialidad"
                }
            };
        }

        public List<Profesional> GetProfesionales(Especialidad especialidad)
        {
            List<Profesional> profesionales = new List<Profesional>();

            for (int i = 0; i < 10; i++)
            {
                var pro = new Profesional();
                pro.profesional_nombre = "Profesional " + i;
                pro.Especialidads = new List<Especialidad>();
                pro.Especialidads.Add(especialidad);
                pro.Turnoes = this.GetTurnos(null, especialidad);
                profesionales.Add(pro);
            }

            return profesionales;
        }
    }
}
