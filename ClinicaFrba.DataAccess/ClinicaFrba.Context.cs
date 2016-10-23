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
    
    public partial class Database : DbContext
    {
        public Database()
            : base("name=Database")
        {
        }

        public Database(string s)
            : base(s)
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
        public virtual DbSet<TipoEspecialidad> TipoEspecialidads { get; set; }
        public virtual DbSet<Turno> Turnoes { get; set; }
        public virtual DbSet<Usuario> Usuarios { get; set; }
        public virtual DbSet<V_ListarEsp> V_ListarEsp { get; set; }
        public virtual DbSet<V_ListarProf> V_ListarProf { get; set; }
    
        [DbFunction("Database", "BonosNroAfiliado")]
        public virtual IQueryable<BonosNroAfiliado_Result> BonosNroAfiliado(Nullable<int> nroAfiliado)
        {
            var nroAfiliadoParameter = nroAfiliado.HasValue ?
                new ObjectParameter("nroAfiliado", nroAfiliado) :
                new ObjectParameter("nroAfiliado", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.CreateQuery<BonosNroAfiliado_Result>("[Database].[BonosNroAfiliado](@nroAfiliado)", nroAfiliadoParameter);
        }
    
        [DbFunction("Database", "F_ProfPorEsp")]
        public virtual IQueryable<F_ProfPorEsp_Result> F_ProfPorEsp(Nullable<int> especialidad)
        {
            var especialidadParameter = especialidad.HasValue ?
                new ObjectParameter("especialidad", especialidad) :
                new ObjectParameter("especialidad", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.CreateQuery<F_ProfPorEsp_Result>("[Database].[F_ProfPorEsp](@especialidad)", especialidadParameter);
        }
    
        [DbFunction("Database", "F_TurnosProf")]
        public virtual IQueryable<F_TurnosProf_Result> F_TurnosProf(Nullable<int> prof, Nullable<System.DateTime> fecha)
        {
            var profParameter = prof.HasValue ?
                new ObjectParameter("prof", prof) :
                new ObjectParameter("prof", typeof(int));
    
            var fechaParameter = fecha.HasValue ?
                new ObjectParameter("fecha", fecha) :
                new ObjectParameter("fecha", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.CreateQuery<F_TurnosProf_Result>("[Database].[F_TurnosProf](@prof, @fecha)", profParameter, fechaParameter);
        }
    
        [DbFunction("Database", "FechasDisponibles")]
        public virtual IQueryable<FechasDisponibles_Result> FechasDisponibles(Nullable<int> profesionalId, Nullable<int> especialidadId)
        {
            var profesionalIdParameter = profesionalId.HasValue ?
                new ObjectParameter("profesionalId", profesionalId) :
                new ObjectParameter("profesionalId", typeof(int));
    
            var especialidadIdParameter = especialidadId.HasValue ?
                new ObjectParameter("especialidadId", especialidadId) :
                new ObjectParameter("especialidadId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.CreateQuery<FechasDisponibles_Result>("[Database].[FechasDisponibles](@profesionalId, @especialidadId)", profesionalIdParameter, especialidadIdParameter);
        }
    
        [DbFunction("Database", "HorasDisponibles")]
        public virtual IQueryable<HorasDisponibles_Result> HorasDisponibles(Nullable<int> profesionalId, Nullable<int> especialidadId, string fechaStr)
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
    
            return ((IObjectContextAdapter)this).ObjectContext.CreateQuery<HorasDisponibles_Result>("[Database].[HorasDisponibles](@profesionalId, @especialidadId, @fechaStr)", profesionalIdParameter, especialidadIdParameter, fechaStrParameter);
        }
    
        public virtual int CompraBono(Nullable<int> afiliadoId, Nullable<int> cant, Nullable<int> planMedicoId)
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
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("CompraBono", afiliadoIdParameter, cantParameter, planMedicoIdParameter);
        }
    
        public virtual ObjectResult<Nullable<int>> HorasDisponibless(Nullable<int> profesionalId, Nullable<int> especialidadId, string fechaStr)
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
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<int>>("HorasDisponibless", profesionalIdParameter, especialidadIdParameter, fechaStrParameter);
        }
    
        public virtual ObjectResult<TurnosProfesionalEspecialidad_Result> TurnosProfesionalEspecialidad(Nullable<int> profesionalId, Nullable<int> especialidadId, string fecha)
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
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<TurnosProfesionalEspecialidad_Result>("TurnosProfesionalEspecialidad", profesionalIdParameter, especialidadIdParameter, fechaParameter);
        }
    }
}
