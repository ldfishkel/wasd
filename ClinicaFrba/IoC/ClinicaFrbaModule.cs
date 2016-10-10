namespace ClinicaFrba.IoC
{
    using Autofac;
    using ClinicaFrba.AbmAfiliado;
    using ClinicaFrba.AbmRol;
    using ClinicaFrba.CancelarTurno;
    using ClinicaFrba.CompraBono;
    using ClinicaFrba.Diagnosticar;
    using ClinicaFrba.Menu;
    using ClinicaFrba.PedirTurno;
    using ClinicaFrba.RegistrarAgenda;
    using ClinicaFrba.RegistrarLlegada;
    using ClinicaFrba.VerEstadisticas;

    public class ClinicaFrbaModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            base.Load(builder);

            //Functions Froms
            builder.RegisterType<ABMAfiliadosForm>().AsSelf();
            builder.RegisterType<ABMRolForm>().AsSelf();
            builder.RegisterType<CancelarTurnoForm>().AsSelf();
            builder.RegisterType<ComprarBonoForm>().AsSelf();
            builder.RegisterType<DiagnosticarForm>().AsSelf();
            builder.RegisterType<PedirTurnoForm>().AsSelf();
            builder.RegisterType<RegistrarAgendaForm>().AsSelf();
            builder.RegisterType<RegistrarLlegadaForm>().AsSelf();
            builder.RegisterType<VerEstadisticasForm>().AsSelf();
            builder.RegisterType<MenuForm>().AsSelf();

        }
    }
}
