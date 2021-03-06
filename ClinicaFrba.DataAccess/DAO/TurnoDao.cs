﻿namespace ClinicaFrba.DataAccess.DAO
{
    using Configuration;
    using System;
    using System.Linq;
    using System.Collections.Generic;

    //Todos estos metodos llaman a Stores Procedures, Functions y Views mapeados por entity framework
    public class TurnoDao : DaoBase
    {
        public TurnoDao() : base()
        {
        }

        public List<Turno> GetTurnosAfiliado(int afiliadoId)
        {
            using (Entities _ds = GetDatasource())
            {
                List<Turno> turnos = new List<Turno>();

                foreach (TurnosAfiliado_Result x in _ds.TurnosAfiliado(afiliadoId, GetFecha()))
                {
                    Turno turno = new Turno()
                    {
                        turno_id = x.turno_id,
                        turno_hora = x.turno_hora,
                        turno_llego = x.turno_llego,
                        turno_fecha = x.turno_fecha
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
                        profesional_nombre = x.profesional_nombre,
                        profesional_apellido = x.profesional_apellido
                    };

                    turnos.Add(turno);
                }

                return turnos;
            }
        }

        public List<TipoCancelacion> GetTipoCancelaciones()
        {
            using (Entities _ds = GetDatasource())
            {
                return _ds.ListaTipoCancelaciones.ToList().Select(x => new TipoCancelacion()
                {
                    tipocancelacion_id = x.tipocancelacion_id,
                    tipocancelacion_nombre = x.tipocancelacion_nombre
                }).ToList();
            }
        }

        public List<Turno> GetTurnosProfesional(int idProfesional, int idEspecialidad)
        {
            using (Entities _ds = GetDatasource())
            {
                List<Turno> turnos = new List<Turno>();

                foreach (TurnosProfesionalEspecialidad_Result x in _ds.TurnosProfesionalEspecialidad(idProfesional, idEspecialidad, GetFecha()))
                {
                    Turno turno = new Turno()
                    {
                        turno_id = x.turno_id,
                        turno_hora = x.turno_hora,
                        turnocancelado_id = x.turnocancelado_id,
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
                        profesional_nombre = x.profesional_nombre,
                        profesional_apellido = x.profesional_apellido
                    };

                    turnos.Add(turno);
                }

                return turnos;
            }
        }

        public List<Turno> GetTurnosProfesional(string nombreProfesional)
        {
            using (Entities _ds = GetDatasource())
            {
                List<Turno> turnos = new List<Turno>();

                foreach (TurnosProfesionalNombre_Result x in _ds.TurnosProfesionalNombre(nombreProfesional, GetFecha()))
                {
                    Turno turno = new Turno()
                    {
                        turno_id = x.turno_id,
                        turno_hora = x.turno_hora,
                        turnocancelado_id = x.turnocancelado_id,
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
                        profesional_nombre = x.profesional_nombre,
                        profesional_apellido = x.profesional_apellido
                    };

                    turnos.Add(turno);
                }

                return turnos;
            }
        }

        public List<Turno> GetTurnosProfesional(int profesionalId)
        {
            using (Entities _ds = GetDatasource())
            {
                List<Turno> turnos = new List<Turno>();

                foreach (TurnosProfesionalParaCancelar_Result x in _ds.TurnosProfesionalParaCancelar(profesionalId, GetFecha()))
                {
                    Turno turno = new Turno()
                    {
                        turno_id = x.turno_id,
                        turno_hora = x.turno_hora,
                        turno_llego = x.turno_llego,
                        turno_fecha = x.turno_fecha
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
                        profesional_nombre = x.profesional_nombre,
                        profesional_apellido = x.profesional_apellido
                    };

                    turnos.Add(turno);
                }

                return turnos;
            }
        }

        public CancelarTurno_Result CancelarTurno(string canceladoPor, int turnoId, int tipoCancelacionId, string descripcion)
        {
            using (Entities _ds = GetDatasource())
            {
                return _ds.CancelarTurno(canceladoPor, turnoId, tipoCancelacionId, descripcion).SingleOrDefault();
            }
        }

        public void CancelarTurnos(DateTime fechaDesde, DateTime fechaHasta, int profesionalId, int tipoCancelacionId, string descripcion)
        {
            using (Entities _ds = GetDatasource())
            {
                _ds.CancelarTurnoRango(profesionalId, fechaDesde, fechaHasta, tipoCancelacionId, descripcion);
            }
        }

        public PedirTurno_Result PedirTurno(Turno turno)
        {
            using (Entities _ds = GetDatasource())
            {
                return _ds.PedirTurno(turno.afiliado_id, turno.especialidad_id, turno.profesional_id, turno.turno_fecha, turno.turno_hora).SingleOrDefault();
            }
        }

        public void RegistroLlegada(int bonoId, int turnoId)
        {
            using (Entities _ds = GetDatasource())
            {
                DateTime now = Config.SystemDate().AddHours(DateTime.Now.Hour).AddMinutes(DateTime.Now.Minute);

                _ds.RegistroLlegada(turnoId, bonoId, now);
            }
        }
    }
}
