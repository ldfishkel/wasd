﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ClinicaFrba.DataAccess
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class Entities : DbContext
    {
        public Entities()
            : base("name=Entities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Afiliado> Afiliadoes { get; set; }
        public virtual DbSet<Agendum> Agenda { get; set; }
        public virtual DbSet<Bono> Bonoes { get; set; }
        public virtual DbSet<Compra> Compras { get; set; }
        public virtual DbSet<ConsultaMedica> ConsultaMedicas { get; set; }
        public virtual DbSet<Diagnostico> Diagnosticoes { get; set; }
        public virtual DbSet<Especialidad> Especialidads { get; set; }
        public virtual DbSet<EstadoCivil> EstadoCivils { get; set; }
        public virtual DbSet<Funcionalidad> Funcionalidads { get; set; }
        public virtual DbSet<HistorialPlan> HistorialPlans { get; set; }
        public virtual DbSet<Hora> Horas { get; set; }
        public virtual DbSet<PlanMedico> PlanMedicoes { get; set; }
        public virtual DbSet<Profesional> Profesionals { get; set; }
        public virtual DbSet<Rol> Rols { get; set; }
        public virtual DbSet<Sintoma> Sintomas { get; set; }
        public virtual DbSet<TipoCancelacion> TipoCancelacions { get; set; }
        public virtual DbSet<TipoEspecialidad> TipoEspecialidads { get; set; }
        public virtual DbSet<Turno> Turnoes { get; set; }
        public virtual DbSet<TurnoCancelado> TurnoCanceladoes { get; set; }
        public virtual DbSet<Usuario> Usuarios { get; set; }
        public virtual DbSet<ListaAfiliado> ListaAfiliados { get; set; }
        public virtual DbSet<ListaEspecialidade> ListaEspecialidades { get; set; }
        public virtual DbSet<ListaEstadoCivil> ListaEstadoCivils { get; set; }
        public virtual DbSet<ListaFuncionalidade> ListaFuncionalidades { get; set; }
        public virtual DbSet<ListaHorasSabado> ListaHorasSabadoes { get; set; }
        public virtual DbSet<ListaHorasSemana> ListaHorasSemanas { get; set; }
        public virtual DbSet<ListaPlanMedico> ListaPlanMedicos { get; set; }
        public virtual DbSet<ListaRole> ListaRoles { get; set; }
        public virtual DbSet<ListaTipoCancelacione> ListaTipoCancelaciones { get; set; }
        public virtual DbSet<ListaTipoDocumento> ListaTipoDocumentoes { get; set; }
        public virtual DbSet<ListaTipoEspecialidade> ListaTipoEspecialidades { get; set; }
    
        [DbFunction("Entities", "AfiliadoBy")]
        public virtual IQueryable<AfiliadoBy_Result> AfiliadoBy(string tipoDocumento, Nullable<int> nroDocumento)
        {
            var tipoDocumentoParameter = tipoDocumento != null ?
                new ObjectParameter("tipoDocumento", tipoDocumento) :
                new ObjectParameter("tipoDocumento", typeof(string));
    
            var nroDocumentoParameter = nroDocumento.HasValue ?
                new ObjectParameter("nroDocumento", nroDocumento) :
                new ObjectParameter("nroDocumento", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.CreateQuery<AfiliadoBy_Result>("[Entities].[AfiliadoBy](@tipoDocumento, @nroDocumento)", tipoDocumentoParameter, nroDocumentoParameter);
        }
    
        [DbFunction("Entities", "AfiliadoDeUsuario")]
        public virtual IQueryable<AfiliadoDeUsuario_Result> AfiliadoDeUsuario(Nullable<int> usuarioId)
        {
            var usuarioIdParameter = usuarioId.HasValue ?
                new ObjectParameter("usuarioId", usuarioId) :
                new ObjectParameter("usuarioId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.CreateQuery<AfiliadoDeUsuario_Result>("[Entities].[AfiliadoDeUsuario](@usuarioId)", usuarioIdParameter);
        }
    
        [DbFunction("Entities", "AgendaProfesional")]
        public virtual IQueryable<AgendaProfesional_Result> AgendaProfesional(Nullable<int> profesionalId)
        {
            var profesionalIdParameter = profesionalId.HasValue ?
                new ObjectParameter("profesionalId", profesionalId) :
                new ObjectParameter("profesionalId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.CreateQuery<AgendaProfesional_Result>("[Entities].[AgendaProfesional](@profesionalId)", profesionalIdParameter);
        }
    
        [DbFunction("Entities", "BonosNroAfiliado")]
        public virtual IQueryable<BonosNroAfiliado_Result> BonosNroAfiliado(Nullable<int> nroAfiliado)
        {
            var nroAfiliadoParameter = nroAfiliado.HasValue ?
                new ObjectParameter("nroAfiliado", nroAfiliado) :
                new ObjectParameter("nroAfiliado", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.CreateQuery<BonosNroAfiliado_Result>("[Entities].[BonosNroAfiliado](@nroAfiliado)", nroAfiliadoParameter);
        }
    
        [DbFunction("Entities", "ConsultasMedicasProfesional")]
        public virtual IQueryable<ConsultasMedicasProfesional_Result> ConsultasMedicasProfesional(Nullable<int> profesionalId, string fecha)
        {
            var profesionalIdParameter = profesionalId.HasValue ?
                new ObjectParameter("profesionalId", profesionalId) :
                new ObjectParameter("profesionalId", typeof(int));
    
            var fechaParameter = fecha != null ?
                new ObjectParameter("fecha", fecha) :
                new ObjectParameter("fecha", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.CreateQuery<ConsultasMedicasProfesional_Result>("[Entities].[ConsultasMedicasProfesional](@profesionalId, @fecha)", profesionalIdParameter, fechaParameter);
        }
    
        [DbFunction("Entities", "EspecialidadesDeProfesional")]
        public virtual IQueryable<EspecialidadesDeProfesional_Result> EspecialidadesDeProfesional(Nullable<int> profesionalId)
        {
            var profesionalIdParameter = profesionalId.HasValue ?
                new ObjectParameter("profesionalId", profesionalId) :
                new ObjectParameter("profesionalId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.CreateQuery<EspecialidadesDeProfesional_Result>("[Entities].[EspecialidadesDeProfesional](@profesionalId)", profesionalIdParameter);
        }
    
        [DbFunction("Entities", "EspecialidadesDeTipo")]
        public virtual IQueryable<EspecialidadesDeTipo_Result> EspecialidadesDeTipo(Nullable<int> tipoEspecialidad)
        {
            var tipoEspecialidadParameter = tipoEspecialidad.HasValue ?
                new ObjectParameter("tipoEspecialidad", tipoEspecialidad) :
                new ObjectParameter("tipoEspecialidad", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.CreateQuery<EspecialidadesDeTipo_Result>("[Entities].[EspecialidadesDeTipo](@tipoEspecialidad)", tipoEspecialidadParameter);
        }
    
        [DbFunction("Entities", "FechasDisponibles")]
        public virtual IQueryable<FechasDisponibles_Result> FechasDisponibles(Nullable<int> profesionalId, Nullable<int> especialidadId)
        {
            var profesionalIdParameter = profesionalId.HasValue ?
                new ObjectParameter("profesionalId", profesionalId) :
                new ObjectParameter("profesionalId", typeof(int));
    
            var especialidadIdParameter = especialidadId.HasValue ?
                new ObjectParameter("especialidadId", especialidadId) :
                new ObjectParameter("especialidadId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.CreateQuery<FechasDisponibles_Result>("[Entities].[FechasDisponibles](@profesionalId, @especialidadId)", profesionalIdParameter, especialidadIdParameter);
        }
    
        [DbFunction("Entities", "HistorialDeAfiliado")]
        public virtual IQueryable<HistorialDeAfiliado_Result> HistorialDeAfiliado(Nullable<int> afiliado)
        {
            var afiliadoParameter = afiliado.HasValue ?
                new ObjectParameter("afiliado", afiliado) :
                new ObjectParameter("afiliado", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.CreateQuery<HistorialDeAfiliado_Result>("[Entities].[HistorialDeAfiliado](@afiliado)", afiliadoParameter);
        }
    
        [DbFunction("Entities", "PlanMedicoBy")]
        public virtual IQueryable<PlanMedicoBy_Result> PlanMedicoBy(Nullable<int> planmedicoId)
        {
            var planmedicoIdParameter = planmedicoId.HasValue ?
                new ObjectParameter("planmedicoId", planmedicoId) :
                new ObjectParameter("planmedicoId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.CreateQuery<PlanMedicoBy_Result>("[Entities].[PlanMedicoBy](@planmedicoId)", planmedicoIdParameter);
        }
    
        [DbFunction("Entities", "ProfesionalDeUsuario")]
        public virtual IQueryable<ProfesionalDeUsuario_Result> ProfesionalDeUsuario(Nullable<int> usuarioId)
        {
            var usuarioIdParameter = usuarioId.HasValue ?
                new ObjectParameter("usuarioId", usuarioId) :
                new ObjectParameter("usuarioId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.CreateQuery<ProfesionalDeUsuario_Result>("[Entities].[ProfesionalDeUsuario](@usuarioId)", usuarioIdParameter);
        }
    
        [DbFunction("Entities", "ProfesionalesDeEspecialidad")]
        public virtual IQueryable<ProfesionalesDeEspecialidad_Result> ProfesionalesDeEspecialidad(Nullable<int> especialidad)
        {
            var especialidadParameter = especialidad.HasValue ?
                new ObjectParameter("especialidad", especialidad) :
                new ObjectParameter("especialidad", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.CreateQuery<ProfesionalesDeEspecialidad_Result>("[Entities].[ProfesionalesDeEspecialidad](@especialidad)", especialidadParameter);
        }
    
        [DbFunction("Entities", "RolesDeUsuario")]
        public virtual IQueryable<RolesDeUsuario_Result> RolesDeUsuario(Nullable<int> usuarioId)
        {
            var usuarioIdParameter = usuarioId.HasValue ?
                new ObjectParameter("usuarioId", usuarioId) :
                new ObjectParameter("usuarioId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.CreateQuery<RolesDeUsuario_Result>("[Entities].[RolesDeUsuario](@usuarioId)", usuarioIdParameter);
        }
    
        [DbFunction("Entities", "TurnosAfiliado")]
        public virtual IQueryable<TurnosAfiliado_Result> TurnosAfiliado(Nullable<int> afiliadoId, string fecha)
        {
            var afiliadoIdParameter = afiliadoId.HasValue ?
                new ObjectParameter("afiliadoId", afiliadoId) :
                new ObjectParameter("afiliadoId", typeof(int));
    
            var fechaParameter = fecha != null ?
                new ObjectParameter("fecha", fecha) :
                new ObjectParameter("fecha", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.CreateQuery<TurnosAfiliado_Result>("[Entities].[TurnosAfiliado](@afiliadoId, @fecha)", afiliadoIdParameter, fechaParameter);
        }
    
        [DbFunction("Entities", "TurnosProfesionalEspecialidad")]
        public virtual IQueryable<TurnosProfesionalEspecialidad_Result> TurnosProfesionalEspecialidad(Nullable<int> profesionalId, Nullable<int> especialidadId, string fecha)
        {
            var profesionalIdParameter = profesionalId.HasValue ?
                new ObjectParameter("profesionalId", profesionalId) :
                new ObjectParameter("profesionalId", typeof(int));
    
            var especialidadIdParameter = especialidadId.HasValue ?
                new ObjectParameter("especialidadId", especialidadId) :
                new ObjectParameter("especialidadId", typeof(int));
    
            var fechaParameter = fecha != null ?
                new ObjectParameter("fecha", fecha) :
                new ObjectParameter("fecha", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.CreateQuery<TurnosProfesionalEspecialidad_Result>("[Entities].[TurnosProfesionalEspecialidad](@profesionalId, @especialidadId, @fecha)", profesionalIdParameter, especialidadIdParameter, fechaParameter);
        }
    
        [DbFunction("Entities", "TurnosProfesionalNombre")]
        public virtual IQueryable<TurnosProfesionalNombre_Result> TurnosProfesionalNombre(string nombreProfesional, string fecha)
        {
            var nombreProfesionalParameter = nombreProfesional != null ?
                new ObjectParameter("nombreProfesional", nombreProfesional) :
                new ObjectParameter("nombreProfesional", typeof(string));
    
            var fechaParameter = fecha != null ?
                new ObjectParameter("fecha", fecha) :
                new ObjectParameter("fecha", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.CreateQuery<TurnosProfesionalNombre_Result>("[Entities].[TurnosProfesionalNombre](@nombreProfesional, @fecha)", nombreProfesionalParameter, fechaParameter);
        }
    
        [DbFunction("Entities", "TurnosProfesionalParaCancelar")]
        public virtual IQueryable<TurnosProfesionalParaCancelar_Result> TurnosProfesionalParaCancelar(Nullable<int> profesionalId, string fecha)
        {
            var profesionalIdParameter = profesionalId.HasValue ?
                new ObjectParameter("profesionalId", profesionalId) :
                new ObjectParameter("profesionalId", typeof(int));
    
            var fechaParameter = fecha != null ?
                new ObjectParameter("fecha", fecha) :
                new ObjectParameter("fecha", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.CreateQuery<TurnosProfesionalParaCancelar_Result>("[Entities].[TurnosProfesionalParaCancelar](@profesionalId, @fecha)", profesionalIdParameter, fechaParameter);
        }
    
        public virtual ObjectResult<Nullable<decimal>> AltaAfiliado(Nullable<int> estadocivil_id, string afiliado_tipodocumento, Nullable<int> planmedico_id, string afiliado_sexo, Nullable<int> afiliado_numero, string afiliado_nombre, string afiliado_apellido, Nullable<int> afiliado_numero_documento, string afiliado_direccion, Nullable<int> afiliado_telefono, string afiliado_mail, Nullable<System.DateTime> afiliado_fecha_nacimiento, Nullable<byte> afiliado_familiares_dependientes, Nullable<int> afiliado_grupo_familiar)
        {
            var estadocivil_idParameter = estadocivil_id.HasValue ?
                new ObjectParameter("estadocivil_id", estadocivil_id) :
                new ObjectParameter("estadocivil_id", typeof(int));
    
            var afiliado_tipodocumentoParameter = afiliado_tipodocumento != null ?
                new ObjectParameter("afiliado_tipodocumento", afiliado_tipodocumento) :
                new ObjectParameter("afiliado_tipodocumento", typeof(string));
    
            var planmedico_idParameter = planmedico_id.HasValue ?
                new ObjectParameter("planmedico_id", planmedico_id) :
                new ObjectParameter("planmedico_id", typeof(int));
    
            var afiliado_sexoParameter = afiliado_sexo != null ?
                new ObjectParameter("afiliado_sexo", afiliado_sexo) :
                new ObjectParameter("afiliado_sexo", typeof(string));
    
            var afiliado_numeroParameter = afiliado_numero.HasValue ?
                new ObjectParameter("afiliado_numero", afiliado_numero) :
                new ObjectParameter("afiliado_numero", typeof(int));
    
            var afiliado_nombreParameter = afiliado_nombre != null ?
                new ObjectParameter("afiliado_nombre", afiliado_nombre) :
                new ObjectParameter("afiliado_nombre", typeof(string));
    
            var afiliado_apellidoParameter = afiliado_apellido != null ?
                new ObjectParameter("afiliado_apellido", afiliado_apellido) :
                new ObjectParameter("afiliado_apellido", typeof(string));
    
            var afiliado_numero_documentoParameter = afiliado_numero_documento.HasValue ?
                new ObjectParameter("afiliado_numero_documento", afiliado_numero_documento) :
                new ObjectParameter("afiliado_numero_documento", typeof(int));
    
            var afiliado_direccionParameter = afiliado_direccion != null ?
                new ObjectParameter("afiliado_direccion", afiliado_direccion) :
                new ObjectParameter("afiliado_direccion", typeof(string));
    
            var afiliado_telefonoParameter = afiliado_telefono.HasValue ?
                new ObjectParameter("afiliado_telefono", afiliado_telefono) :
                new ObjectParameter("afiliado_telefono", typeof(int));
    
            var afiliado_mailParameter = afiliado_mail != null ?
                new ObjectParameter("afiliado_mail", afiliado_mail) :
                new ObjectParameter("afiliado_mail", typeof(string));
    
            var afiliado_fecha_nacimientoParameter = afiliado_fecha_nacimiento.HasValue ?
                new ObjectParameter("afiliado_fecha_nacimiento", afiliado_fecha_nacimiento) :
                new ObjectParameter("afiliado_fecha_nacimiento", typeof(System.DateTime));
    
            var afiliado_familiares_dependientesParameter = afiliado_familiares_dependientes.HasValue ?
                new ObjectParameter("afiliado_familiares_dependientes", afiliado_familiares_dependientes) :
                new ObjectParameter("afiliado_familiares_dependientes", typeof(byte));
    
            var afiliado_grupo_familiarParameter = afiliado_grupo_familiar.HasValue ?
                new ObjectParameter("afiliado_grupo_familiar", afiliado_grupo_familiar) :
                new ObjectParameter("afiliado_grupo_familiar", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<decimal>>("AltaAfiliado", estadocivil_idParameter, afiliado_tipodocumentoParameter, planmedico_idParameter, afiliado_sexoParameter, afiliado_numeroParameter, afiliado_nombreParameter, afiliado_apellidoParameter, afiliado_numero_documentoParameter, afiliado_direccionParameter, afiliado_telefonoParameter, afiliado_mailParameter, afiliado_fecha_nacimientoParameter, afiliado_familiares_dependientesParameter, afiliado_grupo_familiarParameter);
        }
    
        public virtual int AltaAgendaProfesional()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("AltaAgendaProfesional");
        }
    
        public virtual int BajaAfiliado(Nullable<int> afiliadoId, Nullable<System.DateTime> fecha)
        {
            var afiliadoIdParameter = afiliadoId.HasValue ?
                new ObjectParameter("afiliadoId", afiliadoId) :
                new ObjectParameter("afiliadoId", typeof(int));
    
            var fechaParameter = fecha.HasValue ?
                new ObjectParameter("fecha", fecha) :
                new ObjectParameter("fecha", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("BajaAfiliado", afiliadoIdParameter, fechaParameter);
        }
    
        public virtual int BajaRol(Nullable<int> rolId)
        {
            var rolIdParameter = rolId.HasValue ?
                new ObjectParameter("rolId", rolId) :
                new ObjectParameter("rolId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("BajaRol", rolIdParameter);
        }
    
        public virtual int CancelarTurno(string canceladoPor, Nullable<int> turnoId, Nullable<int> tipoCancelacionId, string descripcion)
        {
            var canceladoPorParameter = canceladoPor != null ?
                new ObjectParameter("canceladoPor", canceladoPor) :
                new ObjectParameter("canceladoPor", typeof(string));
    
            var turnoIdParameter = turnoId.HasValue ?
                new ObjectParameter("turnoId", turnoId) :
                new ObjectParameter("turnoId", typeof(int));
    
            var tipoCancelacionIdParameter = tipoCancelacionId.HasValue ?
                new ObjectParameter("tipoCancelacionId", tipoCancelacionId) :
                new ObjectParameter("tipoCancelacionId", typeof(int));
    
            var descripcionParameter = descripcion != null ?
                new ObjectParameter("descripcion", descripcion) :
                new ObjectParameter("descripcion", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("CancelarTurno", canceladoPorParameter, turnoIdParameter, tipoCancelacionIdParameter, descripcionParameter);
        }
    
        public virtual int CancelarTurnoRango(Nullable<int> profesionalId, Nullable<System.DateTime> fechaDesde, Nullable<System.DateTime> fechaHasta, Nullable<int> tipoCancelacionId, string descripcion)
        {
            var profesionalIdParameter = profesionalId.HasValue ?
                new ObjectParameter("profesionalId", profesionalId) :
                new ObjectParameter("profesionalId", typeof(int));
    
            var fechaDesdeParameter = fechaDesde.HasValue ?
                new ObjectParameter("fechaDesde", fechaDesde) :
                new ObjectParameter("fechaDesde", typeof(System.DateTime));
    
            var fechaHastaParameter = fechaHasta.HasValue ?
                new ObjectParameter("fechaHasta", fechaHasta) :
                new ObjectParameter("fechaHasta", typeof(System.DateTime));
    
            var tipoCancelacionIdParameter = tipoCancelacionId.HasValue ?
                new ObjectParameter("tipoCancelacionId", tipoCancelacionId) :
                new ObjectParameter("tipoCancelacionId", typeof(int));
    
            var descripcionParameter = descripcion != null ?
                new ObjectParameter("descripcion", descripcion) :
                new ObjectParameter("descripcion", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("CancelarTurnoRango", profesionalIdParameter, fechaDesdeParameter, fechaHastaParameter, tipoCancelacionIdParameter, descripcionParameter);
        }
    
        public virtual int CompraBono(Nullable<int> afiliadoId, Nullable<int> cant, Nullable<int> planMedicoId, Nullable<System.DateTime> fecha)
        {
            var afiliadoIdParameter = afiliadoId.HasValue ?
                new ObjectParameter("afiliadoId", afiliadoId) :
                new ObjectParameter("afiliadoId", typeof(int));
    
            var cantParameter = cant.HasValue ?
                new ObjectParameter("cant", cant) :
                new ObjectParameter("cant", typeof(int));
    
            var planMedicoIdParameter = planMedicoId.HasValue ?
                new ObjectParameter("planMedicoId", planMedicoId) :
                new ObjectParameter("planMedicoId", typeof(int));
    
            var fechaParameter = fecha.HasValue ?
                new ObjectParameter("fecha", fecha) :
                new ObjectParameter("fecha", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("CompraBono", afiliadoIdParameter, cantParameter, planMedicoIdParameter, fechaParameter);
        }
    
        public virtual int ConsultaMedicaOcurrio(Nullable<int> consultaMedicaId, Nullable<System.DateTime> fechaYHora)
        {
            var consultaMedicaIdParameter = consultaMedicaId.HasValue ?
                new ObjectParameter("consultaMedicaId", consultaMedicaId) :
                new ObjectParameter("consultaMedicaId", typeof(int));
    
            var fechaYHoraParameter = fechaYHora.HasValue ?
                new ObjectParameter("fechaYHora", fechaYHora) :
                new ObjectParameter("fechaYHora", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("ConsultaMedicaOcurrio", consultaMedicaIdParameter, fechaYHoraParameter);
        }
    
        public virtual int DeleteAfiliado(Nullable<int> afiliadoId, Nullable<System.DateTime> fecha)
        {
            var afiliadoIdParameter = afiliadoId.HasValue ?
                new ObjectParameter("afiliadoId", afiliadoId) :
                new ObjectParameter("afiliadoId", typeof(int));
    
            var fechaParameter = fecha.HasValue ?
                new ObjectParameter("fecha", fecha) :
                new ObjectParameter("fecha", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("DeleteAfiliado", afiliadoIdParameter, fechaParameter);
        }
    
        public virtual ObjectResult<Nullable<int>> HorasDisponibles(Nullable<int> profesionalId, Nullable<int> especialidadId, string fechaStr)
        {
            var profesionalIdParameter = profesionalId.HasValue ?
                new ObjectParameter("profesionalId", profesionalId) :
                new ObjectParameter("profesionalId", typeof(int));
    
            var especialidadIdParameter = especialidadId.HasValue ?
                new ObjectParameter("especialidadId", especialidadId) :
                new ObjectParameter("especialidadId", typeof(int));
    
            var fechaStrParameter = fechaStr != null ?
                new ObjectParameter("fechaStr", fechaStr) :
                new ObjectParameter("fechaStr", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<int>>("HorasDisponibles", profesionalIdParameter, especialidadIdParameter, fechaStrParameter);
        }
    
        public virtual ObjectResult<Login_Result> Login(string username, string password)
        {
            var usernameParameter = username != null ?
                new ObjectParameter("username", username) :
                new ObjectParameter("username", typeof(string));
    
            var passwordParameter = password != null ?
                new ObjectParameter("password", password) :
                new ObjectParameter("password", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Login_Result>("Login", usernameParameter, passwordParameter);
        }
    
        public virtual int RegistroLlegada(Nullable<int> turnoId, Nullable<int> bonoId, Nullable<System.DateTime> fechaActual)
        {
            var turnoIdParameter = turnoId.HasValue ?
                new ObjectParameter("turnoId", turnoId) :
                new ObjectParameter("turnoId", typeof(int));
    
            var bonoIdParameter = bonoId.HasValue ?
                new ObjectParameter("bonoId", bonoId) :
                new ObjectParameter("bonoId", typeof(int));
    
            var fechaActualParameter = fechaActual.HasValue ?
                new ObjectParameter("fechaActual", fechaActual) :
                new ObjectParameter("fechaActual", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("RegistroLlegada", turnoIdParameter, bonoIdParameter, fechaActualParameter);
        }
    
        public virtual ObjectResult<SP_ListadoEstadistico1_Result> SP_ListadoEstadistico1(Nullable<System.DateTime> fecha_desde, Nullable<System.DateTime> fecha_hasta)
        {
            var fecha_desdeParameter = fecha_desde.HasValue ?
                new ObjectParameter("fecha_desde", fecha_desde) :
                new ObjectParameter("fecha_desde", typeof(System.DateTime));
    
            var fecha_hastaParameter = fecha_hasta.HasValue ?
                new ObjectParameter("fecha_hasta", fecha_hasta) :
                new ObjectParameter("fecha_hasta", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SP_ListadoEstadistico1_Result>("SP_ListadoEstadistico1", fecha_desdeParameter, fecha_hastaParameter);
        }
    
        public virtual ObjectResult<SP_ListadoEstadistico4_Result> SP_ListadoEstadistico4(Nullable<System.DateTime> fecha_desde, Nullable<System.DateTime> fecha_hasta)
        {
            var fecha_desdeParameter = fecha_desde.HasValue ?
                new ObjectParameter("fecha_desde", fecha_desde) :
                new ObjectParameter("fecha_desde", typeof(System.DateTime));
    
            var fecha_hastaParameter = fecha_hasta.HasValue ?
                new ObjectParameter("fecha_hasta", fecha_hasta) :
                new ObjectParameter("fecha_hasta", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SP_ListadoEstadistico4_Result>("SP_ListadoEstadistico4", fecha_desdeParameter, fecha_hastaParameter);
        }
    
        public virtual ObjectResult<SP_ListadoEstadistico5_Result> SP_ListadoEstadistico5(Nullable<System.DateTime> fecha_desde, Nullable<System.DateTime> fecha_hasta)
        {
            var fecha_desdeParameter = fecha_desde.HasValue ?
                new ObjectParameter("fecha_desde", fecha_desde) :
                new ObjectParameter("fecha_desde", typeof(System.DateTime));
    
            var fecha_hastaParameter = fecha_hasta.HasValue ?
                new ObjectParameter("fecha_hasta", fecha_hasta) :
                new ObjectParameter("fecha_hasta", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SP_ListadoEstadistico5_Result>("SP_ListadoEstadistico5", fecha_desdeParameter, fecha_hastaParameter);
        }
    
        public virtual int UpdateAfiliado(Nullable<int> afiliadoId, string direccion, Nullable<int> telefono, string mail, Nullable<int> estadoCivil, Nullable<int> planMedico, string motivo, Nullable<System.DateTime> fecha)
        {
            var afiliadoIdParameter = afiliadoId.HasValue ?
                new ObjectParameter("afiliadoId", afiliadoId) :
                new ObjectParameter("afiliadoId", typeof(int));
    
            var direccionParameter = direccion != null ?
                new ObjectParameter("direccion", direccion) :
                new ObjectParameter("direccion", typeof(string));
    
            var telefonoParameter = telefono.HasValue ?
                new ObjectParameter("telefono", telefono) :
                new ObjectParameter("telefono", typeof(int));
    
            var mailParameter = mail != null ?
                new ObjectParameter("mail", mail) :
                new ObjectParameter("mail", typeof(string));
    
            var estadoCivilParameter = estadoCivil.HasValue ?
                new ObjectParameter("estadoCivil", estadoCivil) :
                new ObjectParameter("estadoCivil", typeof(int));
    
            var planMedicoParameter = planMedico.HasValue ?
                new ObjectParameter("planMedico", planMedico) :
                new ObjectParameter("planMedico", typeof(int));
    
            var motivoParameter = motivo != null ?
                new ObjectParameter("motivo", motivo) :
                new ObjectParameter("motivo", typeof(string));
    
            var fechaParameter = fecha.HasValue ?
                new ObjectParameter("fecha", fecha) :
                new ObjectParameter("fecha", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("UpdateAfiliado", afiliadoIdParameter, direccionParameter, telefonoParameter, mailParameter, estadoCivilParameter, planMedicoParameter, motivoParameter, fechaParameter);
        }
    }
}
