namespace ClinicaFrba.DataAccess.DAO
{
    using Configuration;
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
            return _ds.ProfesionalDeUsuario(userId).ToList().Select(x =>  new Profesional()
            {
                profesional_id = x.profesional_id,
                usuario_id = x.usuario_id,
                profesional_sexo = x.profesional_sexo,
                profesional_tipodocumento = x.profesional_tipodocumento,
                profesional_numero_documento = x.profesional_numero_documento,
                profesional_nombre = x.profesional_nombre,
                profesional_apellido = x.profesional_apellido,
                profesional_direccion = x.profesional_direccion,
                profesional_telefono = x.profesional_telefono,
                profesional_mail= x.profesional_mail,
                profesional_fecha_nacimiento = x.profesional_fecha_nacimiento,
                profesional_matricula = x.profesional_matricula
            }).SingleOrDefault();
        }

        public List<ConsultaMedica> GetConsultasMedicas(int profesional_id)
        {
            //TODO 05 CREATE FUNCTION ConsultasMedicasDeProfesional @profesionalId
            return new List<ConsultaMedica>()
            {
                new ConsultaMedica()
                {
                    consultamedica_id = 12345,
                    Bono = new Bono()
                    {
                        Afiliado = new Afiliado()
                        {
                            afiliado_nombre = "Juan",
                            afiliado_apellido = "Perez"
                        }
                    }
                }
            };
        }

        public void SaveResultadoConsulta(int _consultaId, List<string> _diagnosticos, List<string> _sintomas)
        {
            //TODO 08 Agregar tablas Diagnostico y Sintoma con consultamedica_id
        }

        public List<Hora> GetHorasSemana()
        {
            return _ds.ListaHorasSemanas.ToList().Select(x => new Hora()
            {
                hora_comienzo = x.hora_comienzo,
                hora_id = x.hora_id
            }).ToList();
        }

        public List<Agendum> GetAgenda(int profesional_id)
        {
            //TODO 03 CREATE FUNCTION AgendaDeProfesional @profesionalId
            return _ds.Agenda.Where(x => x.profesional_id == profesional_id).ToList(); 
        }

        public List<Hora> GetHorasSabado()
        {
            return _ds.ListaHorasSabadoes.ToList().Select(x => new Hora()
            {
                hora_comienzo = x.hora_comienzo,
                hora_id = x.hora_id
            }).ToList();
        }

        public void SaveAgendum(Profesional profesional)
        {
            _ds.Agenda.AddRange(profesional.Agenda);
            _ds.SaveChanges();
        }

        public List<Especialidad> GetEspecialidadesDeProfesional(int profesionalId)
        {
            return _ds.EspecialidadesDeProfesional(profesionalId).ToList().Select(x => new Especialidad()
            {
                especialidad_nombre = x.especialidad_nombre,
                especialidad_id = x.especialidad_id,
                tipoespecialidad_id = x.tipoespecialidad_id
            }).ToList();
        }

        public List<TipoEspecialidad> GetTipoDeEspecialidades()
        {
            return _ds.ListaTipoEspecialidades.ToList().Select(x => new TipoEspecialidad()
            {
                tipoespecialidad_nombre = x.tipoespecialidad_nombre,
                tipoespecialidad_id = x.tipoespecialidad_id
            }).ToList();
        }

        public List<Especialidad> GetEspecialidades(int tipoEspecialidadId)
        {
            return _ds.EspecialidadesDeTipo(tipoEspecialidadId).ToList().Select(x => new Especialidad()
            {
                especialidad_nombre = x.especialidad_nombre,
                especialidad_id = x.especialidad_id,
                tipoespecialidad_id = x.tipoespecialidad_id
            }).ToList();
        }

        public List<Especialidad> GetEspecialidades()
        {
            return _ds.ListaEspecialidades.ToList().Select(x => new Especialidad()
            {
                especialidad_id = x.especialidad_id,
                especialidad_nombre = x.especialidad_nombre,
                tipoespecialidad_id = x.tipoespecialidad_id
            }).ToList();
        }

        public List<DateTime> GetFechasDisponibles(Profesional profesional, Especialidad especialidad)
        {
            return _ds.FechasDisponibles(profesional.profesional_id, especialidad.especialidad_id).Select(x => x.Fecha).ToList();
        }

        public List<int> GetHorasDisponibles(Profesional profesional, Especialidad especialidad, string fecha)
        {
            return _ds.HorasDisponibles(profesional.profesional_id, especialidad.especialidad_id, fecha).Select(x => x.Value).ToList();
        }

        public List<Profesional> GetProfesionales(int especialidadId)
        {
            return _ds.ProfesionalesDeEspecialidad(especialidadId).ToList().Select(x => new Profesional()
            {
                profesional_nombre = x.profesional_nombre,
                profesional_apellido = x.profesional_apellido,
                profesional_id = x.profesional_id
            }).ToList();
        }

        private string GetFecha()
        {
            var today = Config.SystemDate();

            return today.Day + "/" + today.Month + "/" + today.Year;
        }
    }
}
