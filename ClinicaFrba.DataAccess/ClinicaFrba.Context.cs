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
            : base("name=Database3")
        {
        }

        public Database(string connectionString)
            : base(connectionString)
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
        public virtual DbSet<Especialidad> Especialidads { get; set; }
        public virtual DbSet<EstadoCivil> EstadoCivils { get; set; }
        public virtual DbSet<Funcionalidad> Funcionalidads { get; set; }
        public virtual DbSet<HistorialPlan> HistorialPlans { get; set; }
        public virtual DbSet<PlanMedico> PlanMedicoes { get; set; }
        public virtual DbSet<Profesional> Profesionals { get; set; }
        public virtual DbSet<Rol> Rols { get; set; }
        public virtual DbSet<Sexo> Sexoes { get; set; }
        public virtual DbSet<TipoDocumento> TipoDocumentoes { get; set; }
        public virtual DbSet<TipoEspecialidad> TipoEspecialidads { get; set; }
        public virtual DbSet<Turno> Turnoes { get; set; }
        public virtual DbSet<Usuario> Usuarios { get; set; }
    
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
    }
}
