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

        public Profesional GetProfesional(int userId)
        {
            return _ds.Profesionals.SingleOrDefault(x => x.usuario_id == userId);
        }

        public List<Hora> GetHoras()
        {
            return _ds.Horas.ToList();
        }

        public void SaveAgendum(Profesional profesional)
        {
            _ds.Profesionals.Attach(profesional);
            _ds.SaveChanges();
        }

        public List<Turno> GetTurnos(int idProfesional, int idEspecialidad)
        {
            var today = DateTime.Today;
            string fecha = today.Day + "/" + today.Month + "/" + today.Year;

            List<Turno> turnos = new List<Turno>();

            foreach (TurnosProfesionalEspecialidad_Result x in _ds.TurnosProfesionalEspecialidad(idProfesional, idEspecialidad, fecha))
            {
                Turno turno = new Turno()
                {
                    turno_id = x.turno_id,
                    afiliado_id = x.afiliado_id,
                    profesional_id = x.profesional_id,
                    especialidad_id = x.especialidad_id,
                    turno_fecha = x.turno_fecha,
                    turno_hora = x.turno_hora,
                    turno_cancelado = x.turno_cancelado
                };

                turno.Afiliado = new Afiliado()
                {
                    afiliado_id = x.afiliado_id,
                    afiliado_nombre = x.afiliado_nombre,
                    afiliado_apellido = x.afiliado_apellido
                };

                turnos.Add(turno);
            }

            return turnos;
        }

    public List<Turno> GetTurnos(string nombreProfesional, int idEspecialidad)
    {
        Profesional pro = _ds.Profesionals.SingleOrDefault(x => nombreProfesional.Contains(x.profesional_nombre) && nombreProfesional.Contains(x.profesional_apellido));

        return GetTurnos(pro.profesional_id, idEspecialidad);
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
        return _ds.HorasDisponibless(profesional.profesional_id, especialidad.especialidad_id, fecha).Select(x => x.Value).ToList();
    }

    public List<Profesional> GetProfesionales(Especialidad especialidad)
    {
        return _ds.Profesionals.Where(x => x.Especialidads.Any(y => y.especialidad_id == especialidad.especialidad_id)).ToList();
    }
}
}
