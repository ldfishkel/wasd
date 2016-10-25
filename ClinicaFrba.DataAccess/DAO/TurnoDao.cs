namespace ClinicaFrba.DataAccess.DAO
{
    using Configuration;
    using System.Collections.Generic;
    using System;
    using System.Linq;

    public class TurnoDao : DaoBase
    {
        public TurnoDao() : base()
        {
        }

        public List<Turno> GetTurnosAfiliado(int afiliadoId)
        {
            return new List<Turno>(); //TODO 07 CREAR FUNCTION TurnosDeAfiliado @afiliadoId, @fecha
        }

        public List<Turno> GetTurnosProfesional(int idProfesional, int idEspecialidad)
        {
            List<Turno> turnos = new List<Turno>();

            foreach (TurnosProfesionalEspecialidad_Result x in _ds.TurnosProfesionalEspecialidad(idProfesional, idEspecialidad, GetFecha()))
            {
                Turno turno = new Turno()
                {
                    turno_id = x.turno_id,
                    turno_hora = x.turno_hora,
                    turno_cancelado = x.turno_cancelado,
                    turno_llego = x.turno_llego
                };

                turno.Afiliado = new Afiliado()
                {
                    afiliado_nombre = x.afiliado_nombre,
                    afiliado_apellido = x.afiliado_apellido,
                    afiliado_numero = x.afiliado_numero,
                };

                turno.Especialidad = new Especialidad()
                {
                    especialidad_nombre = x.especialidad_nombre
                };

                turno.Profesional = new Profesional()
                {
                    profesional_nombre = x.profesional_nombre
                };

                turnos.Add(turno);
            }

            return turnos;
        }

        public List<Turno> GetTurnosProfesional(string nombreProfesional)
        {
            // TODO 02 CREATE FUNCTION TurnosProfesionalNombre @nombreProfesional @fechaSistema
            return new List<Turno>(); ;
        }

        public List<Turno> GetTurnosProfesional(int profesionalId)
        {
            // TODO 09 CREATE FUNCTION TurnosProfesionalParaCancelar @profesionalId @fechaSistema
            return new List<Turno>();
        }

        public void CancelarTurnos(DateTime fechaDesde, DateTime fechaHasta, int profesionalId)
        {
            //TODO 04 CREATE PROCEDURE CancelarTurnos @fechaDesde, @fechaHasta, @profesionalId
        }

        public void PedirTurno(Turno turno)
        {
            _ds.Turnoes.Add(turno);
            _ds.SaveChanges();
        }

        public void RegistroLlegada(int bonoId, int turnoId)
        {
            DateTime now = Config.SystemDate();

            now.AddHours(DateTime.Now.Hour);
            now.AddMinutes(DateTime.Now.Minute);

            _ds.RegistroLlegada(turnoId, bonoId, now);
        }

        private string GetFecha()
        {
            var today = Config.SystemDate();

            return String.Format("{0}/{1}/{2}", today.Day, today.Month, today.Year);
        }
    }
}
